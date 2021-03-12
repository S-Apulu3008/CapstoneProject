using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class DataAccess
    {
        public List<Customer> GetCustomers(string Email) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBS-Database"))) 
            {
                var output = connection.Query<Customer>($"select * from CustomerAccounts where Email = '{Email}'").ToList();
                return output;
            }
        }

        public List<Employee> GetEmployees(string EmployeeID) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBS-Database")))
            {
                var output =  connection.Query<Employee>($"select * from EmployeeAccounts where EmployeeID = '{EmployeeID}'").ToList();
                return output;
            }
        }

    }
}
