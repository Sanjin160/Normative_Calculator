using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class measue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.RenameColumn(
                name: "RecipeCategoryId",
                table: "Recipe",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_RecipeCategoryId",
                table: "Recipe",
                newName: "IX_Recipe_CategoryId");

            migrationBuilder.RenameColumn(
                name: "measureType",
                table: "Ingredients",
                newName: "MeasureType");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 30, 3, 216, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 101, 6, 37, 54, 230, 249, 144, 10, 110, 71, 47, 68, 47, 59, 42, 70, 33, 78, 105, 203, 127, 32, 68, 75, 125, 78, 184, 67, 143, 16, 195, 208, 246, 47, 88, 190, 12, 222, 92, 151, 113, 36, 34, 58, 101, 94, 248, 240, 30, 254, 136, 218, 76, 197, 136, 231, 72, 173, 20, 172, 108, 165, 115, 189 }, new byte[] { 8, 27, 76, 217, 129, 191, 112, 42, 55, 225, 22, 102, 120, 176, 225, 207, 139, 166, 140, 159, 79, 109, 226, 19, 172, 81, 253, 8, 196, 12, 95, 33, 229, 16, 47, 164, 197, 126, 87, 69, 251, 37, 107, 147, 251, 143, 209, 29, 82, 26, 45, 143, 165, 165, 42, 251, 228, 149, 112, 175, 181, 225, 153, 206, 119, 50, 178, 222, 149, 22, 2, 252, 156, 29, 75, 3, 246, 19, 35, 17, 213, 117, 34, 41, 127, 54, 4, 193, 188, 109, 179, 43, 123, 65, 14, 229, 220, 173, 88, 151, 178, 239, 116, 57, 28, 10, 68, 23, 220, 230, 153, 220, 121, 20, 145, 210, 205, 179, 228, 12, 189, 126, 66, 207, 125, 149, 70, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 46, 52, 150, 121, 122, 12, 216, 12, 38, 64, 16, 203, 142, 236, 143, 79, 200, 229, 65, 138, 114, 92, 13, 149, 234, 180, 145, 16, 65, 255, 81, 66, 210, 74, 183, 139, 26, 91, 20, 16, 231, 255, 232, 196, 98, 156, 14, 169, 131, 74, 130, 124, 31, 188, 180, 33, 222, 71, 158, 134, 130, 220, 126 }, new byte[] { 8, 27, 76, 217, 129, 191, 112, 42, 55, 225, 22, 102, 120, 176, 225, 207, 139, 166, 140, 159, 79, 109, 226, 19, 172, 81, 253, 8, 196, 12, 95, 33, 229, 16, 47, 164, 197, 126, 87, 69, 251, 37, 107, 147, 251, 143, 209, 29, 82, 26, 45, 143, 165, 165, 42, 251, 228, 149, 112, 175, 181, 225, 153, 206, 119, 50, 178, 222, 149, 22, 2, 252, 156, 29, 75, 3, 246, 19, 35, 17, 213, 117, 34, 41, 127, 54, 4, 193, 188, 109, 179, 43, 123, 65, 14, 229, 220, 173, 88, 151, 178, 239, 116, 57, 28, 10, 68, 23, 220, 230, 153, 220, 121, 20, 145, 210, 205, 179, 228, 12, 189, 126, 66, 207, 125, 149, 70, 53 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Recipe",
                newName: "RecipeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                newName: "IX_Recipe_RecipeCategoryId");

            migrationBuilder.RenameColumn(
                name: "MeasureType",
                table: "Ingredients",
                newName: "measureType");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 17, 0, 904, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 141, 171, 164, 157, 238, 190, 251, 68, 151, 0, 74, 75, 149, 155, 96, 115, 220, 222, 49, 223, 173, 90, 209, 75, 114, 229, 150, 229, 198, 110, 73, 188, 5, 181, 30, 254, 208, 83, 10, 181, 202, 113, 30, 65, 102, 109, 123, 170, 99, 23, 144, 195, 79, 243, 196, 204, 199, 100, 33, 236, 141, 255, 223 }, new byte[] { 167, 186, 212, 3, 235, 196, 71, 19, 233, 15, 189, 150, 29, 124, 108, 52, 241, 217, 71, 241, 254, 123, 119, 160, 86, 191, 83, 129, 75, 114, 236, 57, 147, 32, 39, 241, 108, 40, 58, 219, 133, 222, 234, 155, 219, 81, 5, 119, 15, 191, 125, 127, 239, 236, 181, 160, 95, 56, 253, 173, 3, 222, 223, 164, 5, 26, 89, 70, 170, 109, 118, 117, 7, 135, 4, 147, 77, 132, 134, 1, 39, 148, 101, 181, 4, 143, 18, 180, 24, 236, 2, 189, 162, 245, 73, 211, 23, 213, 236, 58, 148, 175, 66, 140, 160, 21, 19, 202, 105, 46, 97, 90, 240, 1, 213, 91, 26, 41, 159, 156, 163, 83, 201, 193, 202, 127, 219, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 127, 175, 53, 157, 2, 57, 181, 219, 109, 160, 81, 208, 97, 120, 0, 73, 210, 248, 118, 13, 55, 205, 89, 14, 101, 4, 252, 4, 30, 101, 211, 16, 143, 215, 13, 61, 92, 178, 248, 245, 153, 128, 92, 251, 134, 158, 105, 117, 43, 227, 242, 185, 95, 236, 147, 145, 133, 105, 76, 246, 219, 134, 90, 6 }, new byte[] { 167, 186, 212, 3, 235, 196, 71, 19, 233, 15, 189, 150, 29, 124, 108, 52, 241, 217, 71, 241, 254, 123, 119, 160, 86, 191, 83, 129, 75, 114, 236, 57, 147, 32, 39, 241, 108, 40, 58, 219, 133, 222, 234, 155, 219, 81, 5, 119, 15, 191, 125, 127, 239, 236, 181, 160, 95, 56, 253, 173, 3, 222, 223, 164, 5, 26, 89, 70, 170, 109, 118, 117, 7, 135, 4, 147, 77, 132, 134, 1, 39, 148, 101, 181, 4, 143, 18, 180, 24, 236, 2, 189, 162, 245, 73, 211, 23, 213, 236, 58, 148, 175, 66, 140, 160, 21, 19, 202, 105, 46, 97, 90, 240, 1, 213, 91, 26, 41, 159, 156, 163, 83, 201, 193, 202, 127, 219, 208 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
