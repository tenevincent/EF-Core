using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class DataAnnotationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "tb_Genre");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tb_Category");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_Genre",
                newName: "GenreName");

            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "tb_Genre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Genre",
                table: "tb_Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Category",
                table: "tb_Category",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Genre",
                table: "tb_Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Category",
                table: "tb_Category");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "tb_Genre");

            migrationBuilder.RenameTable(
                name: "tb_Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "tb_Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
