using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaseProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("9d451187-7eb4-49fe-b7bd-49e7e9e6bec9"), new Guid("fe743bed-2fdc-4b1b-b5eb-d681aeb09aeb") });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9d451187-7eb4-49fe-b7bd-49e7e9e6bec9"), null, "admin", "admin", "admin" },
                    { new Guid("d66b2c46-2c04-449f-ba99-62e2fa8126d3"), null, "User Role", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBir", "Description", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fe743bed-2fdc-4b1b-b5eb-d681aeb09aeb"), 0, null, "b7f53372-1077-4578-b330-ede80f34adae", null, null, "luunguyentrungtin@gmail.com", false, null, false, null, null, null, null, "AQAAAAIAAYagAAAAEDQkSfXkMnD/dS3nWDfmJe3SO/uuG7MGtqKgXx96FGwEEZSUTXHOEYD2HmM1UdrUrw==", null, false, null, false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9d451187-7eb4-49fe-b7bd-49e7e9e6bec9"), new Guid("fe743bed-2fdc-4b1b-b5eb-d681aeb09aeb") });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9d451187-7eb4-49fe-b7bd-49e7e9e6bec9"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d66b2c46-2c04-449f-ba99-62e2fa8126d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe743bed-2fdc-4b1b-b5eb-d681aeb09aeb"));
        }
    }
}
