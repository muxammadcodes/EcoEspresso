using EcoEspresso.DataAccess.IRepositories;
using EcoEspresso.DataAccess.Repositories;

namespace EcoEspresso.Web.Extensions
{
    public static class RepositoriesExtension
    {
        public static void AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        }
    }
}
