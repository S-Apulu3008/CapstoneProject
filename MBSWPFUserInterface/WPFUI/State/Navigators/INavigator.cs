using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.ViewModels;

namespace WPFUI.State.Navigators
{
    public enum ViewType
    {
        Home,
        Login,
        Manager,
        Register
    }

    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelComand { get; }

    }
}
