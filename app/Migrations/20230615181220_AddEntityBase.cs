using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class AddEntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "Users",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "Orders",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "Ingredients",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "IngredientKinds",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "Documents",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "DishOrders",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "Dishes",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "State",
                table: "DishDocumentRelations",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "State",
                table: "IngredientKinds");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "State",
                table: "DishOrders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "State",
                table: "DishDocumentRelations");
        }
    }
}
