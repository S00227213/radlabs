using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week9.Data.ClassLib.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "ClubId", "ClubName", "CreationDate", "adminID" },
                values: new object[,]
                {
                    { 1, "Chess Club", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, "Book Club", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 101 },
                    { 3, "Coding Club", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102 }
                });

            migrationBuilder.InsertData(
                table: "ClubEvent",
                columns: new[] { "EventID", "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "Room 101", new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Library" },
                    { 2, 2, new DateTime(2022, 5, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "Main Hall", new DateTime(2022, 5, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Community Hall" },
                    { 3, 3, new DateTime(2022, 6, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Lab A", new DateTime(2022, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Tech Center" }
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
