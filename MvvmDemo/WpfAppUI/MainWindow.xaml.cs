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
using WpfAppUI.ViewModels;

namespace WpfAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void viewOneClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new OneViewModel();
        }

        private void viewTwoClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new TwoViewModel();
        }
    }
}
