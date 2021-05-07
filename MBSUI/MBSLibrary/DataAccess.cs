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

        public List<Product> GetProductByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Product>($"dbo.GetProductsByName @Name", new { Name = name }).ToList();
                return output;
            }
        }

        public List<Product> GetProductByGenre(string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Product>($"dbo.GetProductsByGenre @Genre", new { Genre = genre }).ToList();
                return output;
            }
        }

        public List<Product> GetProductBySKU(int sku)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Product>($"dbo.GetProductsBySKU @SKU", new { SKU = sku }).ToList();
                return output;
            }
        }

        public List<Product> GetReorderedItems()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MBSDatabase")))
            {
                var output = connection.Query<Product>("dbo.GetReorderItems").ToList();
                return output;
            }
        }

    }
}
