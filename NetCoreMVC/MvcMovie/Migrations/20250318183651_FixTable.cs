using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class FixTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Daily",
                table: "Daily");

            migrationBuilder.RenameTable(
                name: "Daily",
                newName: "DaiLy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy",
                column: "MaDaiLy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy");

            migrationBuilder.RenameTable(
                name: "DaiLy",
                newName: "Daily");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Daily",
                table: "Daily",
                column: "MaDaiLy");
        }
    }
}
