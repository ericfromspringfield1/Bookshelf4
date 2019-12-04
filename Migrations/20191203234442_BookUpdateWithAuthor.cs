using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf4.Migrations
{
    public partial class BookUpdateWithAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_OwnerId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreatedId",
                table: "Author",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8338e36c-10eb-45ae-8d81-3339a5d892b0", "AQAAAAEAACcQAAAAEENHdX9Br7e34KwNIwQARREgj2UwL4QsZLawxEi19K3UlWuTmX6HdZ2ZvZbCIBCABg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6be05ec4-86ff-458a-a313-59cdeff93b43", "AQAAAAEAACcQAAAAENuZTnvLY+mXFEKi+SuogEdZlf0TSpq/jMdjA2LpoR9x0NX+BTWrNje3MN6TKBI2SA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Author_UserCreatedId",
                table: "Author",
                column: "UserCreatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_AspNetUsers_UserCreatedId",
                table: "Author",
                column: "UserCreatedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_AspNetUsers_OwnerId",
                table: "Book",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_AspNetUsers_UserCreatedId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_OwnerId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Author_UserCreatedId",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "UserCreatedId",
                table: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Book",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d429b41-fa2c-4beb-bcdb-2c364b0bf773", "AQAAAAEAACcQAAAAEGtMDKssLqEUHMbS8Pe8Gt59QMWhfc7an+iOp+w4kiJ4FWcnr7ereLzKwpPxy3pNyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffffg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10bca340-f713-42b6-b871-57e4ef2b8bef", "AQAAAAEAACcQAAAAECUYBVOkN9YL/gCLxEeSZEoh6HBSc+jMgjIffb9kWwUp61TMl+wqjjWMShQu74SY9g==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_AspNetUsers_OwnerId",
                table: "Book",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
