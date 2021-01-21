using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCommandsDemo2.ViewModel
{
    /// <summary>
    /// 바인딩할 객체같은것
    /// 동작할 함수와 속성을 관리하고 해당 함수들은 COmmand에 넘겨 이벤트 시 동작하도록 한다.
    /// </summary>
    public class MessageViewModel
    {
        public Command.MessageCommand DisplayMessageCommand
        {
            get; private set;
        }
        public string MessageText { get; set; }

        public MessageViewModel()
        {
            this.DisplayMessageCommand = new Command.MessageCommand(DisplayMessage);
        }

        public void DisplayMessage()
        {
            MessageBox.Show(MessageText);
        }
    }

}
