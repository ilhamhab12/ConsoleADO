using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD.Core
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }

        public bool IsDelete { get; set; }
        //public DateTimeOffset TransactionDate { get; set; }
    }
}
