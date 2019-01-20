using Microsoft.EntityFrameworkCore.Migrations;

namespace MyECommerce.WebUI.Migrations
{
    public partial class AddInitialOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "OrderAddressHeader",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderAddressRow",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderCity",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderNeighborhood",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderState",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrderTelephone",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderUserName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderAddressHeader",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderAddressRow",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderNeighborhood",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderState",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTelephone",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderUserName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
