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
