using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp5
{
    class MyMain : Application
    {
        [STAThread]
        public static void Main()
        {
            MyMain app = new MyMain();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Main WIndow
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += MainWindow_MouseDown;
            mainWindow.Show();

            //Sub Window
            for (int i = 0; i < 2; i++)
            {
                Window sub = new Window();
                sub.Title = "Extra WIndow No . " + (i + 1);
                sub.Show();
            }
        }

        private void MainWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window win = new Window();
            win.Title = "Modal DoalogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Clock Me!";
            b.Click += B_Click;

            win.Content = b;
            win.ShowDialog();
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button CLick ", sender.ToString());
        }
    }
}
