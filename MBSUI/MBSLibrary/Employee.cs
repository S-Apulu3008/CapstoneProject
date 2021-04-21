using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool _isManager;

        public string EmployeeID
        {
            get 
            { 
                return _employeeID; 
            }
            set 
            { 
                _employeeID = value;
                OnPropertyChanged();
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
                OnPropertyChanged(); ;
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
                OnPropertyChanged(); ;
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
                OnPropertyChanged();
            }
        }

        public bool IsManager
        {
            get 
            { 
                return _isManager; 
            }
            set 
            { 
                _isManager = value; 
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null) 
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
