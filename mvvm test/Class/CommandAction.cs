using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm_test.Class
{
    public class CommandAction : ICommand
    {

    

        private readonly Action _action;
        private readonly Action<object> _actionObj;

    
        public event EventHandler CanExecuteChanged;


        public CommandAction(Action action)
        {
            _action = action;
        }

        public CommandAction(Action<object> action)
        {
            _actionObj = action;
        }





        public bool CanExecute(object parameter)
        {
            if (_actionObj != null)
            {
            }
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }
}
