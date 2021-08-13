using Item.Domain.Entities;
using Item.Domain.Model;
using Item.Domain.Interfaces.Facade;
using Item.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.Features
{
    public class ItemService : IItemService
    {

        private readonly IItemRepository itemRepository;

        public ItemService(IItemRepository itemRepository) 
        {
            this.itemRepository = itemRepository;
        }

        public async Task<Guid> Add(ItemEntity ItemE)
        {
           Item.Domain.Model.Item item = ItemE.MapToModel();
           await itemRepository.AddAsync(item);
           return item.Id;
        }

        public async Task<List<ItemEntity>> GetAllItems()
        {
            var data = await itemRepository.GetAllAsync();
            return data?.Select(x => new Domain.Entities.ItemEntity(x)).ToList();
        }

        public async Task<List<ItemEntity>> GetByUser(string user)
        {
            var data = itemRepository.GetAsync(x => x.Name == user);
            List<Domain.Entities.ItemEntity> items = (await data).Select(x => new Domain.Entities.ItemEntity(x)).ToList();
            return items;
        }

        public Task UpdateItem(ItemEntity Item)
        {
            throw new NotImplementedException();
        }
    }
}
