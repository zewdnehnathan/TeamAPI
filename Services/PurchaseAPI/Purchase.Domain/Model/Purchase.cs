using Purchase.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.Domain.Model
{
    public class Purchase : BaseAuditModel
    {

        public decimal TotalSls { get; protected set; }

        public string Supplier { get; protected set; }

        public Purchase() 
        {

        }
      

    }
}
