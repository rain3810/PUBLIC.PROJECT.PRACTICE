using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker myThread;
        int sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            myThread = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };

            myThread.DoWork += MyThread_DoWork;

            myThread.ProgressChanged += MyThread_ProgressChanged;

            myThread.RunWorkerCompleted += MyThread_RunWorkerCompleted;

            MessageBox.Show("worker 초기화");
        }

        private void MyThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("작업 취소...");
            else if (e.Error != null)
                MessageBox.Show("에러 발생..." + e.Error);
            else
            {
                lblSum.Content = e.Result.ToString();

                MessageBox.Show("작업 완료!!!");
            }

        }

        private void MyThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;

        }

        private void MyThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument;

            for (int i = 1; i <= count; i++)
            {
                if (myThread.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(100);


                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        e.Result = sum;
                        lstNumber.Items.Add(i);
                    }
                });

                myThread.ReportProgress(i);
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int num;

            if (!int.TryParse(this.txtNumber.Text, out num))
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }

            this.progressBar.Maximum = num;
            this.lstNumber.Items.Clear();

            this.myThread.RunWorkerAsync(num);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            myThread.CancelAsync();
        }
    }
}
