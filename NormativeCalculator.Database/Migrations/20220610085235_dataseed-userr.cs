using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class dataseeduserr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 10, 10, 52, 34, 487, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 35, 83, 8, 237, 156, 72, 123, 24, 62, 128, 230, 97, 134, 232, 32, 8, 31, 237, 33, 105, 201, 249, 200, 173, 3, 110, 192, 55, 39, 106, 189, 145, 161, 206, 123, 132, 197, 102, 178, 164, 12, 4, 191, 141, 15, 40, 82, 7, 44, 225, 198, 255, 250, 161, 21, 71, 165, 226, 203, 223, 79, 16, 75, 172 }, new byte[] { 21, 30, 33, 175, 232, 43, 142, 162, 194, 227, 133, 225, 180, 199, 251, 126, 241, 69, 169, 185, 211, 83, 80, 116, 150, 98, 126, 192, 148, 184, 61, 27, 255, 150, 194, 23, 151, 103, 125, 54, 190, 123, 151, 164, 138, 62, 163, 209, 94, 45, 236, 166, 42, 72, 135, 234, 253, 7, 137, 154, 157, 118, 218, 54, 92, 74, 97, 128, 233, 233, 120, 80, 28, 43, 189, 240, 60, 54, 27, 14, 187, 193, 196, 255, 206, 133, 190, 188, 177, 3, 156, 225, 123, 74, 227, 10, 154, 87, 234, 96, 31, 229, 182, 207, 152, 96, 208, 78, 221, 184, 230, 177, 74, 244, 124, 92, 253, 114, 40, 254, 225, 190, 116, 191, 20, 69, 71, 132 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
