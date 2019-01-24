using Bootcamp.CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD
{
    public class Menu
    {
        public void Section()
        {
            Console.WriteLine("============ Manage Table =============");
            Console.WriteLine("1. Manage Supplier");
            Console.WriteLine("2. Manage Item");
            Console.WriteLine("=======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=======================================");
            switch (chance)
            {
                case 1:
                    ManageSupplier supplier = new ManageSupplier();
                    supplier.MenuSupplier();  
                    break;
                case 2:
                    ManageItem item = new ManageItem();
                    item.MenuItem();
                    break;
                default:
                    Console.Write("Please Try Again");
                    Console.Read();
                    break;
            }
        }
    }
}
