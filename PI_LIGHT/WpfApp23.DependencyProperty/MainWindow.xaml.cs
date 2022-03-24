using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp23.DependencyPropertyTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //DependencyProperty(MyProperty)를 위한 래퍼속성 MyColor
        //이 래퍼속성에서는 System.Windows.DependencyObject 클래스의
        //GetValue()와 SetValue() 메서드 지원
        public string MyColor
        {
            get
            { return (string)GetValue(MyProperty); }
            set
            { SetValue(MyProperty, value); }
        }

        //의존속성(Dependency Property) MyProperty
        //DependencyProperty 클래스에는 public 생성자가 없기 때문에, static 메서드인 DependencyProperty 이용
        //대부분 의존속성은 FrmaeworkElement에 Dependency로 정의되어있다.
        public static readonly DependencyProperty MyProperty = DependencyProperty.Register(
            "MyColor",          //의존 속성으로 등록될 Wrapper 속성
            typeof(string),     //등록할 의존속성 타입
            typeof(MainWindow), //의존속성을 소유하게 될 Owner (소유자)

            //속성값 변경 시 호출될 메소드
            //프로퍼티 값의 변경에 따른 Callback 메서드 등 새로운 속성을 추가하기위해
            //FrameworkPropertyMetadata를 인자 값으로 전달 할수 있다.
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnMyPropertyChanged)));

        /// <summary>
        /// 속상값 변경시 호출될 메서드
        /// 프로퍼티 값의 변경에 따른 Callback 메서드 등 새로운 속성을 추가하기 위해
        /// FrameworkPropertyMeta를 인자 값으로 전달 할 수 있다.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnMyPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = obj as MainWindow;
            win.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(e.NewValue.ToString());
            win.Title = "이전 배경색 : " + e.OldValue?.ToString();
            win.txtColorName.Text = e.NewValue.ToString();
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string color = (e.Source as MenuItem).Header as string;
            MyColor = color;
        }
    }
}
