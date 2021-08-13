using Item.Infrastracture.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastracture.Seeds
{
    public class ItemContextSeed
    {

        public static async Task SeedAsync(ItemContext orderContext, ILogger<ItemContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(ItemContext).Name);
            }
        }
        private static IEnumerable<Item.Domain.Model.Item> GetPreconfiguredOrders()
        {
            return new List<Item.Domain.Model.Item>
            {
                new Item.Domain.Model.Item("IPhone","Smart Phone",5,21),
                new Item.Domain.Model.Item("samsumg","Smart Phone",3,17)

            };
        }

    }
}
