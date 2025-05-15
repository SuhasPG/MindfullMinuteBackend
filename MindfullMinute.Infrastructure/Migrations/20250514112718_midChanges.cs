using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MindfullMinute.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class midChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JounralEntries_AspNetUsers_UserId",
                table: "JounralEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JounralEntries",
                table: "JounralEntries");

            migrationBuilder.RenameTable(
                name: "JounralEntries",
                newName: "JournalEntries");

            migrationBuilder.RenameIndex(
                name: "IX_JounralEntries_UserId",
                table: "JournalEntries",
                newName: "IX_JournalEntries_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JournalEntries",
                table: "JournalEntries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntries_AspNetUsers_UserId",
                table: "JournalEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntries_AspNetUsers_UserId",
                table: "JournalEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JournalEntries",
                table: "JournalEntries");

            migrationBuilder.RenameTable(
                name: "JournalEntries",
                newName: "JounralEntries");

            migrationBuilder.RenameIndex(
                name: "IX_JournalEntries_UserId",
                table: "JounralEntries",
                newName: "IX_JounralEntries_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JounralEntries",
                table: "JounralEntries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JounralEntries_AspNetUsers_UserId",
                table: "JounralEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
