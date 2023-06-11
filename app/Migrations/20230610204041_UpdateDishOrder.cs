using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class UpdateDishOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishDishOrder");

            migrationBuilder.DropTable(
                name: "DishOrderOrder");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "CountDish",
                table: "DishOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "DishOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DishId1",
                table: "DishOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "DishOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_DishId",
                table: "DishOrders",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_DishId1",
                table: "DishOrders",
                column: "DishId1");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_OrderId",
                table: "DishOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_DishOrders_Dishes_DishId",
                table: "DishOrders",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DishOrders_Dishes_DishId1",
                table: "DishOrders",
                column: "DishId1",
                principalTable: "Dishes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DishOrders_Orders_OrderId",
                table: "DishOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishOrders_Dishes_DishId",
                table: "DishOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DishOrders_Dishes_DishId1",
                table: "DishOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DishOrders_Orders_OrderId",
                table: "DishOrders");

            migrationBuilder.DropIndex(
                name: "IX_DishOrders_DishId",
                table: "DishOrders");

            migrationBuilder.DropIndex(
                name: "IX_DishOrders_DishId1",
                table: "DishOrders");

            migrationBuilder.DropIndex(
                name: "IX_DishOrders_OrderId",
                table: "DishOrders");

            migrationBuilder.DropColumn(
                name: "CountDish",
                table: "DishOrders");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "DishOrders");

            migrationBuilder.DropColumn(
                name: "DishId1",
                table: "DishOrders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "DishOrders");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DishDishOrder",
                columns: table => new
                {
                    DishOrdersId = table.Column<int>(type: "int", nullable: false),
                    DishesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDishOrder", x => new { x.DishOrdersId, x.DishesId });
                    table.ForeignKey(
                        name: "FK_DishDishOrder_Dishes_DishesId",
                        column: x => x.DishesId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishDishOrder_DishOrders_DishOrdersId",
                        column: x => x.DishOrdersId,
                        principalTable: "DishOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishOrderOrder",
                columns: table => new
                {
                    DishOrdersId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrderOrder", x => new { x.DishOrdersId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_DishOrderOrder_DishOrders_DishOrdersId",
                        column: x => x.DishOrdersId,
                        principalTable: "DishOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishOrderOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishDishOrder_DishesId",
                table: "DishDishOrder",
                column: "DishesId");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrderOrder_OrdersId",
                table: "DishOrderOrder",
                column: "OrdersId");
        }
    }
}
