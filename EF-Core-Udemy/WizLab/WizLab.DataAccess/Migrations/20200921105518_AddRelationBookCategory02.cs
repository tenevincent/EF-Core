using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class AddRelationBookCategory02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tb_Category_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Category_Id",
                table: "Books",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_tb_Category_Category_Id",
                table: "Books",
                column: "Category_Id",
                principalTable: "tb_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tb_Category_Category_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Category_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_tb_Category_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "tb_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
