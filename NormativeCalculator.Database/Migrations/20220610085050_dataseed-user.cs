using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class dataseeduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 10, 10, 50, 49, 982, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 189, 214, 152, 200, 76, 171, 234, 34, 2, 146, 165, 171, 0, 28, 68, 63, 20, 254, 159, 80, 5, 235, 185, 218, 141, 63, 39, 168, 85, 136, 211, 48, 224, 50, 74, 104, 50, 26, 250, 231, 207, 137, 251, 205, 246, 38, 131, 63, 29, 106, 72, 53, 35, 194, 68, 255, 191, 56, 44, 186, 36, 55, 217 }, new byte[] { 236, 170, 244, 24, 178, 186, 116, 8, 119, 75, 215, 226, 89, 39, 82, 82, 141, 129, 90, 87, 10, 97, 74, 104, 27, 23, 118, 32, 45, 229, 246, 181, 91, 199, 242, 131, 30, 44, 127, 245, 99, 119, 166, 253, 91, 105, 92, 54, 226, 110, 27, 44, 130, 79, 154, 8, 72, 217, 161, 7, 72, 245, 199, 185, 186, 216, 83, 112, 206, 218, 22, 75, 171, 231, 8, 205, 153, 160, 14, 32, 239, 250, 162, 253, 116, 228, 159, 19, 194, 88, 171, 168, 216, 87, 193, 112, 251, 238, 75, 77, 111, 249, 130, 98, 208, 60, 220, 211, 86, 42, 164, 234, 73, 204, 29, 183, 79, 234, 243, 166, 225, 169, 240, 139, 241, 3, 248, 213 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 9, 19, 23, 9, 112, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 142, 112, 250, 177, 92, 202, 233, 252, 92, 120, 11, 200, 206, 0, 41, 68, 250, 212, 36, 195, 71, 88, 40, 15, 194, 83, 195, 138, 161, 205, 2, 243, 200, 60, 172, 246, 36, 119, 76, 115, 209, 99, 226, 228, 191, 139, 20, 9, 199, 52, 20, 6, 197, 112, 240, 179, 145, 125, 215, 203, 65, 149, 232 }, new byte[] { 111, 35, 41, 191, 109, 181, 162, 82, 59, 105, 205, 5, 76, 174, 126, 166, 44, 133, 32, 236, 47, 24, 202, 161, 25, 92, 132, 116, 144, 33, 32, 212, 45, 74, 157, 115, 204, 113, 193, 61, 236, 41, 20, 21, 218, 2, 195, 111, 157, 84, 252, 40, 119, 13, 38, 25, 46, 185, 8, 79, 13, 122, 119, 148, 232, 146, 92, 128, 1, 133, 28, 89, 110, 55, 69, 230, 177, 95, 92, 29, 227, 43, 124, 92, 16, 120, 50, 169, 181, 84, 24, 89, 73, 79, 114, 50, 48, 173, 158, 2, 210, 150, 99, 30, 49, 246, 138, 148, 20, 17, 178, 104, 245, 161, 84, 184, 26, 51, 17, 90, 72, 205, 111, 114, 81, 245, 124, 174 } });
        }
    }
}
