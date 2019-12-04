using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf4.Migrations
{
    public partial class _6666353 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "075e931e-8015-41ec-8ee2-58abcbef51bf", "AQAAAAEAACcQAAAAEN1m2YpExKKBHzHy2TqfUdp9J1Op2Q3Wmz8nK8T3LE1NSorjCpX5rY69Wj5traEysw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d132a40-05cb-4aeb-a3d8-dcc0842521d8", "AQAAAAEAACcQAAAAEGpn7RgK6jksw1ixjalBnDT4FZ3wY068kDWM7d456GVfpn8ZfRDvxwRQ7i3+qGQ9Yw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0328fc50-ad44-483d-a262-a1b45b4d6f87", "AQAAAAEAACcQAAAAEAmrvEaTpRjoadFfgHz3np3HH8nF2vIhATHjjP4FgESsHtAbCEtIAtyo6D0UqM7MeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75b3e5ce-2478-41c8-ae2f-15ad3d210017", "AQAAAAEAACcQAAAAEOj0nT74uW7Z6Di2gXV97CIo8Jl0k2fnJv8GFoMJWpLWJbbXmBx7H2/BuD+kZ3IG3g==" });
        }
    }
}
