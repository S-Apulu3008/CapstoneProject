using MBSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Employee Login(string employeeId, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string employeeId, string firstName, string lastName, string password, string confirmPassword, string isManager)
        {
            bool sucess = false;            
            
            if(confirmPassword==password)
            {
                DataAccess db = new DataAccess();

                Employee employee = new Employee()
                {
                    EmployeeID = employeeId,
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    IsManager = bool.Parse(isManager)
                };

                db.AddEmployee(employee);

                sucess = true;
            }

            return sucess;
        }
    }
}
