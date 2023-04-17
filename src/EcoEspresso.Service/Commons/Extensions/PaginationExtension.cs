using EcoEspresso.Domain.Configurations;
using EcoEspresso.Service.Commons.Exceptions;

namespace EcoEspresso.Service.Commons.Extensions
{
    public static class PaginationExtension
    {
        public static IQueryable<TSource> ToPageList<TSource>(this IQueryable<TSource> source, PaginationParams @params)
        {
            if (@params.PageIndex > 0 && @params.PageSize > 0)
            {
                var itemsForSkip = (@params.PageIndex - 1) * @params.PageSize;
                var totalCount = source.Count();

                if (itemsForSkip >= totalCount && totalCount > 0)
                    itemsForSkip = totalCount - totalCount % @params.PageSize;

                return source.Skip(itemsForSkip).Take(@params.PageSize);
            }
            throw new CustomException(400, "Enter the valid numbers");
        }
    }
}
