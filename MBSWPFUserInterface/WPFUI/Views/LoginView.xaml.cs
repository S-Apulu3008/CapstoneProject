using System;
using System.Collections.Generic;
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
using WPFUI.ViewModels;

namespace WPFUI.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            //con = Helper.CnnVal("MBS-Database");


            DataContext = new LoginViewModel();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) 
        {
            List<Customer> customers = new List<Customer>();
            List<Employee> employees = new List<Employee>();
            
            Customer inputUser = new Customer();
            Employee inputID = new Employee();
            DataAccess db = new DataAccess();

            if (txtUsername.Text.Contains("@"))
            {
                customers = db.GetCustomers(txtUsername.Text);
                try
                {
                    inputUser = customers[0];
                    if (inputUser.Password.Equals(txtPassword.Text))
                    {
                        MessageBox.Show($"Customer Log In Successful");

                    }
                    else 
                    {
                        MessageBox.Show($"Invalid username or password");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid user name or password");
                }
            }
            else if(txtUsername.Text.Contains("A") && !txtUsername.Text.Contains("@"))
            {
                employees = db.GetEmployees(txtUsername.Text);
                try
                {
                    inputID = employees[0];
                    if (inputID.Password.Equals(txtPassword.Text))
                    {
                        MessageBox.Show("Employee Log In Successful");
                    }
                    else 
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid username or password");
                }
            }

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
