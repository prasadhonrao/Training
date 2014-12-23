using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Command
{
    public class SavePersonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action _executeCommand; 
        public SavePersonCommand(Action executeCommand)
        {
            _executeCommand = executeCommand;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeCommand();
        }
    }
}
