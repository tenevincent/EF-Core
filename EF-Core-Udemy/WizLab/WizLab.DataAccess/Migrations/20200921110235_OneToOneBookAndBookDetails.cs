using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class OneToOneBookAndBookDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tb_Category_Category_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Category_Id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Books",
                newName: "BookDetail_Id");

            migrationBuilder.CreateTable(
                name: "tb_BookDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfChapters = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_BookDetail", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetail_Id",
                table: "Books",
                column: "BookDetail_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_tb_BookDetail_BookDetail_Id",
                table: "Books",
                column: "BookDetail_Id",
                principalTable: "tb_BookDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tb_BookDetail_BookDetail_Id",
                table: "Books");

            migrationBuilder.DropTable(
                name: "tb_BookDetail");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetail_Id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookDetail_Id",
                table: "Books",
                newName: "Category_Id");

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
    }
}
