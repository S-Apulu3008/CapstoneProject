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
using Microsoft.AspNet.Identity;

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.CnnVal("MBSDatabase"));        
        DataAccess db = new DataAccess();
        public RegisterView()
        {
            InitializeComponent();
        }

        //Opening a connection to the local database. Then creating a command to add all the information from the manager into the employee table. 
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            Authenticator authenticator = new Authenticator();

            authenticator.Register(txtEmployeeID.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, false);

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
