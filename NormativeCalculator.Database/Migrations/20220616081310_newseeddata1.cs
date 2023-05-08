using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class newseeddata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "IsDeleted", "MeasureType", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 11, false, 2, "Strawberries", 15m, 1 },
                    { 12, false, 3, "Baking powder", 4m, 1 },
                    { 13, false, 2, "Blueberry", 12m, 1 },
                    { 14, false, 1, "Vanilla extract", 6m, 1 },
                    { 15, false, 3, "Caramel", 11m, 1 },
                    { 16, false, 2, "Honey", 40m, 1 },
                    { 17, false, 3, "Baking soda", 12m, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "MeasureType", "Quantity" },
                values: new object[,]
                {
                    { 8, 13, 5, 100 },
                    { 9, 12, 3, 300 },
                    { 10, 6, 3, 2 },
                    { 6, 5, 4, 1 },
                    { 2, 4, 5, 600 },
                    { 7, 4, 2, 2 },
                    { 7, 3, 3, 700 },
                    { 5, 3, 4, 4 },
                    { 5, 2, 5, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 94, 64, 162, 54, 41, 11, 240, 234, 30, 149, 239, 91, 222, 8, 211, 204, 134, 116, 191, 238, 164, 102, 37, 173, 34, 103, 120, 178, 212, 86, 73, 99, 241, 250, 230, 56, 51, 203, 2, 192, 76, 61, 112, 84, 89, 162, 103, 53, 208, 10, 30, 3, 53, 216, 87, 189, 135, 147, 12, 83, 186, 220, 82 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 3, 135, 30, 77, 133, 20, 195, 62, 254, 142, 194, 46, 198, 227, 108, 139, 235, 124, 252, 228, 239, 185, 35, 32, 230, 145, 152, 253, 183, 206, 37, 64, 29, 26, 165, 9, 213, 34, 32, 21, 251, 32, 220, 100, 61, 247, 113, 226, 197, 65, 93, 52, 57, 240, 104, 235, 167, 80, 37, 229, 7, 85, 68, 84 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 74, 172, 28, 150, 19, 103, 204, 70, 247, 159, 71, 43, 40, 114, 35, 56, 29, 81, 127, 26, 206, 249, 77, 206, 80, 248, 168, 158, 94, 165, 233, 85, 133, 251, 227, 148, 141, 19, 96, 9, 248, 54, 29, 188, 183, 182, 150, 13, 113, 125, 67, 94, 251, 75, 135, 19, 175, 25, 77, 168, 62, 112, 143 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 60, 235, 206, 202, 100, 108, 200, 47, 153, 125, 118, 80, 103, 9, 27, 59, 8, 29, 181, 204, 164, 203, 66, 200, 141, 222, 138, 119, 196, 232, 130, 80, 174, 88, 171, 41, 117, 202, 88, 45, 59, 100, 105, 14, 13, 130, 190, 247, 119, 105, 254, 161, 95, 137, 112, 243, 2, 232, 66, 185, 22, 31, 213 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 141, 161, 238, 142, 185, 235, 251, 168, 128, 46, 157, 81, 6, 66, 71, 215, 250, 167, 90, 53, 62, 196, 7, 163, 160, 126, 32, 32, 78, 37, 190, 23, 175, 67, 24, 183, 138, 145, 243, 112, 2, 131, 176, 188, 210, 189, 118, 181, 51, 240, 107, 96, 38, 248, 70, 227, 31, 245, 38, 104, 20, 111, 3, 186 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 151, 145, 71, 57, 237, 250, 194, 5, 50, 196, 7, 74, 34, 80, 191, 127, 164, 51, 108, 148, 52, 12, 205, 5, 174, 53, 119, 176, 32, 33, 108, 235, 80, 137, 121, 235, 249, 106, 46, 114, 197, 228, 207, 209, 17, 100, 217, 224, 222, 22, 74, 43, 224, 230, 21, 158, 16, 7, 74, 159, 100, 27, 143, 183 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 19, 132, 101, 157, 151, 108, 81, 241, 201, 170, 132, 91, 243, 78, 37, 36, 117, 25, 101, 127, 150, 175, 220, 84, 131, 83, 124, 178, 176, 213, 137, 168, 104, 117, 109, 235, 146, 166, 121, 178, 26, 121, 191, 172, 15, 143, 15, 93, 217, 134, 216, 90, 13, 180, 176, 185, 194, 230, 53, 201, 209, 222, 159 }, new byte[] { 208, 36, 189, 249, 3, 184, 31, 72, 78, 66, 192, 202, 12, 154, 62, 165, 231, 188, 161, 205, 151, 178, 229, 202, 171, 223, 12, 64, 39, 239, 117, 153, 187, 16, 26, 20, 249, 127, 83, 80, 142, 31, 88, 105, 230, 230, 151, 31, 60, 217, 194, 147, 111, 18, 180, 81, 89, 162, 19, 145, 78, 55, 6, 219, 63, 191, 47, 46, 238, 238, 20, 30, 211, 20, 183, 164, 31, 145, 193, 216, 148, 21, 239, 66, 248, 143, 250, 218, 89, 166, 72, 110, 46, 230, 56, 246, 210, 254, 172, 171, 144, 157, 181, 42, 218, 248, 56, 8, 241, 69, 127, 177, 102, 198, 241, 166, 121, 94, 77, 208, 124, 148, 1, 181, 215, 232, 151, 247 } });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "MeasureType", "Quantity" },
                values: new object[,]
                {
                    { 11, 5, 5, 3 },
                    { 12, 10, 3, 300 },
                    { 12, 11, 3, 300 },
                    { 13, 6, 3, 5 },
                    { 13, 9, 1, 10 },
                    { 13, 13, 3, 300 },
                    { 14, 8, 3, 200 },
                    { 15, 8, 2, 1 },
                    { 16, 7, 3, 600 },
                    { 17, 7, 3, 150 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 135, 255, 37, 230, 57, 153, 118, 226, 167, 74, 14, 137, 170, 231, 24, 42, 41, 200, 187, 230, 131, 42, 110, 102, 134, 52, 254, 245, 229, 78, 108, 107, 217, 36, 24, 62, 46, 31, 66, 168, 40, 219, 88, 142, 28, 65, 70, 235, 146, 196, 3, 111, 188, 219, 165, 89, 254, 39, 215, 134, 224, 52, 114, 68 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 9, 29, 173, 125, 160, 80, 166, 76, 113, 243, 25, 152, 177, 69, 132, 139, 245, 184, 59, 241, 215, 51, 138, 132, 6, 140, 58, 202, 175, 21, 173, 15, 181, 7, 199, 193, 59, 182, 244, 213, 50, 51, 123, 89, 54, 23, 77, 37, 206, 212, 226, 133, 186, 248, 164, 58, 219, 248, 51, 68, 22, 197, 144 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 225, 216, 226, 176, 60, 127, 162, 253, 87, 60, 36, 30, 247, 70, 4, 159, 197, 85, 55, 109, 245, 152, 152, 180, 251, 217, 127, 227, 33, 196, 71, 73, 167, 219, 120, 223, 116, 243, 55, 219, 47, 156, 154, 16, 196, 0, 85, 180, 8, 234, 127, 218, 155, 113, 29, 250, 36, 136, 0, 152, 138, 42, 43, 227 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 155, 165, 119, 20, 48, 132, 98, 64, 253, 81, 242, 147, 181, 23, 113, 252, 156, 223, 215, 45, 224, 69, 139, 252, 159, 172, 158, 101, 226, 22, 40, 182, 152, 198, 127, 75, 232, 49, 42, 92, 11, 170, 117, 146, 226, 91, 104, 197, 210, 38, 106, 242, 47, 194, 172, 1, 134, 152, 152, 0, 213, 225, 16 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 158, 244, 225, 173, 61, 76, 145, 55, 63, 57, 60, 201, 183, 238, 143, 100, 7, 165, 181, 111, 152, 134, 188, 244, 166, 59, 216, 159, 21, 182, 153, 102, 42, 16, 79, 194, 247, 212, 162, 139, 67, 16, 107, 100, 242, 133, 170, 148, 149, 79, 206, 13, 44, 176, 230, 121, 99, 250, 58, 6, 111, 146, 189, 228 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 139, 94, 245, 146, 100, 71, 192, 217, 126, 199, 254, 179, 148, 220, 128, 105, 89, 105, 197, 112, 136, 212, 62, 185, 66, 41, 170, 4, 228, 96, 184, 162, 219, 22, 226, 181, 179, 195, 147, 73, 129, 54, 246, 120, 254, 236, 151, 102, 234, 79, 212, 166, 46, 191, 141, 123, 124, 8, 44, 6, 12, 190, 168 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 59, 3, 253, 64, 238, 181, 13, 9, 166, 75, 226, 175, 188, 24, 78, 150, 76, 221, 233, 0, 59, 146, 3, 253, 196, 78, 70, 228, 164, 165, 121, 237, 254, 28, 181, 212, 213, 50, 167, 96, 6, 63, 190, 251, 122, 163, 219, 37, 144, 47, 147, 41, 182, 219, 201, 65, 111, 72, 237, 91, 192, 96, 113, 221 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 } });
        }
    }
}
