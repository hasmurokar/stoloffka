using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class UpdateDishDocumentRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountDish",
                table: "DishDocumentRelations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountDish",
                table: "DishDocumentRelations");
        }
    }
}
