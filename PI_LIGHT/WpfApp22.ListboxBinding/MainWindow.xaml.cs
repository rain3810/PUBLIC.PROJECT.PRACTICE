using System;
using System.Collections.Generic;
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

namespace WpfApp22.ListboxBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Pies codeBehindpies = new Pies();

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = codeBehindpies;
        }

        //추가 버튼
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow();

            this.RefreshListEvent += MainWindow_RefreshListEvent;
            //RefreshListEvent
            subWindow.UpdateActor = RefreshListEvent;
            subWindow.Show();



        }

        private void MainWindow_RefreshListEvent(PI.ZONEType zoneType)
        {
            switch (zoneType)
            {
                case PI.ZONEType.A:
                    this.myListbox.SelectedIndex = 0;
                    break;
                case PI.ZONEType.B:
                    this.myListbox.SelectedIndex = 1;
                    break;
                case PI.ZONEType.C:
                    this.myListbox.SelectedIndex = 2;
                    break;
            }
        }

        //아래쪽 ListBox를 Refresh 하기 위한 델리게이트 및 이벤트
        public delegate void RefreshList(PI.ZONEType zoneType);
        public event RefreshList RefreshListEvent;





        //상단 ZONE 선택
        private void myListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;

            if (listBox.SelectedItem == null)
                return;

            string zoneType = (listBox.SelectedItem as ListBoxItem).Content.ToString();

            this.DataContext = codeBehindpies.Where(pi => pi.ZoneType.ToString() == zoneType);
        }

        //하단 항목 선택 시
        private void myListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PI item = (PI)myListBox2.SelectedItem;
            //string value = (item == null) ? "No Selection" : item.ToString();

            MessageBox.Show(string.Format("PC : {0} PI :{1} ZONE :{2}  LOC : {3}", item.PcNo, item.PiNo, item.ZoneType, item.LogCode));
        }
    }
}
