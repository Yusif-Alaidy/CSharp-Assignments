using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "products",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1, "no description", "no name", 0m, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "products");
        }
    }
}
