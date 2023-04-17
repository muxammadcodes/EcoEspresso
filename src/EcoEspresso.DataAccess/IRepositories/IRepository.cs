using EcoEspresso.Domain.Commons;
using System.Linq.Expressions;

namespace EcoEspresso.DataAccess.IRepositories
{
    public interface IRepository<TSource> where TSource : Auditable
    {
        ValueTask<TSource> InsertAsync(TSource source);
        ValueTask<TSource> UpdateAsync(TSource source);
        ValueTask<bool> DeleteAsync(Expression<Func<TSource,bool>> expression);
        ValueTask<TSource> GetAsync(Expression<Func<TSource,bool>> expression);
        IQueryable<TSource> GetAllAsync();
        ValueTask SaveAsync();
    }
}
