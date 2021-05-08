using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class ActiveAccount 
    {
        public static Employee activeEmployee = new Employee();

        public static List<Product> searchResults = new List<Product>();

        public static List<Product> reportResults = new List<Product>();
    }
}
