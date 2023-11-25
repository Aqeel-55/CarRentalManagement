using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f0e4ede0-53af-4f99-9ced-6614ec271f29", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKhn2L/unOi0HW3NER5S9KOgEUuXsrnSgCqLfRt77yB6TMgfAK85NuFw2tfWvdilvQ==", null, false, "88dd6869-69f9-45c2-9f70-2755e30fff29", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(2871), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(2875), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3198), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3200), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3359), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3359), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3361), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3361), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3362), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3363), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3364), new DateTime(2023, 11, 26, 1, 15, 19, 899, DateTimeKind.Local).AddTicks(3364), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
