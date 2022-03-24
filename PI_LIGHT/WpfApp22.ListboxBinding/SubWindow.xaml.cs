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
using System.Windows.Shapes;

namespace WpfApp22.ListboxBinding
{
    /// <summary>
    /// SubWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubWindow : Window
    {
        //메인 윈도우의 하단 Listbox에 Refresh 위한 델리게이트
        //메인 화면에서 PI추가 버튼 클릭 시 이벤트 할당.
        public Delegate UpdateActor;


        public SubWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(bool)this.rdoAZone.IsChecked && !(bool)this.rdoBZone.IsChecked && !(bool)this.rdoCZone.IsChecked)
            {
                MessageBox.Show("Zone 선택 필요");
                return;
            }

            PI.ZONEType zoneType = ((bool)this.rdoAZone.IsChecked) ? PI.ZONEType.A : ((bool)this.rdoBZone.IsChecked) ? PI.ZONEType.B : PI.ZONEType.C;
            MainWindow.codeBehindpies.Add(new PI("1", "1", this.txtPINO.Text, this.txtLocCode.Text, zoneType, PI.STATUSType.OFF));

            UpdateActor.DynamicInvoke(zoneType);

            MessageBox.Show("저장 완료");
            this.Close();
        }
    }
}
