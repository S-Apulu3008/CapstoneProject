using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class Customer : INotifyPropertyChanged
    {
        //Fields


        //Properties
        private string _email;

        public string Email
        {
            get 
            { return _email; 
            }
            set 
            { _email = value;
                NotifyPropertyChanged(Email);
            }
        }


       public string FirstName { get; set; }

       public string LastName { get; set; }

        private string _password;

        public string Password
        {
            get 
            { return _password; 
            }
            set 
            { _password = value;
                NotifyPropertyChanged(Password);
            }
        }


        //Methods
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string info) 
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
