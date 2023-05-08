using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class isdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Recipe",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Ingredients",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 35, 24, 812, DateTimeKind.Local).AddTicks(7971), false });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 78, 147, 153, 224, 113, 243, 66, 209, 99, 66, 17, 244, 199, 199, 232, 15, 184, 252, 17, 45, 200, 114, 58, 145, 128, 62, 201, 28, 179, 32, 139, 153, 214, 14, 241, 239, 124, 85, 135, 227, 109, 215, 69, 104, 153, 187, 103, 196, 154, 214, 80, 52, 21, 211, 81, 225, 177, 138, 215, 247, 39, 22, 95, 76 }, new byte[] { 243, 162, 18, 164, 142, 240, 75, 128, 170, 199, 50, 209, 229, 140, 225, 119, 144, 94, 22, 109, 221, 252, 28, 5, 148, 247, 172, 244, 48, 87, 203, 225, 254, 116, 127, 224, 207, 134, 251, 120, 63, 183, 137, 242, 129, 142, 83, 229, 176, 174, 193, 85, 124, 186, 5, 134, 112, 88, 169, 80, 67, 146, 82, 226, 59, 159, 32, 84, 214, 36, 90, 102, 89, 88, 240, 46, 236, 190, 249, 153, 185, 71, 91, 18, 168, 70, 45, 237, 77, 225, 129, 130, 163, 175, 208, 146, 29, 187, 113, 78, 84, 42, 187, 115, 69, 129, 44, 61, 76, 137, 85, 181, 45, 193, 30, 65, 122, 229, 98, 104, 89, 186, 184, 154, 40, 32, 107, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 120, 169, 43, 32, 165, 51, 153, 65, 237, 210, 236, 36, 162, 94, 202, 197, 137, 107, 28, 71, 72, 157, 219, 0, 244, 153, 26, 237, 67, 5, 102, 26, 79, 229, 99, 247, 118, 23, 104, 94, 234, 14, 134, 31, 226, 138, 162, 42, 106, 123, 188, 78, 104, 0, 35, 253, 235, 84, 122, 136, 9, 9, 232, 128 }, new byte[] { 243, 162, 18, 164, 142, 240, 75, 128, 170, 199, 50, 209, 229, 140, 225, 119, 144, 94, 22, 109, 221, 252, 28, 5, 148, 247, 172, 244, 48, 87, 203, 225, 254, 116, 127, 224, 207, 134, 251, 120, 63, 183, 137, 242, 129, 142, 83, 229, 176, 174, 193, 85, 124, 186, 5, 134, 112, 88, 169, 80, 67, 146, 82, 226, 59, 159, 32, 84, 214, 36, 90, 102, 89, 88, 240, 46, 236, 190, 249, 153, 185, 71, 91, 18, 168, 70, 45, 237, 77, 225, 129, 130, 163, 175, 208, 146, 29, 187, 113, 78, 84, 42, 187, 115, 69, 129, 44, 61, 76, 137, 85, 181, 45, 193, 30, 65, 122, 229, 98, 104, 89, 186, 184, 154, 40, 32, 107, 124 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Ingredients");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2022, 6, 14, 10, 9, 22, 926, DateTimeKind.Local).AddTicks(7166), null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 87, 239, 59, 170, 114, 250, 71, 48, 201, 9, 164, 120, 232, 95, 243, 8, 146, 38, 65, 80, 76, 92, 243, 162, 128, 129, 100, 207, 216, 82, 177, 80, 130, 37, 34, 23, 156, 119, 55, 108, 223, 234, 209, 234, 123, 44, 2, 141, 152, 181, 89, 75, 209, 39, 82, 220, 107, 141, 53, 57, 99, 201, 152, 97 }, new byte[] { 45, 193, 134, 107, 48, 22, 175, 216, 243, 129, 35, 214, 90, 27, 27, 14, 110, 101, 80, 255, 186, 63, 62, 14, 209, 139, 236, 117, 206, 242, 48, 238, 24, 63, 114, 245, 140, 130, 241, 82, 212, 28, 50, 65, 2, 7, 74, 167, 24, 24, 106, 29, 180, 4, 10, 173, 245, 5, 22, 171, 54, 0, 24, 38, 50, 158, 113, 188, 71, 108, 14, 185, 176, 122, 117, 208, 247, 244, 129, 9, 173, 218, 230, 199, 131, 99, 189, 174, 190, 26, 42, 117, 230, 164, 202, 58, 88, 218, 88, 46, 158, 137, 77, 113, 233, 33, 66, 223, 159, 26, 213, 42, 209, 130, 48, 137, 84, 29, 112, 214, 217, 37, 127, 181, 251, 212, 46, 83 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 55, 65, 123, 220, 35, 201, 144, 98, 166, 178, 92, 12, 114, 205, 163, 32, 3, 183, 105, 113, 34, 218, 9, 161, 233, 118, 193, 178, 41, 235, 218, 214, 192, 18, 102, 60, 203, 53, 129, 98, 173, 111, 146, 7, 155, 54, 60, 7, 204, 140, 169, 251, 208, 19, 250, 103, 57, 4, 119, 218, 146, 134, 60 }, new byte[] { 45, 193, 134, 107, 48, 22, 175, 216, 243, 129, 35, 214, 90, 27, 27, 14, 110, 101, 80, 255, 186, 63, 62, 14, 209, 139, 236, 117, 206, 242, 48, 238, 24, 63, 114, 245, 140, 130, 241, 82, 212, 28, 50, 65, 2, 7, 74, 167, 24, 24, 106, 29, 180, 4, 10, 173, 245, 5, 22, 171, 54, 0, 24, 38, 50, 158, 113, 188, 71, 108, 14, 185, 176, 122, 117, 208, 247, 244, 129, 9, 173, 218, 230, 199, 131, 99, 189, 174, 190, 26, 42, 117, 230, 164, 202, 58, 88, 218, 88, 46, 158, 137, 77, 113, 233, 33, 66, 223, 159, 26, 213, 42, 209, 130, 48, 137, 84, 29, 112, 214, 217, 37, 127, 181, 251, 212, 46, 83 } });
        }
    }
}
