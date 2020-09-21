using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class NameRenamingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");
        }
    }
}
