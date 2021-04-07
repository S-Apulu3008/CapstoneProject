using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSWPF.ViewModels
{
    //Screen allows more control to open and close views.
    public class ShellViewModel : Conductor<object>
    {
        private HomeViewModel _homeVM;
        
        //Load login when shell view starts
        //Getting a login viewmodel and storing it in a private variable
        public ShellViewModel(HomeViewModel homeVM)
        {
            //Constructor injection to pass in an instance then activate to use later.
            _homeVM = homeVM;
            //Load the login form on the shell viem model
            ActivateItem(_homeVM);
        }

        //Create a new instance of the home view model. 
        public void LoadHomeView() 
        {
            ActivateItem(new HomeViewModel());
        }

        //Create a new instance of the register view model
        public void LoadAccountView() 
        {
            ActivateItem(new AccountViewModel());
        }
    }
}
