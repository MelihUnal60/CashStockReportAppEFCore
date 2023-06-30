using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashStockReportApp.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Products_FK_Order_Details_Products",
                table: "Order_Details",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Details_Products_FK_Order_Details_Products",
                table: "Order_Details");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Details_Products",
                table: "Order_Details",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
