using EcoEspresso.Service.Interfaces;
using EcoEspresso.Service.Services;
using System.Runtime.CompilerServices;

namespace EcoEspresso.Web.Extensions
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMealService, MealService>();
        }
    }
}
