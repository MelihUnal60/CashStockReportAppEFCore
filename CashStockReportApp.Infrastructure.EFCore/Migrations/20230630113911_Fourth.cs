using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashStockReportApp.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Products_FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.DropIndex(
                name: "IX_Order_Details_FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.DropColumn(
                name: "FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_ProductId",
                table: "Order_Details",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Products",
                table: "Order_Details",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.DropIndex(
                name: "IX_Order_Details_ProductId",
                table: "Order_Details");

            migrationBuilder.AddColumn<int>(
                name: "FK_Order_Details_Products",
                table: "Order_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_Details_FK_Order_Details_Products",
                table: "Order_Details",
                column: "FK_Order_Details_Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Products_FK_Order_Details_Products",
                table: "Order_Details",
                column: "FK_Order_Details_Products",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
