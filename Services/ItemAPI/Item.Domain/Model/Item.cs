using Item.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Model
{
    public class Item : BaseAuditModel
    { 
        public string Name { get; protected set; }
        public string Category { get; protected set; } 
        public decimal Qty { get; protected set; }
        public decimal UnitPrice { get; protected set; }

        public Item()
        {

        }
        public Item(string Name,string category,decimal Qty,decimal UnitPrice)
        {
            this.Name = Name;
            this.Category = category;
            this.Qty = Qty;
            this.UnitPrice = UnitPrice;
        }


    }
}
