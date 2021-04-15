using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class Employee : INotifyPropertyChanged
    {

        private string _employeeID;
        private string _firstName;
        private string _lastName;
        private string _password;

        public string EmployeeID
        {
            get 
            { 
                return _employeeID; 
            }
            set 
            { 
                _employeeID = value;
                NotifyPropertyChanged(EmployeeID);
            }
        }

        public string FirstName 
        {
            get 
            {
                return _firstName;
            }
            set 
            {
                _firstName = value;
                NotifyPropertyChanged(FirstName);
            }
        }

        public string LastName 
        {
            get 
            {
                return _lastName;
            }
            set 
            {
                _lastName = value;
                NotifyPropertyChanged(LastName);
            }
        }

        public string Password 
        {
            get 
            {
                return _password;
            }
            set 
            {
                _password = value;
                NotifyPropertyChanged(Password);
            }
        }


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
