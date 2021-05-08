using MBSWPF.ViewModels;
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
using System.Windows.Shapes;
using MBSLibrary;

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public static ShellView mainShellView;
        public ShellView()
        {
            InitializeComponent();
            mainShellView = this; //mainShellView will refer to this window.
            ManagementOptions.Visibility = Visibility.Hidden; //Hide Manager Options.

            //authenticator.Register("A0001", "bdalton21", "Brandon", "Dalton", false);
            //authenticator.Register("A0002", "smccartney21", "Silvia", "McCartney", true);
            //authenticator.Register("A0003", "sapulu21", "Sene", "Apulu", true);
            //authenticator.Register("A0004", "wmerritt21", "William", "Merritt", false);

            //For this we can either do a .Visibility or .IsEnabled depends on the look.
            //Should possibly consult Norris on the look Maybe.
            //if (ActiveAccount.activeEmployee.IsManager == true)
            //{
            //    LoadManagerView.Visibility = Visibility.Visible;

            //}
            //else 
            //{
            //    LoadManagerView.Visibility = Visibility.Hidden;
            //}

        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoadHomeView_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ShowOptions()
        {
            ManagementOptions.Visibility = Visibility.Visible;
        }
    }
}
