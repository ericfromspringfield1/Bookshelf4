using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf4.Migrations
{
    public partial class booksAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfa849ba-c206-4fd4-8655-7d6742edac2b", "AQAAAAEAACcQAAAAEOfeKGJrn/ND6DTZORBVcMyIORXV1F2cfdM1v6dCd+Fc/FQ4PL9hTObPkbeK3ggLqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f073aa00-3e9a-4b66-8fe9-9cb577377092", "AQAAAAEAACcQAAAAEMv7N3KLnWIVsFDA/OnZ0uhPR73FWyh9vilON9lxc/eDp79A8nkGbzM/2Wo4p31czw==" });
        }
    }
}
