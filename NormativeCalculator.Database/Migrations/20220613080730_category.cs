using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "measureType",
                table: "RecipeIngredients",
                newName: "MeasureType");

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 7, 29, 677, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), "Cake" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), "Lava cake" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), "Muffin" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), "Carrot cake" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new byte[] { 187, 242, 146, 121, 215, 22, 101, 214, 42, 28, 146, 4, 155, 216, 245, 20, 175, 63, 251, 27, 48, 87, 112, 86, 173, 29, 178, 39, 176, 200, 124, 131, 214, 73, 235, 137, 62, 152, 136, 10, 230, 42, 221, 23, 61, 9, 167, 1, 196, 142, 153, 160, 139, 107, 121, 92, 221, 153, 146, 54, 48, 110, 66, 203 }, new byte[] { 70, 46, 178, 163, 157, 222, 195, 138, 64, 190, 30, 232, 237, 118, 107, 39, 197, 137, 117, 187, 184, 166, 98, 132, 188, 231, 145, 187, 101, 49, 140, 53, 103, 72, 66, 120, 25, 119, 206, 212, 23, 125, 237, 116, 222, 95, 177, 25, 184, 134, 14, 35, 98, 20, 102, 218, 190, 112, 187, 199, 68, 183, 159, 38, 129, 230, 53, 199, 13, 214, 82, 197, 36, 212, 85, 94, 34, 211, 165, 154, 169, 124, 218, 216, 175, 255, 65, 218, 160, 229, 22, 110, 14, 18, 232, 4, 75, 242, 51, 131, 7, 147, 223, 21, 235, 170, 35, 179, 225, 59, 26, 222, 188, 145, 144, 4, 107, 109, 49, 149, 75, 3, 253, 52, 174, 127, 39, 50 }, "sanjin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, "Merisa", "Mulac", new byte[] { 211, 40, 178, 253, 96, 161, 93, 127, 76, 170, 239, 169, 243, 117, 74, 170, 73, 18, 40, 114, 242, 252, 35, 151, 162, 131, 92, 100, 254, 244, 245, 6, 168, 106, 105, 50, 66, 192, 124, 8, 233, 172, 91, 169, 151, 111, 68, 247, 41, 244, 125, 18, 53, 47, 122, 76, 64, 148, 176, 13, 25, 101, 19, 180 }, new byte[] { 70, 46, 178, 163, 157, 222, 195, 138, 64, 190, 30, 232, 237, 118, 107, 39, 197, 137, 117, 187, 184, 166, 98, 132, 188, 231, 145, 187, 101, 49, 140, 53, 103, 72, 66, 120, 25, 119, 206, 212, 23, 125, 237, 116, 222, 95, 177, 25, 184, 134, 14, 35, 98, 20, 102, 218, 190, 112, 187, 199, 68, 183, 159, 38, 129, 230, 53, 199, 13, 214, 82, 197, 36, 212, 85, 94, 34, 211, 165, 154, 169, 124, 218, 216, 175, 255, 65, 218, 160, 229, 22, 110, 14, 18, 232, 4, 75, 242, 51, 131, 7, 147, 223, 21, 235, 170, 35, 179, 225, 59, 26, 222, 188, 145, 144, 4, 107, 109, 49, 149, 75, 3, 253, 52, 174, 127, 39, 50 }, "merisa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "MeasureType",
                table: "RecipeIngredients",
                newName: "measureType");

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 10, 11, 32, 41, 942, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new byte[] { 41, 3, 182, 225, 220, 27, 73, 62, 106, 133, 92, 26, 213, 179, 208, 127, 21, 160, 102, 87, 55, 166, 72, 54, 13, 59, 114, 178, 231, 170, 23, 174, 202, 30, 66, 236, 190, 158, 141, 8, 122, 94, 120, 27, 165, 179, 231, 219, 249, 17, 171, 219, 205, 52, 40, 98, 206, 248, 152, 47, 53, 200, 248, 68 }, new byte[] { 131, 236, 202, 63, 242, 43, 121, 48, 96, 250, 199, 39, 122, 219, 112, 47, 153, 213, 221, 167, 224, 228, 93, 89, 167, 64, 103, 229, 111, 24, 42, 143, 192, 120, 184, 133, 230, 242, 150, 125, 200, 244, 4, 250, 120, 105, 106, 17, 45, 68, 25, 191, 103, 203, 156, 138, 31, 176, 85, 177, 45, 177, 60, 115, 117, 157, 116, 6, 252, 39, 213, 90, 171, 155, 16, 17, 129, 245, 60, 191, 254, 213, 56, 105, 130, 137, 190, 64, 19, 118, 138, 230, 211, 137, 126, 67, 140, 91, 129, 174, 49, 29, 16, 91, 82, 35, 173, 221, 56, 208, 0, 93, 28, 225, 125, 116, 44, 105, 113, 82, 44, 10, 13, 157, 214, 38, 96, 180 }, "Sanjin" });
        }
    }
}
