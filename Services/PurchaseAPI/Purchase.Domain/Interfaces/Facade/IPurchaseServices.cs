using Purchase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.Domain.Interfaces.Facade
{
    public interface IPurchaseServices
    {
        Task<List<PurchaseEntity>> GetAllPrchases();
        Task<Guid> Add(PurchaseEntity Purchase);
        Task<List<PurchaseEntity>> GetByUser(string user);
        Task UpdatePurchase(PurchaseEntity Item);

    }
}
