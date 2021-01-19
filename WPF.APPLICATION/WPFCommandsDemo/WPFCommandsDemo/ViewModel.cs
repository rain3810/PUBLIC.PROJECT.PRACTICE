using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    class ViewModel
    {
        public ICommand MyCommand { get; set; }
        public ViewModel()
        {
            //인자로 동작 자체를 넘겨주었음.
            MyCommand = new Command(ExecutMethod, CanExecuteMethod);
        }

        void ExecutMethod(object obj)
        {
            MessageBox.Show("코드비하인드가 아닌 Command ExecuteMethod");
        }

        bool CanExecuteMethod(object obj) { return true; }


    }
}
