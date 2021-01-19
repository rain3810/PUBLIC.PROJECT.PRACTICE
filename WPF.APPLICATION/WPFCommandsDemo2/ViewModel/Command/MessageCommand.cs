using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo2.ViewModel.Command
{
    /// <summary>
    /// 이벤트 발생을 위한 Interface 사용을 위한 Command
    /// </summary>
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action _execute;

        public MessageCommand(Action execute)
        {
            this._execute = execute;
        }


        /// <summary>
        /// 명령 실행 시 선조건으로 발생
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._execute.Invoke();
        }
    }
}
