using Dapper;
using MBSLibrary.Models;
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.CnnVal("MBS-Database")))
            {
                var output =  connection.Query<Employee>($"dbo.GetEmployee @EmployeeID", new {EmployeeID = employeeID }).ToList();
                return output;
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.CnnVal("MBS-Database")))
            {
                connection.Execute("dbo.AddEmployee", employee, commandType: CommandType.StoredProcedure);                
            }
        }

    }
}
