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
        public List<Employee> GetEmployees(string EmployeeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Employee>($"select * from EmployeeAccounts where EmployeeID = '{EmployeeID}'").ToList();
                return output;
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                connection.Execute("dbo.AddEmployee", employee, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
