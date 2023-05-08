using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                values: new object[] { new byte[] { 60, 63, 124, 60, 40, 182, 231, 213, 13, 227, 237, 136, 187, 111, 166, 108, 67, 121, 238, 111, 193, 16, 181, 208, 193, 249, 163, 188, 35, 212, 166, 118, 16, 212, 200, 195, 245, 134, 201, 200, 184, 124, 10, 96, 105, 145, 249, 67, 215, 228, 54, 189, 11, 136, 175, 234, 245, 106, 134, 207, 53, 238, 116, 94 }, new byte[] { 117, 136, 206, 44, 102, 128, 79, 252, 156, 227, 210, 95, 205, 54, 35, 242, 219, 201, 225, 120, 217, 174, 170, 220, 74, 238, 28, 4, 58, 132, 87, 218, 51, 220, 102, 45, 155, 150, 126, 240, 89, 46, 57, 127, 41, 234, 226, 212, 255, 188, 108, 197, 141, 29, 90, 185, 196, 128, 115, 239, 144, 197, 227, 220, 44, 95, 119, 191, 220, 106, 224, 186, 236, 205, 67, 190, 113, 223, 185, 18, 121, 17, 217, 93, 84, 35, 174, 199, 2, 78, 224, 128, 201, 203, 189, 73, 18, 96, 253, 220, 221, 21, 4, 155, 198, 101, 252, 111, 114, 13, 122, 31, 141, 31, 23, 23, 176, 175, 62, 75, 189, 95, 209, 247, 232, 141, 94, 181 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 160, 214, 183, 242, 235, 154, 191, 18, 180, 9, 111, 122, 98, 251, 11, 156, 120, 50, 232, 126, 75, 125, 171, 3, 68, 51, 195, 82, 93, 204, 54, 172, 144, 3, 177, 115, 197, 50, 33, 205, 112, 209, 96, 134, 160, 130, 101, 6, 61, 134, 96, 90, 217, 61, 233, 216, 255, 222, 129, 21, 43, 111, 200, 173 }, new byte[] { 117, 136, 206, 44, 102, 128, 79, 252, 156, 227, 210, 95, 205, 54, 35, 242, 219, 201, 225, 120, 217, 174, 170, 220, 74, 238, 28, 4, 58, 132, 87, 218, 51, 220, 102, 45, 155, 150, 126, 240, 89, 46, 57, 127, 41, 234, 226, 212, 255, 188, 108, 197, 141, 29, 90, 185, 196, 128, 115, 239, 144, 197, 227, 220, 44, 95, 119, 191, 220, 106, 224, 186, 236, 205, 67, 190, 113, 223, 185, 18, 121, 17, 217, 93, 84, 35, 174, 199, 2, 78, 224, 128, 201, 203, 189, 73, 18, 96, 253, 220, 221, 21, 4, 155, 198, 101, 252, 111, 114, 13, 122, 31, 141, 31, 23, 23, 176, 175, 62, 75, 189, 95, 209, 247, 232, 141, 94, 181 } });
        }
    }
}
