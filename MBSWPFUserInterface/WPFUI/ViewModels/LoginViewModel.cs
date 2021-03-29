using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.Commands;

namespace WPFUI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }

        public LoginViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
