using MBSLibrary;
using System;
using System.Collections.Generic;
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

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        Authenticator authenticator = new Authenticator();
        ShellView main = ShellView.mainShellView;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string employeeId = txtUsername.Text;
            string password = txtPassword.Password;
            try
            {
                 //main will refer to the mainWindow
                Employee thisEmployee = authenticator.Login(employeeId, password);
                ActiveAccount.activeEmployee = thisEmployee;
                MessageBox.Show($"Welcome, {thisEmployee.FirstName}");
                txtUsername.Text = txtPassword.Password = ""; //Clear textboxes.
                if (ActiveAccount.activeEmployee.IsManager)
                {
                    main.ShowOptions();
                    main.Title = $"Logged in as: {ActiveAccount.activeEmployee.FirstName}";
                }
            }
            catch
            {
                MessageBox.Show("Login Unsuccessful.");
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            ActiveAccount.activeEmployee = null;
            if (ActiveAccount.activeEmployee == null)
            {
                main.HideOptions();
                main.Title = "MBS";
                MessageBox.Show("Logged Out");
            }
        }
    }
}
