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
                    piList.Add(new PIViewModel() { LOC_CODE = sqlRd["loc_code"].ToString(), CNT = "0", PI_NO = sqlRd["pi_no"].ToString(), SEND_YN = sqlRd["send_yn"].ToString(), LAMPOn = false });

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

                        PIViewModel onPi = piList.First(pi => pi.PI_NO == logInfo.PI_No);
                        if (onPi == null)
                            continue;

                        onPi.LAMPOn = (logInfo.PI_LampAttribute == 64) ? false : true;
                        onPi.CNT = logInfo.Send_Data.Replace(" ", "");

                        strQuery = string.Format(@"update lt_pi_loc set send_yn = '{1}', upd_date = getdate() where pi_no ='{0}' and send_yn ='N'", logInfo.PI_No, (row["auto_yn"].ToString() == "Y") ? "Y" : "T");
                        piNewRow = this.FnPILogSelect(strQuery);      //PI에서 저장된 새로운 ROW 체크

                    }
                    //if (!string.IsNullOrEmpty(lastq))
                    //    this.WorkMessageAdd("마지막REQUEES" + lastq);
                }
                catch (Exception ex)
                {
                    if (!this.isRunBCUThread)
                        return;

                    Console.WriteLine("tmBCU_Tick - " + ex.ToString());
                }
                finally
                {
                    if (!string.IsNullOrEmpty(log.Trim()))
                        Console.WriteLine("Interface - " + log);

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pi_no = (sender as Button).Tag.ToString();

                PIViewModel clickPI = piList.First(pi => pi.PI_NO == pi_no);

                clickPI.LAMPOn = !clickPI.LAMPOn;

                this.DataContext = piList;

                return;
                if (clickPI == null || !clickPI.LAMPOn)
                    return;

                string query = string.Format(@"update lt_pi_loc set send_yn = 'P', upd_date = getdate() where pi_no = '{0}' and send_yn = 'T'", clickPI.PI_NO);

                this.FnPILogSelect(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
