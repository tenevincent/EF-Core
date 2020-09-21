using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab.DataAccess.Migrations
{
    public partial class ManyToManyBetweenBookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.Author_Id, x.Book_Id });
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_Book_Id",
                table: "BookAuthor",
                column: "Book_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");
        }
    }
}
