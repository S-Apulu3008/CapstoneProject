using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MBSLibrary
{
    public class Authenticator
    {
        DataAccess db = new DataAccess();
        IPasswordHasher hasher = new PasswordHasher();
        public Employee Login(string employeeId, string password)
        {
            List<Employee> employees = db.GetEmployees(employeeId);

            PasswordVerificationResult passwordResult = hasher.VerifyHashedPassword(employees[0].Password, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new Exception();
            }
            return employees[0];
        }
    }
}
