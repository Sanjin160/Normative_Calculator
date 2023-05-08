using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class hash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 3, 182, 225, 220, 27, 73, 62, 106, 133, 92, 26, 213, 179, 208, 127, 21, 160, 102, 87, 55, 166, 72, 54, 13, 59, 114, 178, 231, 170, 23, 174, 202, 30, 66, 236, 190, 158, 141, 8, 122, 94, 120, 27, 165, 179, 231, 219, 249, 17, 171, 219, 205, 52, 40, 98, 206, 248, 152, 47, 53, 200, 248, 68 }, new byte[] { 131, 236, 202, 63, 242, 43, 121, 48, 96, 250, 199, 39, 122, 219, 112, 47, 153, 213, 221, 167, 224, 228, 93, 89, 167, 64, 103, 229, 111, 24, 42, 143, 192, 120, 184, 133, 230, 242, 150, 125, 200, 244, 4, 250, 120, 105, 106, 17, 45, 68, 25, 191, 103, 203, 156, 138, 31, 176, 85, 177, 45, 177, 60, 115, 117, 157, 116, 6, 252, 39, 213, 90, 171, 155, 16, 17, 129, 245, 60, 191, 254, 213, 56, 105, 130, 137, 190, 64, 19, 118, 138, 230, 211, 137, 126, 67, 140, 91, 129, 174, 49, 29, 16, 91, 82, 35, 173, 221, 56, 208, 0, 93, 28, 225, 125, 116, 44, 105, 113, 82, 44, 10, 13, 157, 214, 38, 96, 180 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
