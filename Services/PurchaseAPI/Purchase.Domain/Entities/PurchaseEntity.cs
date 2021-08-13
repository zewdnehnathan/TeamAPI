using Purchase.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.Domain.Entities
{
    public class PurchaseEntity : BaseEntity<Purchase.Domain.Model.Purchase>
    {
        public decimal TotalSls { get; protected set; }

        public string Supplier { get; protected set; }

        public PurchaseEntity()
        {

        }
        public void setTotalSls(decimal totalsls)
        {
            TotalSls = totalsls;
        }

    }
}
