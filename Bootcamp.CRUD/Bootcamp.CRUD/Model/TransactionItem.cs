using Bootcamp.CRUD.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD.Model
{
    public class TransactionItem : BaseModel
    {
        public Item Items { get; set; }
        public Transaction Transactions { get; set; }
        public int Quantity { get; set; }
    }
}
