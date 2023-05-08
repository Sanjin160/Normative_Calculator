﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class baseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 14, 10, 9, 22, 926, DateTimeKind.Local).AddTicks(7166));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Category");

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
        }
    }
}