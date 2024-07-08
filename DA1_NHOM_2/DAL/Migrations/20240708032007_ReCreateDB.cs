using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReCreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_HangSanXuat_MaHangSanXuat",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_MaLoaiSanPham",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaHangSanXuat",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "ChatLieu",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "ChieuDai",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "GiaBan",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaHangSanXuat",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaLoaiSanPham",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MauSac",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "SanPham");

            migrationBuilder.AddColumn<string>(
                name: "LoaiSanPham",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChieuDai = table.Column<int>(type: "int", nullable: true),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    ChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MauSac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MaHangSanXuat = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_HangSanXuat_MaHangSanXuat",
                        column: x => x.MaHangSanXuat,
                        principalTable: "HangSanXuat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_SanPham_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                column: "ChiTietSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaHangSanXuat",
                table: "ChiTietSanPham",
                column: "MaHangSanXuat");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaSanPham",
                table: "ChiTietSanPham",
                column: "MaSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                column: "ChiTietSanPhamId",
                principalTable: "ChiTietSanPham",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "LoaiSanPham",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.AddColumn<string>(
                name: "ChatLieu",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChieuDai",
                table: "SanPham",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GiaBan",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "HinhAnh",
                table: "SanPham",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MaHangSanXuat",
                table: "SanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MaLoaiSanPham",
                table: "SanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MauSac",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaHangSanXuat",
                table: "SanPham",
                column: "MaHangSanXuat");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_HangSanXuat_MaHangSanXuat",
                table: "SanPham",
                column: "MaHangSanXuat",
                principalTable: "HangSanXuat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham",
                principalTable: "LoaiSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
