using EcoEspresso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.Buffers.Text;
using System.Security.AccessControl;

namespace EcoEspresso.DataAccess.Context;

public class AppDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server = (localdb)\\MSSQLLocalDB;Database=EcoEcpresso;Trusted_Connection=True;MultipleActiveResultSets=true";
        optionsBuilder.UseSqlServer(path);
    }

    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<FoodInfotmation> FoodInfotmations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure many-to-one relationship between Meal and Chef
        modelBuilder.Entity<Meal>()
            .HasOne(m => m.Chef)
            .WithMany(c => c.Meals)
            .HasForeignKey(m => m.ChefId);

        // Configure many-to-one relationship between Meal and FoodInfotmation
        modelBuilder.Entity<Meal>()
            .HasOne(m => m.FoodInfotmation)
            .WithMany(fi => fi.Meals)
            .HasForeignKey(m => m.FoodInformationId);

        // Configure one-to-one relationship between Meal and FoodInfotmation (ThisFoodInfotmation)
        modelBuilder.Entity<Meal>()
            .HasOne(m => m.ThisFoodInfotmation)
            .WithOne()
            .HasForeignKey<Meal>(m => m.FoodInformationId)
            .OnDelete(DeleteBehavior.Restrict); // Specify DeleteBehavior.Restrict

        // Configure one-to-many relationship between Chef and Meal
        modelBuilder.Entity<Chef>()
            .HasMany(c => c.Meals)
            .WithOne(m => m.Chef)
            .HasForeignKey(m => m.ChefId);

        // Configure one-to-many relationship between FoodInfotmation and Meal
        modelBuilder.Entity<FoodInfotmation>()
            .HasMany(fi => fi.Meals)
            .WithOne(m => m.FoodInfotmation)
            .HasForeignKey(m => m.FoodInformationId);
    }





}








