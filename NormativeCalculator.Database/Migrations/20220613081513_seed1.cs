using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_RecipeCategories_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeCategories",
                table: "RecipeCategories");

            migrationBuilder.RenameTable(
                name: "RecipeCategories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 15, 12, 767, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 172, 140, 34, 195, 175, 95, 43, 68, 52, 176, 69, 99, 245, 66, 68, 75, 65, 47, 190, 215, 253, 58, 62, 191, 192, 44, 1, 79, 73, 141, 119, 223, 142, 180, 113, 47, 49, 89, 46, 36, 145, 13, 0, 129, 23, 112, 71, 137, 50, 246, 142, 202, 184, 36, 186, 180, 15, 187, 17, 170, 61, 108, 179, 89 }, new byte[] { 32, 232, 11, 228, 177, 97, 67, 227, 57, 46, 41, 165, 153, 139, 75, 254, 74, 243, 193, 36, 88, 181, 83, 129, 232, 149, 99, 123, 174, 99, 209, 247, 9, 149, 244, 85, 93, 230, 246, 111, 182, 235, 140, 191, 75, 66, 49, 193, 56, 180, 245, 209, 26, 255, 130, 65, 78, 153, 25, 106, 203, 209, 60, 98, 204, 42, 163, 251, 209, 206, 247, 47, 209, 62, 145, 49, 243, 73, 207, 231, 24, 202, 53, 67, 230, 208, 173, 209, 141, 164, 10, 213, 66, 148, 225, 130, 50, 29, 11, 55, 114, 173, 156, 77, 137, 223, 195, 138, 166, 198, 69, 45, 193, 14, 216, 31, 113, 137, 125, 17, 156, 85, 50, 229, 202, 47, 247, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 211, 123, 237, 253, 120, 118, 104, 195, 130, 132, 240, 248, 154, 16, 254, 27, 103, 229, 211, 230, 18, 161, 124, 161, 104, 57, 61, 52, 165, 41, 76, 238, 104, 222, 140, 3, 32, 219, 218, 162, 38, 60, 79, 234, 24, 75, 147, 206, 97, 51, 249, 118, 25, 197, 216, 227, 225, 221, 17, 22, 0, 53, 85 }, new byte[] { 32, 232, 11, 228, 177, 97, 67, 227, 57, 46, 41, 165, 153, 139, 75, 254, 74, 243, 193, 36, 88, 181, 83, 129, 232, 149, 99, 123, 174, 99, 209, 247, 9, 149, 244, 85, 93, 230, 246, 111, 182, 235, 140, 191, 75, 66, 49, 193, 56, 180, 245, 209, 26, 255, 130, 65, 78, 153, 25, 106, 203, 209, 60, 98, 204, 42, 163, 251, 209, 206, 247, 47, 209, 62, 145, 49, 243, 73, 207, 231, 24, 202, 53, 67, 230, 208, 173, 209, 141, 164, 10, 213, 66, 148, 225, 130, 50, 29, 11, 55, 114, 173, 156, 77, 137, 223, 195, 138, 166, 198, 69, 45, 193, 14, 216, 31, 113, 137, 125, 17, 156, 85, 50, 229, 202, 47, 247, 164 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "RecipeCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeCategories",
                table: "RecipeCategories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 11, 10, 557, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 196, 239, 95, 101, 239, 118, 205, 236, 29, 247, 93, 84, 152, 20, 122, 248, 206, 197, 241, 170, 31, 22, 210, 158, 107, 254, 251, 197, 163, 87, 110, 197, 232, 75, 225, 122, 175, 123, 12, 250, 185, 122, 43, 62, 224, 129, 114, 233, 185, 218, 247, 215, 211, 167, 214, 192, 161, 141, 172, 230, 184, 75, 90, 216 }, new byte[] { 124, 248, 219, 227, 87, 112, 245, 230, 147, 190, 207, 149, 17, 255, 252, 51, 190, 29, 41, 136, 10, 140, 110, 21, 165, 77, 52, 223, 250, 110, 189, 51, 203, 115, 28, 150, 254, 28, 69, 249, 37, 49, 64, 24, 241, 107, 46, 133, 85, 39, 64, 241, 115, 239, 122, 214, 146, 12, 161, 221, 142, 139, 180, 59, 136, 166, 101, 99, 247, 128, 179, 179, 83, 178, 213, 135, 196, 244, 60, 35, 86, 51, 56, 53, 60, 210, 24, 200, 21, 232, 115, 63, 141, 120, 10, 82, 119, 216, 141, 16, 225, 143, 172, 108, 141, 164, 147, 29, 202, 43, 90, 55, 52, 99, 76, 60, 119, 230, 184, 55, 110, 88, 30, 28, 181, 173, 135, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 47, 240, 10, 96, 188, 253, 174, 166, 18, 134, 155, 225, 56, 194, 69, 153, 164, 51, 75, 44, 80, 37, 249, 78, 238, 38, 49, 51, 4, 252, 123, 236, 34, 26, 113, 126, 133, 153, 156, 169, 140, 101, 8, 85, 39, 128, 59, 240, 69, 239, 60, 209, 159, 165, 164, 40, 184, 139, 21, 19, 163, 51, 18 }, new byte[] { 124, 248, 219, 227, 87, 112, 245, 230, 147, 190, 207, 149, 17, 255, 252, 51, 190, 29, 41, 136, 10, 140, 110, 21, 165, 77, 52, 223, 250, 110, 189, 51, 203, 115, 28, 150, 254, 28, 69, 249, 37, 49, 64, 24, 241, 107, 46, 133, 85, 39, 64, 241, 115, 239, 122, 214, 146, 12, 161, 221, 142, 139, 180, 59, 136, 166, 101, 99, 247, 128, 179, 179, 83, 178, 213, 135, 196, 244, 60, 35, 86, 51, 56, 53, 60, 210, 24, 200, 21, 232, 115, 63, 141, 120, 10, 82, 119, 216, 141, 16, 225, 143, 172, 108, 141, 164, 147, 29, 202, 43, 90, 55, 52, 99, 76, 60, 119, 230, 184, 55, 110, 88, 30, 28, 181, 173, 135, 152 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_RecipeCategories_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "RecipeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
