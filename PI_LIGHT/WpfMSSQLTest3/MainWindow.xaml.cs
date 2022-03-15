using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace WpfMSSQLTest3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlCon = null;
        SqlDataReader sqlRd = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttin_Click(object sender, RoutedEventArgs e)
        {
            //DB 연결
            sqlCon = new SqlConnection(string.Format("Persist Security Info=False;User ID=sa;Password=tsvr2201@pts;Initial Catalog=GNFOOD_BCU;Server=168.126.28.28,9005"));
            sqlCon.Open();

            MessageBox.Show("DB COnn!");
        }

        private void buttin2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand(@"select * from lt_pi_loc (nolock)
                                                    where pc_no = 1
                                                    order by loc_code", sqlCon);
                sqlRd = com.ExecuteReader();
                List<PIViewModel> result = new List<PIViewModel>();

                while (sqlRd.Read())
                {
                    result.Add(new PIViewModel()
                    {
                        Bcu_no = sqlRd["bcu_no"].ToString(),
                        Pc_no = sqlRd["pc_no"].ToString(),
                        Pi_no = sqlRd["pi_no"].ToString(),
                        Pick_no = sqlRd["pick_no"].ToString(),
                        Auto_yn = sqlRd["auto_yn"].ToString(),
                        Pi_log_data = sqlRd["pi_log_data"].ToString(),
                        Send_yn = sqlRd["send_yn"].ToString()
                    });
                }

                lstView.ItemsSource = result;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (sqlRd != null)
                    sqlRd.Close();
            }
        }
    }
}
