using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEspresso.DataAccess.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Salary", "Salt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7242), "azizkarimov@example.com", "Aziz", "Karimov", "password1", 5000.00m, "salt1", null },
                    { 2, new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7246), "shahzodaabdullaeva@example.com", "Shahzoda", "Abdullaeva", "password2", 6000.00m, "salt2", null },
                    { 3, new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7247), "jamshidxolmatov@example.com", "Jamshid", "Xolmatov", "password3", 7000.00m, "salt3", null },
                    { 4, new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7249), "nargizasaidova@example.com", "Nargiza", "Saidova", "password4", 5500.00m, "salt4", null },
                    { 5, new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7250), "dilshodrahmonov@example.com", "Dilshod", "Rahmonov", "password5", 8000.00m, "salt5", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Chefs",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Salary", "Salt", "UpdatedAt" },
                values: new object[,]
                {
                    { -5, new DateTime(2023, 4, 17, 5, 45, 47, 846, DateTimeKind.Utc).AddTicks(1510), "dilshodrahmonov@example.com", "Dilshod", "Rahmonov", "password5", 8000.00m, "salt5", null },
                    { -4, new DateTime(2023, 4, 17, 5, 45, 47, 846, DateTimeKind.Utc).AddTicks(1509), "nargizasaidova@example.com", "Nargiza", "Saidova", "password4", 5500.00m, "salt4", null },
                    { -3, new DateTime(2023, 4, 17, 5, 45, 47, 846, DateTimeKind.Utc).AddTicks(1507), "jamshidxolmatov@example.com", "Jamshid", "Xolmatov", "password3", 7000.00m, "salt3", null },
                    { -2, new DateTime(2023, 4, 17, 5, 45, 47, 846, DateTimeKind.Utc).AddTicks(1506), "shahzodaabdullaeva@example.com", "Shahzoda", "Abdullaeva", "password2", 6000.00m, "salt2", null },
                    { -1, new DateTime(2023, 4, 17, 5, 45, 47, 846, DateTimeKind.Utc).AddTicks(1502), "azizkarimov@example.com", "Aziz", "Karimov", "password1", 5000.00m, "salt1", null }
                });
        }
    }
}
