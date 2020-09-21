using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class GenreName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");

           // migrationBuilder.Sql("UPDATE dbo.genre SET GenreName=Name");

            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");
        }
    }
}
