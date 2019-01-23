using Bootcamp.CRUD.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD.Model
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }

        public DateTimeOffset JoinDate { get; set; }
    }
}
