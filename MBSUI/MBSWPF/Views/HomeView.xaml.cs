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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        DataAccess db = new DataAccess();
        public HomeView()
        {
            InitializeComponent();            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchContent = txtSearchBar.Text;
            
            int sku = 0;
            bool canConvert = int.TryParse(searchContent, out sku);
            

            if(canConvert==true)
            {
                
                ActiveAccount.searchResults = db.GetProductBySKU(sku);
            }
            else
            {
                
                ActiveAccount.searchResults = db.GetProductByName(searchContent);
                

                if (ActiveAccount.searchResults.Count == 0)
                {
                    
                    ActiveAccount.searchResults = db.GetProductByGenre(searchContent);

                    
                    
                    if (ActiveAccount.searchResults.Count == 0)
                    {
                        MessageBox.Show("Nothing to return");
                    }
                }
                
                
            }

        }
    }
}
