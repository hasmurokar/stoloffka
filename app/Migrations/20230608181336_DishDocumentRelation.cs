using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class DishDocumentRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Documents");

            migrationBuilder.CreateTable(
                name: "DishDocumentRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    DocumentDishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDocumentRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishDocumentRelations_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishDocumentRelations_Documents_DocumentDishId",
                        column: x => x.DocumentDishId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishDocumentRelations_DishId",
                table: "DishDocumentRelations",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishDocumentRelations_DocumentDishId",
                table: "DishDocumentRelations",
                column: "DocumentDishId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishDocumentRelations");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Documents",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
