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
using System.Windows.Threading;

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();

            txtEmployeeID.Text = ActiveAccount.activeEmployee.EmployeeID;
            txtFirstName.Text = ActiveAccount.activeEmployee.FirstName;
            txtLastName.Text = ActiveAccount.activeEmployee.LastName;

            //txtUserName.Text = ActiveAccount.activeEmployee.FirstName;

            Loaded += AccountView_Loaded;

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
               DispatcherPriority.Normal, delegate
               {
                   lblTime.Content = DateTime.Now.ToString("hh:mm:ss");
               }, this.Dispatcher);
        }

        private void AccountView_Loaded(object sender, RoutedEventArgs e)
        {
            lblDate.Content = DateTime.Now.ToShortDateString();
        }
    }
}
