using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class dataseedrecipecategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 1, new DateTime(2022, 6, 9, 19, 23, 9, 112, DateTimeKind.Local).AddTicks(3968), "Pancakes" });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022), "Waffles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 142, 112, 250, 177, 92, 202, 233, 252, 92, 120, 11, 200, 206, 0, 41, 68, 250, 212, 36, 195, 71, 88, 40, 15, 194, 83, 195, 138, 161, 205, 2, 243, 200, 60, 172, 246, 36, 119, 76, 115, 209, 99, 226, 228, 191, 139, 20, 9, 199, 52, 20, 6, 197, 112, 240, 179, 145, 125, 215, 203, 65, 149, 232 }, new byte[] { 111, 35, 41, 191, 109, 181, 162, 82, 59, 105, 205, 5, 76, 174, 126, 166, 44, 133, 32, 236, 47, 24, 202, 161, 25, 92, 132, 116, 144, 33, 32, 212, 45, 74, 157, 115, 204, 113, 193, 61, 236, 41, 20, 21, 218, 2, 195, 111, 157, 84, 252, 40, 119, 13, 38, 25, 46, 185, 8, 79, 13, 122, 119, 148, 232, 146, 92, 128, 1, 133, 28, 89, 110, 55, 69, 230, 177, 95, 92, 29, 227, 43, 124, 92, 16, 120, 50, 169, 181, 84, 24, 89, 73, 79, 114, 50, 48, 173, 158, 2, 210, 150, 99, 30, 49, 246, 138, 148, 20, 17, 178, 104, 245, 161, 84, 184, 26, 51, 17, 90, 72, 205, 111, 114, 81, 245, 124, 174 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 221, 42, 51, 129, 106, 90, 220, 43, 24, 183, 249, 161, 176, 159, 47, 241, 128, 215, 106, 135, 164, 149, 137, 10, 90, 236, 249, 47, 147, 91, 61, 169, 23, 4, 254, 145, 33, 154, 222, 68, 141, 62, 49, 115, 125, 146, 174, 136, 162, 65, 12, 105, 184, 152, 14, 185, 64, 168, 41, 27, 195, 61, 95 }, new byte[] { 169, 33, 241, 124, 97, 32, 178, 40, 126, 63, 167, 78, 29, 134, 174, 97, 18, 210, 175, 110, 222, 17, 177, 244, 12, 179, 113, 163, 116, 229, 116, 129, 55, 82, 54, 131, 248, 97, 207, 247, 229, 29, 216, 134, 212, 159, 232, 55, 147, 46, 139, 107, 242, 183, 147, 61, 73, 106, 174, 175, 107, 10, 43, 0, 230, 70, 246, 77, 60, 108, 147, 117, 175, 87, 220, 49, 173, 136, 251, 123, 150, 242, 188, 89, 60, 71, 112, 11, 231, 221, 242, 82, 167, 24, 111, 220, 71, 19, 163, 139, 32, 92, 247, 250, 127, 85, 82, 240, 16, 96, 83, 182, 159, 209, 188, 113, 49, 214, 99, 114, 11, 40, 234, 26, 129, 145, 22, 244 } });
        }
    }
}
