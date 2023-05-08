using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class newseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 7, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cheesecake" },
                    { 8, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Coffee Cake Recipes" },
                    { 9, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Coconut Cake" },
                    { 10, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cupcakes" },
                    { 11, new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fruitcake" },
                    { 12, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Holiday cake" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Egg");

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "This easy American pancake recipe makes light and fluffy pancakes that are great for a weekend brunch.", false, "Lite Carrot Cake", 1 },
                    { 2, 6, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pipe royal icing carrots on parchment to decorate your cake.", false, "Royal Icing Carrots", 2 }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 7, "Nejra", "Setka", new byte[] { 59, 3, 253, 64, 238, 181, 13, 9, 166, 75, 226, 175, 188, 24, 78, 150, 76, 221, 233, 0, 59, 146, 3, 253, 196, 78, 70, 228, 164, 165, 121, 237, 254, 28, 181, 212, 213, 50, 167, 96, 6, 63, 190, 251, 122, 163, 219, 37, 144, 47, 147, 41, 182, 219, 201, 65, 111, 72, 237, 91, 192, 96, 113, 221 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 }, "nejra" },
                    { 5, "Mirza", "Lepir", new byte[] { 158, 244, 225, 173, 61, 76, 145, 55, 63, 57, 60, 201, 183, 238, 143, 100, 7, 165, 181, 111, 152, 134, 188, 244, 166, 59, 216, 159, 21, 182, 153, 102, 42, 16, 79, 194, 247, 212, 162, 139, 67, 16, 107, 100, 242, 133, 170, 148, 149, 79, 206, 13, 44, 176, 230, 121, 99, 250, 58, 6, 111, 146, 189, 228 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 }, "mirza" },
                    { 4, "Amra", "Dedic", new byte[] { 90, 155, 165, 119, 20, 48, 132, 98, 64, 253, 81, 242, 147, 181, 23, 113, 252, 156, 223, 215, 45, 224, 69, 139, 252, 159, 172, 158, 101, 226, 22, 40, 182, 152, 198, 127, 75, 232, 49, 42, 92, 11, 170, 117, 146, 226, 91, 104, 197, 210, 38, 106, 242, 47, 194, 172, 1, 134, 152, 152, 0, 213, 225, 16 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 }, "amra" },
                    { 6, "Haris", "Tulic", new byte[] { 47, 139, 94, 245, 146, 100, 71, 192, 217, 126, 199, 254, 179, 148, 220, 128, 105, 89, 105, 197, 112, 136, 212, 62, 185, 66, 41, 170, 4, 228, 96, 184, 162, 219, 22, 226, 181, 179, 195, 147, 73, 129, 54, 246, 120, 254, 236, 151, 102, 234, 79, 212, 166, 46, 191, 141, 123, 124, 8, 44, 6, 12, 190, 168 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 }, "haris" },
                    { 3, "Alema", "Duvnjak", new byte[] { 225, 216, 226, 176, 60, 127, 162, 253, 87, 60, 36, 30, 247, 70, 4, 159, 197, 85, 55, 109, 245, 152, 152, 180, 251, 217, 127, 227, 33, 196, 71, 73, 167, 219, 120, 223, 116, 243, 55, 219, 47, 156, 154, 16, 196, 0, 85, 180, 8, 234, 127, 218, 155, 113, 29, 250, 36, 136, 0, 152, 138, 42, 43, 227 }, new byte[] { 9, 43, 127, 204, 98, 149, 182, 21, 19, 223, 31, 86, 23, 187, 4, 56, 93, 189, 174, 38, 41, 34, 48, 94, 104, 154, 224, 185, 78, 93, 69, 238, 16, 221, 181, 65, 197, 80, 100, 169, 98, 173, 128, 20, 207, 66, 181, 77, 37, 181, 158, 127, 149, 179, 232, 68, 61, 63, 142, 157, 208, 87, 216, 151, 46, 121, 204, 175, 29, 132, 236, 172, 132, 64, 225, 62, 197, 246, 241, 35, 236, 86, 187, 82, 78, 8, 191, 242, 247, 93, 125, 90, 44, 56, 99, 49, 187, 42, 160, 230, 159, 21, 123, 123, 184, 48, 246, 142, 118, 8, 217, 179, 211, 226, 9, 1, 235, 249, 109, 226, 208, 198, 103, 0, 239, 199, 167, 208 }, "alema" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "IsDeleted", "Name", "UserId" },
                values: new object[,]
                {
                    { 3, 7, new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a great recipe that gets compliments when ever I make it..", false, "Brownie Caramel Cheesecake", 2 },
                    { 13, 12, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sweet biscuit-style shortcake with two layers of juicy strawberries and cream.", false, "Strawberry Shortcake", 2 },
                    { 6, 8, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is really easy and so very, very good.", false, "Apple Coffee Cake", 3 },
                    { 11, 11, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has been a favorite of my husband's since I can long remember.", false, "English Walnut Date Cake", 3 },
                    { 12, 11, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a large recipe that is rich and dark.", false, "Festive Fruitcakee", 3 },
                    { 7, 9, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "A moist coconut pound cake, a crowd pleaser.", false, "Coconut Cream Pound Cake", 4 },
                    { 4, 7, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love lemon meringue pie and cheesecake?", false, "Lemon Meringue Cheesecake", 5 },
                    { 8, 9, new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coconut oil is the special ingredient in these delicately flavored, tender cupcakes. Garnish with a slice of fresh Key lime if desired.", false, "Coconut Cupcakes", 5 },
                    { 9, 10, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "This simple white cake recipe uses just 7 ingredients.", false, "Simple White Cake", 5 },
                    { 10, 10, new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cinnamon sugary cupcake reminiscent of the deep - fried Mexican dessert!.", false, "Sopapilla Cupcakes", 6 },
                    { 5, 8, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love lemon meringue pie and cheesecake?", false, "Blueberry Buttermilk Coffeecake", 7 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "MeasureType", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, 1, 3 },
                    { 3, 2, 2, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "egg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 213, 124, 63, 119, 27, 189, 100, 251, 4, 48, 218, 105, 237, 122, 48, 164, 181, 247, 24, 118, 106, 97, 29, 9, 181, 167, 225, 86, 210, 95, 116, 107, 38, 192, 97, 154, 163, 75, 2, 225, 75, 46, 38, 133, 237, 148, 64, 117, 142, 172, 126, 108, 226, 107, 52, 39, 233, 236, 246, 175, 107, 0, 87 }, new byte[] { 54, 170, 19, 133, 56, 169, 163, 151, 177, 254, 31, 169, 214, 78, 126, 138, 67, 114, 16, 38, 92, 175, 179, 52, 30, 161, 217, 7, 188, 165, 233, 165, 212, 153, 237, 95, 198, 58, 245, 196, 167, 229, 187, 48, 124, 173, 30, 18, 88, 22, 199, 61, 195, 154, 250, 131, 63, 186, 134, 158, 147, 4, 161, 67, 120, 130, 168, 207, 193, 44, 143, 106, 153, 195, 252, 210, 126, 250, 50, 188, 142, 44, 54, 98, 140, 116, 73, 97, 63, 114, 208, 205, 111, 217, 117, 137, 141, 102, 157, 200, 93, 179, 101, 52, 248, 114, 176, 138, 72, 201, 64, 179, 25, 152, 87, 108, 20, 4, 224, 54, 206, 172, 145, 223, 218, 157, 137, 3 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 253, 25, 144, 29, 28, 227, 30, 126, 69, 240, 63, 115, 255, 169, 128, 16, 116, 35, 194, 209, 17, 172, 194, 131, 153, 157, 99, 160, 57, 124, 44, 68, 179, 227, 57, 210, 228, 193, 71, 121, 21, 53, 36, 33, 215, 108, 85, 177, 226, 79, 156, 20, 147, 149, 206, 157, 173, 253, 173, 33, 111, 169, 112 }, new byte[] { 54, 170, 19, 133, 56, 169, 163, 151, 177, 254, 31, 169, 214, 78, 126, 138, 67, 114, 16, 38, 92, 175, 179, 52, 30, 161, 217, 7, 188, 165, 233, 165, 212, 153, 237, 95, 198, 58, 245, 196, 167, 229, 187, 48, 124, 173, 30, 18, 88, 22, 199, 61, 195, 154, 250, 131, 63, 186, 134, 158, 147, 4, 161, 67, 120, 130, 168, 207, 193, 44, 143, 106, 153, 195, 252, 210, 126, 250, 50, 188, 142, 44, 54, 98, 140, 116, 73, 97, 63, 114, 208, 205, 111, 217, 117, 137, 141, 102, 157, 200, 93, 179, 101, 52, 248, 114, 176, 138, 72, 201, 64, 179, 25, 152, 87, 108, 20, 4, 224, 54, 206, 172, 145, 223, 218, 157, 137, 3 } });
        }
    }
}
