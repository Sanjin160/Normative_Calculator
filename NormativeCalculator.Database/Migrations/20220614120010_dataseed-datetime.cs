using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class dataseeddatetime : Migration
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
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 95, 57, 57, 35, 108, 139, 139, 16, 72, 18, 66, 32, 246, 47, 141, 248, 213, 232, 158, 29, 62, 148, 215, 193, 87, 214, 207, 82, 45, 230, 159, 139, 6, 164, 13, 236, 2, 96, 95, 165, 27, 145, 55, 145, 135, 49, 181, 57, 224, 212, 34, 208, 138, 208, 157, 223, 213, 98, 52, 209, 188, 183, 234, 131 }, new byte[] { 54, 169, 197, 242, 224, 163, 202, 254, 76, 167, 137, 229, 2, 232, 252, 86, 225, 241, 168, 89, 247, 215, 122, 232, 245, 48, 78, 155, 18, 225, 194, 144, 63, 83, 233, 128, 48, 47, 157, 223, 29, 231, 242, 114, 53, 145, 78, 153, 138, 195, 150, 19, 159, 236, 177, 72, 200, 112, 228, 62, 6, 95, 68, 5, 212, 131, 170, 255, 14, 62, 104, 164, 26, 25, 14, 38, 169, 196, 19, 218, 102, 142, 0, 226, 193, 180, 143, 139, 101, 193, 181, 117, 106, 199, 145, 1, 12, 185, 165, 102, 125, 1, 122, 50, 216, 19, 228, 1, 187, 133, 246, 250, 15, 218, 230, 196, 107, 145, 243, 182, 125, 31, 221, 76, 213, 209, 161, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 13, 210, 99, 125, 113, 130, 132, 86, 187, 76, 208, 186, 34, 1, 218, 183, 40, 102, 231, 190, 40, 106, 126, 230, 58, 49, 189, 253, 102, 92, 55, 201, 98, 127, 248, 117, 150, 9, 138, 38, 91, 14, 168, 113, 162, 5, 197, 119, 8, 59, 204, 146, 34, 241, 247, 155, 175, 129, 172, 94, 22, 239, 197, 152 }, new byte[] { 54, 169, 197, 242, 224, 163, 202, 254, 76, 167, 137, 229, 2, 232, 252, 86, 225, 241, 168, 89, 247, 215, 122, 232, 245, 48, 78, 155, 18, 225, 194, 144, 63, 83, 233, 128, 48, 47, 157, 223, 29, 231, 242, 114, 53, 145, 78, 153, 138, 195, 150, 19, 159, 236, 177, 72, 200, 112, 228, 62, 6, 95, 68, 5, 212, 131, 170, 255, 14, 62, 104, 164, 26, 25, 14, 38, 169, 196, 19, 218, 102, 142, 0, 226, 193, 180, 143, 139, 101, 193, 181, 117, 106, 199, 145, 1, 12, 185, 165, 102, 125, 1, 122, 50, 216, 19, 228, 1, 187, 133, 246, 250, 15, 218, 230, 196, 107, 145, 243, 182, 125, 31, 221, 76, 213, 209, 161, 243 } });
        }
    }
}
