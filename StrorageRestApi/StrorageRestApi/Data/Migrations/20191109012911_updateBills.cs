using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrorageRestApi.Migrations
{
    public partial class updateBills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail");

            migrationBuilder.DropIndex(
                name: "IX_BillDetail_ProductId",
                table: "BillDetail");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BillDetail",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "BillDetail",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Bill",
                newName: "Price");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "BillDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Bill",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BillDetail",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "BillDetail",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Bill",
                newName: "Amount");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "BillDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Bill",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ProductId",
                table: "BillDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
