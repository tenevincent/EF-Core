using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class RemoveDisplayOrderColumnMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Genres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
