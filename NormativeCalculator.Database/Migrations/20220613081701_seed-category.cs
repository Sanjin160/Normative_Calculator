using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class seedcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 13, 10, 17, 0, 904, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
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
        }
    }
}
