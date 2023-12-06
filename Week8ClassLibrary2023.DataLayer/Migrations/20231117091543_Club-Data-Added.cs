using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                value: new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(625), new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 31, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 7,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 16, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 8,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 31, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 9,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 17, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(654), new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 10,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 1, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 11,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 16, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 12,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 31, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(662) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Club",
                keyColumn: "ClubId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 11, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 22, 15, 30, 718, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 12, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 31, 22, 15, 30, 718, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 12, 31, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 15, 30, 718, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 1, 15, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 22, 15, 30, 718, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 1, 30, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 21, 15, 30, 718, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 12, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 31, 21, 15, 30, 718, DateTimeKind.Local).AddTicks(4174), new DateTime(2023, 12, 31, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 7,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 21, 15, 30, 718, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 1, 15, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 8,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 21, 15, 30, 718, DateTimeKind.Local).AddTicks(4181), new DateTime(2024, 1, 30, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 9,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 16, 20, 15, 30, 718, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 12, 16, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 10,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 31, 20, 15, 30, 718, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 12, 31, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 11,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 20, 15, 30, 718, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 1, 15, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "ClubEvent",
                keyColumn: "EventID",
                keyValue: 12,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 20, 15, 30, 718, DateTimeKind.Local).AddTicks(4195), new DateTime(2024, 1, 30, 18, 15, 30, 718, DateTimeKind.Local).AddTicks(4193) });
        }
    }
}
