using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileAPI.Migrations
{
    public partial class UpdateNameTblProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountInStocl",
                table: "Products",
                newName: "CountInStock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountInStock",
                table: "Products",
                newName: "CountInStocl");
        }
    }
}
