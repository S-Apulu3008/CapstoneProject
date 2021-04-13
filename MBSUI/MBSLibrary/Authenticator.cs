using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class Authenticator
    {
        DataAccess db = new DataAccess();
        public Employee Login(string employeeId, string password)
        {
            List<Employee> employees = db.GetEmployees(employeeId);

            return employees[0];
        }
    }
}
