using Purchase.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.Domain.Interfaces.Repository
{
    public interface IPurchaseRepository : IAsyncRepository <Purchase.Domain.Model.Purchase>
    {
        Task<List<Model.Purchase>> GetByUser(string user);

    }
}
