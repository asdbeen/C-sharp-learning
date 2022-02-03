using ICommandInterface.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ICommandInterface.ViewModel
{
    class ButtonViewModel
    {
        public ButtonCommand ButtonCommand { get; set; }

        public ButtonViewModel()
        {
            ButtonCommand = new ButtonCommand(this);
        }

        public void OnExecute()
        {
            MessageBox.Show("Button Is Clicked");
        }
    }
}
