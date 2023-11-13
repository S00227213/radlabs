using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week8ClassLibrary2023.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class seededdatabasewithclubeventd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "ClubId", "ClubName", "CreationDate", "adminID" },
                values: new object[,]
                {
                    { 1, "Basketball Club", new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1789), 1 },
                    { 2, "Football Club", new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1870), 2 },
                    { 3, "Boxing Club", new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1880), 3 }
                });

            migrationBuilder.InsertData(
                table: "ClubEvent",
                columns: new[] { "EventID", "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 8, 14, 33, 21, 339, DateTimeKind.Local).AddTicks(2357), "Tallaght, Dublin", new DateTime(2023, 12, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2344), "National Basketball Arena" },
                    { 2, 2, new DateTime(2024, 1, 7, 13, 33, 21, 339, DateTimeKind.Local).AddTicks(2374), "Ballsbridge, Dublin", new DateTime(2024, 1, 7, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2368), "Aviva Stadium" },
                    { 3, 3, new DateTime(2024, 2, 6, 12, 33, 21, 339, DateTimeKind.Local).AddTicks(2388), "South Circular Road, Dublin", new DateTime(2024, 2, 6, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2383), "National Boxing Stadium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 3);
        }
    }
}
