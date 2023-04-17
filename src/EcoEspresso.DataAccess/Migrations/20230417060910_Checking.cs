using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEspresso.DataAccess.Migrations
{
    public partial class Checking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Chefs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 6, 9, 10, 379, DateTimeKind.Utc).AddTicks(494));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 17, 5, 51, 54, 358, DateTimeKind.Utc).AddTicks(9550));
        }
    }
}
