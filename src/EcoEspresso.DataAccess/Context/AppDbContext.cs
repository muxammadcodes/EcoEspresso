using EcoEspresso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.Buffers.Text;
using System.Security.AccessControl;

namespace EcoEspresso.DataAccess.Context;

public class AppDbContext : DbContext
{

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    string path = "Server = (localdb)\\MSSQLLocalDB;Database=EcoEcpresso;Trusted_Connection=True;MultipleActiveResultSets=true";
    //    optionsBuilder.UseSqlServer(path);
    //}
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<FoodInfotmation> FoodInfotmations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Meal>()
            .HasOne(m => m.Chef)
            .WithMany(c => c.Meals)
            .HasForeignKey(m => m.ChefId);

        modelBuilder.Entity<FoodInfotmation>()
            .HasOne(fm => fm.Meal)
            .WithMany()
            .HasForeignKey(fm => fm.MealId);

        modelBuilder.Entity<Chef>()
            .HasMany(ch => ch.Meals)
            .WithOne(m => m.Chef)
            .HasForeignKey(m => m.ChefId);

        List<Chef> chefs = new List<Chef>
        {
            new Chef {Id = 1, FirstName = "Aziz", LastName = "Karimov", Email = "azizkarimov@example.com", Salary = 5000.00m, PasswordHash = "password1", Salt = "salt1",CreatedAt=DateTime.UtcNow },
            new Chef {Id = 2, FirstName = "Shahzoda", LastName = "Abdullaeva", Email = "shahzodaabdullaeva@example.com", Salary = 6000.00m, PasswordHash = "password2", Salt = "salt2",CreatedAt=DateTime.UtcNow  },
            new Chef {Id = 3, FirstName = "Jamshid", LastName = "Xolmatov", Email = "jamshidxolmatov@example.com", Salary = 7000.00m, PasswordHash = "password3", Salt = "salt3",CreatedAt=DateTime.UtcNow  },
            new Chef {Id = 4, FirstName = "Nargiza", LastName = "Saidova", Email = "nargizasaidova@example.com", Salary = 5500.00m, PasswordHash = "password4", Salt = "salt4",CreatedAt=DateTime.UtcNow  },
            new Chef {Id = 5, FirstName = "Dilshod", LastName = "Rahmonov", Email = "dilshodrahmonov@example.com", Salary = 8000.00m, PasswordHash = "password5", Salt = "salt5",CreatedAt=DateTime.UtcNow  },
            // Add more chefs as needed
        };
        modelBuilder.Entity<Chef>().HasData(chefs);

        List<Meal> meals = new List<Meal>
        {
        new Meal { Id = 1, Name = "Plov", Count = 10, Price = 8.99m, ChefId = 1,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 2, Name = "Lagman", Count = 5, Price = 12.99m, ChefId = 2,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 3, Name = "Manti", Count = 8, Price = 9.99m, ChefId = 3,CreatedAt=DateTime.UtcNow    },
        new Meal { Id = 4, Name = "Shashlik", Count = 12, Price = 15.99m, ChefId = 4 , CreatedAt = DateTime.UtcNow},
        new Meal { Id = 5, Name = "Chuchvara", Count = 7, Price = 7.99m, ChefId = 5,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 6, Name = "Samsa", Count = 15, Price = 6.99m, ChefId = 1,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 7, Name = "Lavash", Count = 20, Price = 4.99m, ChefId = 2 , CreatedAt = DateTime.UtcNow},
        new Meal { Id = 8, Name = "Non", Count = 25, Price = 3.99m, ChefId = 3,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 9, Name = "Shorva", Count = 6, Price = 10.99m, ChefId = 4,CreatedAt=DateTime.UtcNow },
        new Meal { Id = 10, Name = "Beshbarmak", Count = 3, Price = 18.99m, ChefId = 5,CreatedAt=DateTime.UtcNow }
        };

        modelBuilder.Entity<Meal>().HasData(meals);

    }

}








