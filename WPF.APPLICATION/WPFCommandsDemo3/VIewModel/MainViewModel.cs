using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFCommandsDemo3.VIewModel.Command;

namespace WPFCommandsDemo3.VIewModel
{
    public class MainViewModel
    {
        /// <summary>
        /// Combobox 용 리스트 컬렉션
        /// </summary>
        public ObservableCollection<string> MyMessages { get; private set; } = new ObservableCollection<string>() { "안녕하세요!", "제 이름은 KYH입니다.", "메세지박스", "콘솔" };

        /// <summary>
        /// Button-MessageBox 용 Command
        /// </summary>
        public DelegateCommand MessageBoxCommand { get; private set; }

        /// <summary>
        /// Button-Consol용 Command
        /// </summary>
        public DelegateCommand ConsoleCommand { get; private set; }

        public MainViewModel()
        {
            this.MessageBoxCommand = new DelegateCommand(this.DisplayMessageBox, this.MessageBoxCanUse);
            this.ConsoleCommand = new DelegateCommand(this.DisplayConsole, this.ConsoleCanUse);
        }

        public void DisplayMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayConsole(object message)
        {
            Console.WriteLine(message);
        }

        public bool MessageBoxCanUse(object message)
        {
            return !(message?.ToString() == "콘솔");
        }

        public bool ConsoleCanUse(object message)
        {
            return !(message?.ToString() == "메세지박스");
        }
    }
}
