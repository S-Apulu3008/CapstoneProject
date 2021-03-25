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

namespace LoginUI
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
                                                   //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dev\ProductSuggest\LoginForm\LoginDB.mdf;Integrated Security=True"
            SqlConnection sqlCnn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13; Integrated Security = True;");
            string query = "SELECT * FROM Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCnn);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            //TODO Clicking submit button causes error.
            //Comment

            MessageBox.Show(dataTable.Rows[0].ToString());
        }
    }
}
