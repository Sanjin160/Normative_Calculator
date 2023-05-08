using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Price", "Quantity", "measureType" },
                values: new object[,]
                {
                    { 1, "Suger", 2m, 100, 3 },
                    { 2, "Flour", 6m, 100, 5 },
                    { 3, "egg", 2m, 2, 1 },
                    { 4, "Brown suger", 2m, 200, 3 },
                    { 5, "Milk", 1m, 200, 5 },
                    { 6, "Water", 2m, 1, 5 },
                    { 7, "Buter", 4m, 350, 3 },
                    { 8, "Walnut", 10m, 2, 2 },
                    { 9, "Banana", 3m, 5, 1 },
                    { 10, "Salt", 1m, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, "Sanjin", "Sabanovic", new byte[] { 33, 221, 42, 51, 129, 106, 90, 220, 43, 24, 183, 249, 161, 176, 159, 47, 241, 128, 215, 106, 135, 164, 149, 137, 10, 90, 236, 249, 47, 147, 91, 61, 169, 23, 4, 254, 145, 33, 154, 222, 68, 141, 62, 49, 115, 125, 146, 174, 136, 162, 65, 12, 105, 184, 152, 14, 185, 64, 168, 41, 27, 195, 61, 95 }, new byte[] { 169, 33, 241, 124, 97, 32, 178, 40, 126, 63, 167, 78, 29, 134, 174, 97, 18, 210, 175, 110, 222, 17, 177, 244, 12, 179, 113, 163, 116, 229, 116, 129, 55, 82, 54, 131, 248, 97, 207, 247, 229, 29, 216, 134, 212, 159, 232, 55, 147, 46, 139, 107, 242, 183, 147, 61, 73, 106, 174, 175, 107, 10, 43, 0, 230, 70, 246, 77, 60, 108, 147, 117, 175, 87, 220, 49, 173, 136, 251, 123, 150, 242, 188, 89, 60, 71, 112, 11, 231, 221, 242, 82, 167, 24, 111, 220, 71, 19, 163, 139, 32, 92, 247, 250, 127, 85, 82, 240, 16, 96, 83, 182, 159, 209, 188, 113, 49, 214, 99, 114, 11, 40, 234, 26, 129, 145, 22, 244 }, "Sanjin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
