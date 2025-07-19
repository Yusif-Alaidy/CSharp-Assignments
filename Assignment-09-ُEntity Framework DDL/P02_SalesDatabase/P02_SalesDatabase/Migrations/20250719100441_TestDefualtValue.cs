using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class TestDefualtValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "strores",
                keyColumn: "StoreId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "StoreId" },
                values: new object[] { 1, 1, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sales",
                keyColumn: "SaleId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "strores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 2, "no name" });
        }
    }
}
