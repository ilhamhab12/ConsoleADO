using Bootcamp.CRUD.Controler;
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
            Console.WriteLine("3. Manage Transaction");
            Console.WriteLine("4. Struck Transaction");
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
                case 3:
                    ManageTransaction transaction = new ManageTransaction();
                    transaction.MenuTransaction();
                    break;
                case 4:
                    Console.WriteLine("Insert Id Transaction");
                    Console.Read();

                    //ManageTransactionItem transactionitem = new ManageTransactionItem();
                    //transactionitem.MenuTransactionItem();
                    break;
                default:
                    Console.Write("Please Try Again");
                    Console.Read();
                    break;
            }
        }
    }
}
