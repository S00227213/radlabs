using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week8ClassLibrary2023.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ClubDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 16, 47, 3, 579, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 12, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5123), "Dublin", new DateTime(2023, 12, 31, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5122), "Local Sports Hall" });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 3,
                columns: new[] { "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[] { 1, new DateTime(2024, 1, 15, 14, 47, 3, 579, DateTimeKind.Local).AddTicks(5127), "Dublin", new DateTime(2024, 1, 15, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5125), "Community Center" });

            migrationBuilder.InsertData(
                table: "ClubEvent",
                columns: new[] { "EventID", "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2024, 1, 30, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5130), "Dublin", new DateTime(2024, 1, 30, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5129), "University Sports Complex" },
                    { 5, 2, new DateTime(2023, 12, 16, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5133), "Ballsbridge, Dublin", new DateTime(2023, 12, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5132), "Aviva Stadium" },
                    { 6, 2, new DateTime(2024, 1, 5, 14, 47, 3, 579, DateTimeKind.Local).AddTicks(5136), "Dublin", new DateTime(2024, 1, 5, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5135), "Local Football Field" },
                    { 7, 2, new DateTime(2024, 1, 25, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5140), "Dublin", new DateTime(2024, 1, 25, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5138), "High School Stadium" },
                    { 8, 2, new DateTime(2024, 2, 14, 14, 47, 3, 579, DateTimeKind.Local).AddTicks(5144), "Dublin", new DateTime(2024, 2, 14, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5143), "City Park Arena" },
                    { 9, 3, new DateTime(2023, 12, 16, 14, 47, 3, 579, DateTimeKind.Local).AddTicks(5147), "South Circular Road, Dublin", new DateTime(2023, 12, 16, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5146), "National Boxing Stadium" },
                    { 10, 3, new DateTime(2024, 1, 10, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5151), "Dublin", new DateTime(2024, 1, 10, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5149), "Downtown Gym" },
                    { 11, 3, new DateTime(2024, 2, 4, 14, 47, 3, 579, DateTimeKind.Local).AddTicks(5154), "Dublin", new DateTime(2024, 2, 4, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5153), "Local Fitness Center" },
                    { 12, 3, new DateTime(2024, 2, 29, 15, 47, 3, 579, DateTimeKind.Local).AddTicks(5157), "Dublin", new DateTime(2024, 2, 29, 12, 47, 3, 579, DateTimeKind.Local).AddTicks(5156), "University Sports Hall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 11, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 33, 21, 339, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 12, 8, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[] { 2, new DateTime(2024, 1, 7, 13, 33, 21, 339, DateTimeKind.Local).AddTicks(2374), "Ballsbridge, Dublin", new DateTime(2024, 1, 7, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2368), "Aviva Stadium" });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 3,
                columns: new[] { "ClubId", "EndDateTime", "Location", "StartDateTime", "Venue" },
                values: new object[] { 3, new DateTime(2024, 2, 6, 12, 33, 21, 339, DateTimeKind.Local).AddTicks(2388), "South Circular Road, Dublin", new DateTime(2024, 2, 6, 10, 33, 21, 339, DateTimeKind.Local).AddTicks(2383), "National Boxing Stadium" });
        }
    }
}
