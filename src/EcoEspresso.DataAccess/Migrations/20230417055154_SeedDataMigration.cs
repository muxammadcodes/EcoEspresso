using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEspresso.DataAccess.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "ChefId", "Count", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 10, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9540), "Plov", 8.99m, null },
                    { 2, 2, 5, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9542), "Lagman", 12.99m, null },
                    { 3, 3, 8, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9543), "Manti", 9.99m, null },
                    { 4, 4, 12, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9544), "Shashlik", 15.99m, null },
                    { 5, 5, 7, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9545), "Chuchvara", 7.99m, null },
                    { 6, 1, 15, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9547), "Samsa", 6.99m, null },
                    { 7, 2, 20, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9547), "Lavash", 4.99m, null },
                    { 8, 3, 25, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9548), "Non", 3.99m, null },
                    { 9, 4, 6, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9549), "Shorva", 10.99m, null },
                    { 10, 5, 3, new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9550), "Beshbarmak", 18.99m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 47, 32, 489, DateTimeKind.Utc).AddTicks(7250));
        }
    }
}
