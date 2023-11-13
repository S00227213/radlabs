using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week6MVCProduct2324.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserAndRolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3900551e-ef4d-44d3-9dbb-ed7f67de1ad6", "536a43d6-bf3e-4ca1-b605-4f24b828dd1f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3900551e-ef4d-44d3-9dbb-ed7f67de1ad6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "536a43d6-bf3e-4ca1-b605-4f24b828dd1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "421afa99-7b9c-49cb-8912-0009455c8f43", "a2c43785-4b14-492c-8635-a84bb75dd326", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bae48cfa-0ad1-4f5d-9977-2afa6b7e0b32", 0, "b7c4d733-fc37-4965-9988-0974ab1aa9b8", "paul.powell@atu.ie", true, false, null, null, "PAUL.POWELL@ATU.IE", "AQAAAAIAAYagAAAAELCOdN7iHeQBdAe4K9KyAPhYgglAwx7HkaFf2pS05gpC6hUVOyE85DBtC1zKSUiwPg==", null, false, "e4347bec-cb68-484f-9b3f-2e0705ca0216", false, "paul.powell@atu.ie" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "421afa99-7b9c-49cb-8912-0009455c8f43", "bae48cfa-0ad1-4f5d-9977-2afa6b7e0b32" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "421afa99-7b9c-49cb-8912-0009455c8f43", "bae48cfa-0ad1-4f5d-9977-2afa6b7e0b32" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "421afa99-7b9c-49cb-8912-0009455c8f43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bae48cfa-0ad1-4f5d-9977-2afa6b7e0b32");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3900551e-ef4d-44d3-9dbb-ed7f67de1ad6", "271f8d43-e2d9-4112-b649-5bd5e180a6fb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "536a43d6-bf3e-4ca1-b605-4f24b828dd1f", 0, "8b304604-fef6-4ff4-9a34-2d0d701b70a5", "paul.powell@atu.ie", true, false, null, null, "PAUL.POWELL@ATU.IE", "AQAAAAIAAYagAAAAELAwmE+sEfULX11KQySFnbTCiyn39BIIoI84zwvOh5cDMdfE/vb3LOLQGFVgeQgLGg==", null, false, "aec1c550-9694-4eb0-bc83-76d789a513d4", false, "paul.powell@atu.ie" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3900551e-ef4d-44d3-9dbb-ed7f67de1ad6", "536a43d6-bf3e-4ca1-b605-4f24b828dd1f" });
        }
    }
}
