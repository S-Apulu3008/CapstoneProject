using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSWPF.ViewModels
{
    public class ManagerViewModel : Conductor<object> 
    {
        public void LoadRegisterView() 
        {
            ActivateItem(new RegisterViewModel());
        }
    }
}
