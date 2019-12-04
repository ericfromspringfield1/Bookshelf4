using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf4.Migrations
{
    public partial class BookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_AspNetUsers_UserId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_OwnerId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_Books_OwnerId",
                table: "Book",
                newName: "IX_Book_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Book",
                newName: "IX_Book_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_UserId",
                table: "Author",
                newName: "IX_Author_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

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
                name: "FK_Author_AspNetUsers_UserId",
                table: "Author",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
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
                name: "FK_Author_AspNetUsers_UserId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_OwnerId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_Book_OwnerId",
                table: "Books",
                newName: "IX_Books_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Author_UserId",
                table: "Authors",
                newName: "IX_Authors_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_AspNetUsers_UserId",
                table: "Authors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_OwnerId",
                table: "Books",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
