using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.State.Navigators;
using WPFUI.ViewModels;

namespace WPFUI.Commands
{
    public class UpdateCurrentViewModelComand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelComand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Login:
                        _navigator.CurrentViewModel = new LoginViewModel();
                        break;
                    case ViewType.Manager:
                        _navigator.CurrentViewModel = new ManageAccountViewModel();
                        break;
                    case ViewType.Register:
                        _navigator.CurrentViewModel = new RegisterViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}