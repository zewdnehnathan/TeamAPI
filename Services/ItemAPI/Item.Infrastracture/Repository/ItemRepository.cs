using Item.Domain.Interfaces.Repository;
using Item.Infrastracture.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastracture.Repository
{
    public class ItemRepository : AsyncRepository<Domain.Model.Item>, Item.Domain.Interfaces.Repository.IItemRepository
    {
        public ItemRepository(ItemContext orderContext):base(orderContext)
        {

        }
        
        public async Task<List<Domain.Model.Item>> GetByUser(string user)
        {
            var ItemList = (await GetAsync(x => x.Name == user)).ToList();
            return ItemList;
        }
    }
}
