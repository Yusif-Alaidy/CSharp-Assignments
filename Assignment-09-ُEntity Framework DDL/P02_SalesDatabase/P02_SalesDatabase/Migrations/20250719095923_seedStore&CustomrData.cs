using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class seedStoreCustomrData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "CustomerId", "Email", "Name", "PhoneNumber" },
                values: new object[] { 1, "no Email", "no name", "0123456789" });

            migrationBuilder.InsertData(
                table: "strores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 1, "no name" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "strores",
                keyColumn: "StoreId",
                keyValue: 1);
        }
    }
}
