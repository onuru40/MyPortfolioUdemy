using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioUdemy.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDoListID",
                table: "ToDoLists",
                newName: "ToDoListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDoListId",
                table: "ToDoLists",
                newName: "ToDoListID");
        }
    }
}
