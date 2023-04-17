using EcoEspresso.DataAccess.Context;
using EcoEspresso.DataAccess.IRepositories;
using EcoEspresso.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EcoEspresso.DataAccess.Repositories
{
    public class Repository<TSource> : IRepository<TSource> where TSource : Auditable
    {
        private readonly AppDbContext dbContext;
        private readonly DbSet<TSource> dbSet;
        public Repository(AppDbContext dbContext,DbSet<TSource> dbSet)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TSource>();
        }
        public async ValueTask<bool> DeleteAsync(Expression<Func<TSource, bool>> expression)
        {
            var entity = await this.dbSet.FirstOrDefaultAsync(expression);
            if (entity == null)
                return false;

            this.dbSet.Remove(entity);
            return true;  
        }
        public IQueryable<TSource> GetAllAsync() =>
            this.dbSet;
        public async ValueTask<TSource> GetAsync(Expression<Func<TSource, bool>> expression)
            => await this.dbSet.FirstOrDefaultAsync(expression);
      public async ValueTask<TSource> InsertAsync(TSource source)
        {
            var entity = await this.dbSet.AddAsync(source);
            return entity.Entity;
        }
        public async ValueTask SaveAsync()
        {
            await this.dbContext.SaveChangesAsync();
        }
        public async ValueTask<TSource> UpdateAsync(TSource source)
        {
            var updated = this.dbSet.Update(source);
            return updated.Entity;
        }
    }
}
