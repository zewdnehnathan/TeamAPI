
using Item.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Item.Infrastracture
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : BaseAuditModel
    {

        private readonly Item.Infrastracture.Context.ItemContext itemContext;
        public AsyncRepository(Item.Infrastracture.Context.ItemContext itemContext) 
        {
            this.itemContext = itemContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await itemContext.Set<T>().AddAsync(entity);
            await itemContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            itemContext.Set<T>().Remove(entity);
            await itemContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await itemContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await itemContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await itemContext.Set<T>().FindAsync(id);
        }

        public Task<IQueryable<T>> GetQueryAsync(Expression<Func<T, bool>> predicate)
        {
            return (Task<IQueryable<T>>)itemContext.Set<T>().Where(predicate);
        }

        public async Task UpdateAsync(T entity)
        {
            itemContext.Entry(entity).State = EntityState.Modified;
            await itemContext.SaveChangesAsync();
        }
    }
}
