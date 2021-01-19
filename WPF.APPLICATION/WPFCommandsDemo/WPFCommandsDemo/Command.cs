using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    public class Command : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canexecuteMethod;

        public event EventHandler CanExecuteChanged;

        public Command(Action<object> getExecuteMethod, Func<object, bool> getCanExecuteMethod)
        {
            this._executeMethod = getExecuteMethod;
            this._canexecuteMethod = getCanExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._executeMethod(parameter);
        }
    }
}
