using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderItemDetailAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemToppings",
                columns: table => new
                {
                    ToppingNumber = table.Column<int>(type: "int", nullable: false),
                    ItemNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemToppings", x => new { x.ItemNumber, x.ToppingNumber });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemToppings");
        }
    }
}
