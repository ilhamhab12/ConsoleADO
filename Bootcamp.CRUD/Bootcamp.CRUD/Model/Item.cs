using Bootcamp.CRUD.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD.Model
{
    public class Item : BaseModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stok { get; set; }

        public Supplier Supplier { get; set; }
    }
}
