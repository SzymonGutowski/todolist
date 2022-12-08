using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace todolist_core.Helpers
{
    public class PrepCommand : ICommand
    {
        private Action mAction;

        public PrepCommand(Action action)
        {
            mAction = action;
        }
        
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;

        }

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
