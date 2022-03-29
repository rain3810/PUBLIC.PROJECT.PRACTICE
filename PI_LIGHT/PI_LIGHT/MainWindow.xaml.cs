using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PI_LIGHT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Lazy<PIList> PIListInstance { get; set; }
        string BCUNO = "";
        string PCNO = "";
        public MainWindow()
        {
            //PIListInstance = new Lazy<PIList>();
            InitializeComponent();
            piList = this.FindResource("piList") as PIList;
        }
        PIList piList = null;

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                piList.Clear();
                this.DataContext = this.piList;


                //piList.Add(new PIViewModel() { PI_NO = "LOC100", PI_STATUS = "ON" });
                //piList.Add(new PIViewModel() { PI_NO = "LOC101", PI_STATUS = "ON" });
                //piList.Add(new PIViewModel() { PI_NO = "LOC102", PI_STATUS = "OFF" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void window_Loaded(object sender, RoutedEventArgs e) { }
        //{
        //    SqlConnection sqlCon = null;
        //    SqlDataReader sqlRd = null;

        //    try
        //    {
        //        piList.Clear();
        //        sqlCon = new SqlConnection(string.Format("Persist Security Info=False;User ID=sa;Password=tsvr2201@pts;Initial Catalog=GNFOOD_BCU;Server=168.126.28.28,9005"));
        //        sqlCon.Open();

        //        SqlCommand com = new SqlCommand(@"select wh_code, pi_kind, bcu_no, pc_no, pi_no, loc_code, pi_log_data
        //                                        , case when pi_no %4 =1  then 'Y' else 'N' end AS PI_STATUS
        //                                            from lt_pi_loc (nolock)
        //                                            where pc_no = 1
        //                                            order by loc_code", sqlCon);

        //        sqlRd = com.ExecuteReader();
        //        string result = "";

        //        while (sqlRd.Read())
        //        {
        //            piList.Add(new PIViewModel() { PI_NO = sqlRd["loc_code"].ToString(), PI_STATUS = sqlRd["PI_STATUS"].ToString() });

        //        }

        //        this.DataContext = piList;
        //        //MessageBox.Show(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (sqlRd != null)
        //            sqlRd.Close();

        //        if (sqlCon != null)
        //            sqlCon.Close();
        //    }
        //}

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = null;
            SqlDataReader sqlRd = null;

            try
            {
                this.BCUNO = this.txtBCUNO.Text;
                this.PCNO = this.txtPCNO.Text;


                piList.Clear();
                sqlCon = new SqlConnection(string.Format("Persist Security Info=False;User ID=sa;Password=tsvr2201@pts;Initial Catalog=GNFOOD_BCU;Server=168.126.28.28,9005"));
                sqlCon.Open();

                SqlCommand com = new SqlCommand(string.Format(@"select wh_code, pi_kind, bcu_no, pc_no, pi_no, loc_code, pi_log_data, pick_no
                                                , send_yn, auto_yn
                                                    from lt_pi_loc (nolock)
                                                    where bcu_no = {0} and pc_no = {1}
                                                    order by loc_code", this.BCUNO, this.PCNO), sqlCon);

                sqlRd = com.ExecuteReader();
                string result = "";

                while (sqlRd.Read())
                {
                    piList.Add(new PIViewModel() { PI_NO = sqlRd["loc_code"].ToString(), SEND_YN = sqlRd["send_yn"].ToString(), PICK_NO = sqlRd["pick_no"].ToString() });

                }

                this.DataContext = piList;
                //MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (sqlRd != null)
                    sqlRd.Close();

                if (sqlCon != null)
                    sqlCon.Close();
            }
        }

        Thread BCUThread = null;
        bool isRunBCUThread = false;
        private void StartPIThread()
        {

            try
            {
                //2020.01.16 김윤화 수정 - BCU와의 요청/응답의 안정성을 위해 SEND와 REQUEST를 순차적으로 사용하는 쓰레드 추가
                if (this.BCUThread == null)
                {
                    this.BCUThread = new Thread(new ThreadStart(threadBCU));
                    this.BCUThread.Priority = ThreadPriority.Normal;
                    this.isRunBCUThread = true;
                    this.BCUThread.Start();
                }
                return;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void StopPIThread()
        {

            try
            {
                //2020.01.16 김윤화 수정 - BCU와의 요청/응답의 안정성을 위해 SEND와 REQUEST를 순차적으로 사용하는 쓰레드 추가
                if (this.BCUThread != null)
                {
                    this.isRunBCUThread = false;


                    this.BCUThread.Join();
                    this.BCUThread = null;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void threadBCU()
        {
            while (this.isRunBCUThread)
            {
                string log = string.Empty;

                try
                {
                    //BCU로 받을 데이터 확인
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff - SEND 시작"));

                    //새로운 Row 검색 (N)
                    //DataTable piNewRow = BCUHelper.Instance.FnPILogSelect(0, null, "N", null, UICommon.ConfigHelper.Instance.BCUNo);      //PI에서 저장된 새로운 ROW 체크

                    //PI에서 저장된 새로운 ROW 체크
                    string strQuery = string.Format(@"SELECT pc_no, pi_no, pick_no,pi_log_data, send_yn, auto_yn FROM lt_pi_loc (nolock) 
                                                        where bcu_no = '{0}' and send_yn = 'N' 
                                                        order by  upd_date, convert(int, pi_no)", this.BCUNO);

                    DataTable piNewRow = this.FnPILogSelect(strQuery);      //PI에서 저장된 새로운 ROW 체크

                    foreach (DataRow row in piNewRow.Rows)
                    {
                        Thread.Sleep(20);


                        BCUInfo logInfo = new BCUInfo(row["pi_log_data"].ToString(), "seq_non");

                        //@F와 같이 일괄 적용 건은 ack가 아닌, bcu정보가 응답값으로 오므로, 
                        if (logInfo.LogType == "TYPE3")
                        {
                            BCUHelper.Instance.FnPILogUpdate(row["pi_no"].ToString(), "N", null, (row["auto_yn"].ToString() == "Y") ? "Y" : "T", UICommon.ConfigHelper.Instance.BCUPCNo);
                            this.WorkMessageAdd(string.Format("[SEND 완료] : [pick-{0}] {1}", row["pick_no"].ToString(), row["pi_log_data"].ToString()));
                            Thread.Sleep(100);
                            continue;
                        }

                        //2020.01.14 김윤화 추가 - PI 점등 건에 대해서도 응답값 보도록 추가
                        string recvString = string.Empty;

                        for (int j = 0; j < 20; j++)
                        {
                            Thread.Sleep(10);
                            Application.DoEvents();

                            if (ZDeviceManager.Instance.BCU_71.CurrentReceiveData == "")
                                continue;
                            recvString = ZDeviceManager.Instance.BCU_71.CurrentReceiveData;
                            ZDeviceManager.Instance.BCU_71.CurrentReceiveData = "";
                            break;
                        }


                        if (string.IsNullOrEmpty(recvString.Trim())) continue;
                        if (recvString.Length < 5) continue;
                        try
                        {
                            string sFunctionCode = recvString.Substring(0, 1);
                            string sRtnBCU = recvString.Substring(1, 2);
                            string sRtnPI = recvString.Substring(3, 2);

                            if (sFunctionCode != ((char)Const.cbAck).ToString())
                                continue;

                            if (String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())) == sRtnPI)
                            {
                                BCUHelper.Instance.FnPILogUpdate(row["pi_no"].ToString(), "N", null, (row["auto_yn"].ToString() == "Y") ? "Y" : "T", UICommon.ConfigHelper.Instance.BCUPCNo, recvString);
                                this.WorkMessageAdd(string.Format("[SEND 완료] : [pick-{0}] {1}", row["pick_no"].ToString(), row["pi_log_data"].ToString()));
                            }
                            else
                            {
                                FuncEx._WriteErrorLog("tmBCU_Tick", string.Format("[SEND 다른Return] 점등PI:{0}/ReturnPI:{1} ({2})", String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())), sRtnPI, recvString));
                            }
                        }
                        catch (Exception ex)
                        {
                            FuncEx._WriteErrorLog("tmBCU_Tick", string.Format("[SEND EXP]  점등PI:{0}/ReturnValue:{1}/ex:{2} ", String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())), recvString, ex.ToString()));
                            continue;
                        }
                        //2020.01.14 김윤화 추가 - PI 점등 건에 대해서도 응답값 보도록 추가
                    }


                    //BCU로 읽을 데이터 확인
                    //PI의 현재 상태가 필요한 데이터 (T)
                    DataTable piRequestRow = BCUHelper.Instance.FnPILogSelect(112, null, "T", "N", UICommon.ConfigHelper.Instance.BCUNo);

                    foreach (DataRow row in piRequestRow.Rows)
                    {
                        Thread.Sleep(50);
                        BCUInfo requestInfo = new BCUInfo(row["pi_log_data"].ToString(), "seq_non");
                        byte[] responseByte;

                        byte[] readByte = BCUHelper.Instance.FnConvertRequestData(requestInfo.BCU_ID, requestInfo.PI_No, "R", out responseByte);

                        log += string.Format("[{0} 요청]-{1} (PI:{2})\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), BitConverter.ToString(readByte), row["pi_log_data"].ToString());

                        ZDeviceManager.Instance.BCU_71.CurrentReceiveData = string.Empty;
                        ZDeviceManager.Instance.BCU_71.Send(readByte, 0, readByte.Length);

                        string recvString = string.Empty;

                        for (int j = 0; j < 20; j++)
                        {
                            Thread.Sleep(10);
                            Application.DoEvents();

                            if (ZDeviceManager.Instance.BCU_71.CurrentReceiveData == "")
                                continue;
                            recvString = ZDeviceManager.Instance.BCU_71.CurrentReceiveData;
                            ZDeviceManager.Instance.BCU_71.CurrentReceiveData = "";
                            break;
                        }

                        if (string.IsNullOrEmpty(recvString.Trim())) continue;

                        //FuncEx._WriteErrorLog("4", recvString);

                        try
                        {
                            //2018.11.09 김윤화 추가 - 응답 신호 중, DAS의 풀박스를 의미하는 신호("8      ")가 오는 경우는 Skip 하도록 수정
                            if (recvString.StxAndEtxRemove().Length <= 6) continue;     //값 없이 오는 무의미한 값은 Skpi 하도록 수정
                            if (recvString.Left(1) == "?")
                            {
                                log += string.Format("[{0} 응답(오류)]-{1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), recvString);
                                //FuncEx._WriteLog("Interface", log, "Log\\ToBCUData\\");
                                //FuncEx._WriteErrorLog("tmBCU_Tick", string.Format("[REQUEST 변화없음] 요청PI:{0}/ReturnValue:{1}", String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())), recvString));
                                continue;
                            }

                            string sRtnBCU = recvString.Substring(1, 2);
                            string sRtnPI = recvString.Substring(4, 2);
                            string sJCnt = recvString.Substring(6, 1);
                            string sRtnDataBlock = recvString.Substring(7, 7);
                            string sSkipSignal = "8      ";

                            if (sRtnDataBlock == sSkipSignal)
                            {
                                log += string.Format("[{0} 응답(스킵)]-{1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), recvString);

                                //this.WorkMessageAdd(string.Format("[REQUEST SKIP] : [pick-{0}] {1} ({2})", row["pick_no"].ToString(), row["pi_log_data"].ToString(), recvString),log);
                            }
                            //2018.11.09 김윤화 추가 - 응답 신호 중, DAS의 풀박스를 의미하는 신호("8      ")가 오는 경우는 Skip 하도록 수정

                            //2018.06.11 김윤화 추가 - 요청했던 PI값과 return된 PI값이 같을 경우에만 처리하도록 수정
                            else if (sJCnt != "0" && recvString.Substring(3, 1) == "r" && String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())) == sRtnPI)
                            //2018.06.11 김윤화 추가 - 요청했던 PI값과 return된 PI값이 같을 경우에만 처리하도록 수정
                            {
                                log += string.Format("[{0} 응답(완료)]-{1} (완료신호전송완료:{2})\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), recvString, BitConverter.ToString(responseByte));

                                ZDeviceManager.Instance.BCU_71.CurrentReceiveData = string.Empty;
                                ZDeviceManager.Instance.BCU_71.Send(responseByte, 0, responseByte.Length);

                                BCUHelper.Instance.FnPILogUpdate(row["pi_no"].ToString(), "T", null, "P", UICommon.ConfigHelper.Instance.BCUPCNo, recvString);

                                //FuncEx._WriteLog("[응답수신성공]", string.Format("[수신성공응답 완료] : {0} (pi : {1} 수량 : {2})", Encoding.ASCII.GetString(responseByte), sRtnPI, sJCnt), "Log\\BCULogData\\");

                                this.WorkMessageAdd(string.Format("[REQUEST 완료] : [pick-{0}] {1} ({2})(PI:{3}/CNT:{4})", row["pick_no"].ToString(), row["pi_log_data"].ToString(), recvString, sRtnPI, sRtnDataBlock));
                            }
                            else if (sJCnt != "0" && recvString.Substring(3, 1) == "r")
                            {
                                FuncEx._WriteErrorLog("tmBCU_Tick", string.Format("[REQUEST 다른Return] 요청PI:{0}/ReturnPI:{1} ({2})", String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())), sRtnPI, recvString));
                            }
                        }
                        catch (Exception ex)
                        {
                            FuncEx._WriteErrorLog("tmBCU_Tick", string.Format("[REQUEST EXP] 요청PI:{0}/ReturnValue:{1}/ex:{2} ", String.Format("{0:X2}", int.Parse(row["pi_no"].ToString())), recvString, ex.ToString()));
                            continue;
                        }
                    }
                    //if (!string.IsNullOrEmpty(lastq))
                    //    this.WorkMessageAdd("마지막REQUEES" + lastq);
                }
                catch (Exception ex)
                {
                    if (!this.isRunBCUThread)
                        return;

                    FuncEx._WriteErrorLog("tmBCU_Tick", ex.ToString());
                }
                finally
                {
                    if (!string.IsNullOrEmpty(log.Trim()))
                        FuncEx._WriteLog("Interface", log, "Log\\ToBCUData\\");

                    if (this.BCUThread != null)
                        this.BCUThread.Join(50);
                }
            }
        }

        public DataTable FnPILogSelect(string Query)//(int getTopCount, string getPiNo, string getSendYn, string getAutoYn, string getBCUNo = null)
        {
            SqlConnection sqlCon = null;
            SqlDataReader sqlRd = null;
            try
            {
                sqlCon = new SqlConnection(string.Format("Persist Security Info=False;User ID=sa;Password=tsvr2201@pts;Initial Catalog=GNFOOD_BCU;Server=168.126.28.28,9005"));
                sqlCon.Open();

                SqlCommand com = new SqlCommand(Query, sqlCon);
                sqlRd = com.ExecuteReader();

                DataTable dt = new DataTable();


                for (int i = 0; i < sqlRd.FieldCount; i++)
                {
                    dt.Columns.Add(sqlRd.GetColumnSchema()[i].ColumnName.ToString());
                }

                while (sqlRd.Read())
                {
                    DataRow addRow = dt.NewRow();

                    for (int colIdx = 0; colIdx < dt.Columns.Count; colIdx++)
                    {
                        addRow[colIdx] = sqlRd[colIdx];
                    }

                    //piList.Add(new PIViewModel() { PI_NO = sqlRd["loc_code"].ToString(), SEND_YN = sqlRd["send_yn"].ToString(), PICK_NO = sqlRd["pick_no"].ToString() });
                    dt.Rows.Add(addRow);
                }

                //string whereQuery = string.Empty;

                ////2019.04.05 같은 BCU 에 만약  다른 BCU가 2개 이상 접근할 가능성을 위해 추가
                //if (!string.IsNullOrEmpty(getBCUNo)) whereQuery += string.Format(" and bcu_no = '{0}'", getBCUNo);
                //if (!string.IsNullOrEmpty(getPiNo)) whereQuery += string.Format(" and pi_no = '{0}'", getPiNo);
                //if (!string.IsNullOrEmpty(getSendYn)) whereQuery += string.Format(" and send_yn = '{0}'", getSendYn);
                //if (!string.IsNullOrEmpty(getAutoYn)) whereQuery += string.Format(" and auto_yn = '{0}'", getAutoYn);

                //whereQuery = whereQuery.Remove(0, 4); //앞 부분 and 삭제

                //string _strQuery = string.Empty;
                //if (getTopCount > 0)
                //    _strQuery = string.Format(@"SELECT top {0} pc_no, pi_no, pick_no,pi_log_data, send_yn, auto_yn FROM lt_pi_loc (nolock) where {1} order by  upd_date, convert(int, pi_no)", getTopCount.ToString(), whereQuery);
                //else
                //    _strQuery = string.Format(@"SELECT pc_no, pi_no, pick_no,pi_log_data, send_yn, auto_yn FROM lt_pi_loc (nolock) where {1} order by  upd_date, convert(int, pi_no)", getTopCount.ToString(), whereQuery);


                //DataSet dbResult = DbAssistant.ExecuteQuery(2, _strQuery, false);

                //if (dbResult.Tables.Count < 1)
                //    return new DataTable();

                //DataTable dt = dbResult.Tables[0];

                //if (!dbResult.Tables[0].Columns.Contains("pi_log_data"))
                //{
                //    string logMsg = dt.GetColumnRowString();
                //    FuncEx._WriteErrorLog("FnGetPILog", "lt_pi_loc 조회 실패 : " + logMsg);
                //    throw new Exception(logMsg);
                //}

                //return dt;
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            finally
            {
                if (sqlRd != null)
                    sqlRd.Close();

                if (sqlCon != null)
                    sqlCon.Close();
            }
        }





    }
}
