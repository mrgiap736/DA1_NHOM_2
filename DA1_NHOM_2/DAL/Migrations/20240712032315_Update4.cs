using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "SanPham");

            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "ChiTietSanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "ChiTietSanPham");

            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
