using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefualt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data",
                table: "sales");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "sales",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "sales");

            migrationBuilder.AddColumn<string>(
                name: "data",
                table: "sales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
