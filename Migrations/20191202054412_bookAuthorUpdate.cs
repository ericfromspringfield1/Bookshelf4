using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf4.Migrations
{
    public partial class bookAuthorUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85d89438-604f-4dba-90e2-4905120922dc", "AQAAAAEAACcQAAAAEMMILRaMO8PecZIDJ6+B6Psh5aVt/EUt7HLB8dROFIlB3oOCOO72acel0jQ7g2oe3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b018575-6c01-4494-8577-2e6867f3441e", "AQAAAAEAACcQAAAAEK+f9cmtealoWsSzYf6Qq7rBJLVfihZOQef+0NHIwbvNVUBAprmb0JB74s7nKxcxKw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a861e568-1b3a-40a4-b158-e543e2536464", "AQAAAAEAACcQAAAAEB7C6lwoBAv5p0Hq0rpBI8k7NXZT/gMtYm3pqZfJwLaVeK94h7CyQSaD594WQPw4IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d087172-e0db-4d97-b344-e36ed19a668c", "AQAAAAEAACcQAAAAECZMzWLVrPsLawQAWXQe38P7PcHptTFKstFxo/VYxgtx7UbTC651Iw5nkFbnYrHdfA==" });
        }
    }
}
