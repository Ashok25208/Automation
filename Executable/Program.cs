using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginTestModule;
using OrdersPageObjects;

namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginTest Exe = new LoginTest();
            OrdersPage Op = new OrdersPage();
            Exe.Login();
            Op.CatalogOrderAddToCart();

        }
    }
}
