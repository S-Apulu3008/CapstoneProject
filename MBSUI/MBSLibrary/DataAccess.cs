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
        public List<Employee> GetEmployees(string employeeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Employee>($"dbo.GetEmployee @EmployeeID", new { EmployeeID = employeeID }).ToList();
                Console.WriteLine(output);
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
