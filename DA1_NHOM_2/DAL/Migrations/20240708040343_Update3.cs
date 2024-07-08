using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ChieuDai",
                table: "ChiTietSanPham",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CanNang",
                table: "ChiTietSanPham",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "MaLoaiRen",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "LoaiRen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiRen", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaLoaiRen",
                table: "ChiTietSanPham",
                column: "MaLoaiRen");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham",
                column: "MaLoaiRen",
                principalTable: "LoaiRen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "LoaiRen");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_MaLoaiRen",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "CanNang",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MaLoaiRen",
                table: "ChiTietSanPham");

            migrationBuilder.AlterColumn<int>(
                name: "ChieuDai",
                table: "ChiTietSanPham",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
