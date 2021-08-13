using Item.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Entities
{
    public class ItemEntity : BaseEntity<Item.Domain.Model.Item>
    {
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public decimal Qty { get; protected set; }
        public decimal UnitPrice { get; protected set; }


        public ItemEntity(Model.Item x) 
        {
            this.Name = x.Name;
            this.Category = x.Category;
            this.Qty = Qty;
            this.UnitPrice = UnitPrice;
        }

        public void Add(string name)
        {
            Name = name;
        }

        public override Item.Domain.Model.Item MapToModel()
        {
            Item.Domain.Model.Item ItemModel = new Item.Domain.Model.Item(Name,Category,Qty,UnitPrice);
           
            return ItemModel;
        }

        public override Model.Item MapToModel(Model.Item t)
        {
            throw new NotImplementedException();
        }
    }
}
