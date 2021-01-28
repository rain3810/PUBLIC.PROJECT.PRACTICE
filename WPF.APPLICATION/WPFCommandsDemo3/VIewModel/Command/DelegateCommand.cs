using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo3.VIewModel.Command
{
    public class DelegateCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("execute can not null");

            this._execute = execute;
            this._canExecute = canExecute;

        }

        public DelegateCommand(Action<object> execute) : this(execute, null)
        { }

        //내 컨트롤이 아닌, 남의 컨트롤의 상태를 보고, enable 여부를 결정하려면, 
        //남의 컨트롤을 변수로 가지고 있든, 해당 이벤트 사용하든 해야한다.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return (this._execute == null) ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }


    }
}
