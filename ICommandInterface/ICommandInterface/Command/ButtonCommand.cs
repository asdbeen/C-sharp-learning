using ICommandInterface.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandInterface.Command
{
    class ButtonCommand : ICommand
    {
        ButtonViewModel _buttonViewModel;

        public ButtonCommand(ButtonViewModel viewModel)
        {
            _buttonViewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _buttonViewModel.OnExecute();
        }
    }
}
