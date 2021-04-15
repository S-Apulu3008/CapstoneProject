using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MBSLibrary;

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.CnnVal("MBSDatabase"));
        public RegisterView()
        {
            InitializeComponent();
        }

        //Opening a connection to the local database. Then creating a command to add all the information from the manager into the employee table. 
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [EmployeeAccounts] (EmployeeID, FirstName, LastName, Password) values " +
                "('" + txtEmployeeID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPassword.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            txtEmployeeID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            MessageBox.Show("Employee has been added.");
        }

        //Viewing the current table and the new employee if added into the program.
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [EmployeeAccounts]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dta);
            employeeDataGrid.ItemsSource = dta.DefaultView;
            con.Close();
        }
    }
}
