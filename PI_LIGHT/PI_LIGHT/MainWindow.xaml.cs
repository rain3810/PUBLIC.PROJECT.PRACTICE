using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
                



                //piList.Add(new PIViewModel() { PI_NO = "LOC100", PI_STATUS = "ON" });
                //piList.Add(new PIViewModel() { PI_NO = "LOC101", PI_STATUS = "ON" });
                //piList.Add(new PIViewModel() { PI_NO = "LOC102", PI_STATUS = "OFF" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = null;
            SqlDataReader sqlRd = null;

            try
            {
                piList.Clear();
                sqlCon = new SqlConnection(string.Format("Persist Security Info=False;User ID=sa;Password=tsvr2201@pts;Initial Catalog=GNFOOD_BCU;Server=168.126.28.28,9005"));
                sqlCon.Open();

                SqlCommand com = new SqlCommand(@"select * from lt_pi_loc (nolock)
                                                    where pc_no = 1
                                                    order by loc_code", sqlCon);

                sqlRd = com.ExecuteReader();
                string result = "";

                while (sqlRd.Read())
                {
                    piList.Add(new PIViewModel() { PI_NO = sqlRd["loc_code"].ToString(), PI_STATUS = "OFF" });

                }

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
    }
}
