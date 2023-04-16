using EcoEspresso.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcoEspresso.DataAccess.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<MealInfo> mealInfos { get; set; }

}
