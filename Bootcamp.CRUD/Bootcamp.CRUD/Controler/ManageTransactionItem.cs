using Bootcamp.CRUD.Context;
using Bootcamp.CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD.Controler
{
    public class ManageTransactionItem
    {
        public void MenuTransactionItem()
        {

            //var result = 0;

            TransactionItem transactionitems = new TransactionItem();
            MyContext _context = new MyContext();
            Console.WriteLine("=============== Transaction Item Data ================");
            //Console.WriteLine("1. Insert");
            int? transactionId = Convert.ToInt16(Console.ReadLine());
            if (transactionId == null)
            {
                Console.Write("Please Insert Transaction Id");
                Console.Read();
            }
            else
            {
                var getTransaction = _context.Transactions.Find(transactionId);
                if (getTransaction == null)
                {
                    Console.Write("We don't find id : " + transactionId);
                    Console.Read();
                }
                else
                {
                    transactionitems.Transactions = getTransaction;

                    // _context.Transactions.Add(transactionitems);
                }
            }
        }
    }
}


//_context.Transactions



