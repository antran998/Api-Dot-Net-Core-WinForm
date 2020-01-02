using Microsoft.EntityFrameworkCore.Migrations;

namespace StrorageRestApi.Migrations
{
    public partial class fixText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Product_ProductNameId",
                table: "BillDetail");

            migrationBuilder.RenameColumn(
                name: "ProductNameId",
                table: "BillDetail",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetail_ProductNameId",
                table: "BillDetail",
                newName: "IX_BillDetail_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BillDetail",
                newName: "ProductNameId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetail_ProductId",
                table: "BillDetail",
                newName: "IX_BillDetail_ProductNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Product_ProductNameId",
                table: "BillDetail",
                column: "ProductNameId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
