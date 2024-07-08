using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_SanPham_SanPhamMaSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_SanPhamMaSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "ChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MauSac",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "ChiTietSanPhamId",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "SanPhamMaSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.RenameColumn(
                name: "MaSanPham",
                table: "ChiTietHoaDon",
                newName: "MaChiTietSanPham");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatLieuId",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MaChatLieu",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MaMauSac",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MauSacId",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_ChatLieuId",
                table: "ChiTietSanPham",
                column: "ChatLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MauSacId",
                table: "ChiTietSanPham",
                column: "MauSacId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaChiTietSanPham",
                table: "ChiTietHoaDon",
                column: "MaChiTietSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon",
                column: "MaChiTietSanPham",
                principalTable: "ChiTietSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_ChatLieuId",
                table: "ChiTietSanPham",
                column: "ChatLieuId",
                principalTable: "ChatLieu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MauSacId",
                table: "ChiTietSanPham",
                column: "MauSacId",
                principalTable: "MauSac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_MaChiTietSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MaChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MaMauSac",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.RenameColumn(
                name: "MaChiTietSanPham",
                table: "ChiTietHoaDon",
                newName: "MaSanPham");

            migrationBuilder.AddColumn<string>(
                name: "ChatLieu",
                table: "ChiTietSanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MauSac",
                table: "ChiTietSanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamMaSanPham",
                table: "ChiTietHoaDon",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                column: "ChiTietSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_SanPhamMaSanPham",
                table: "ChiTietHoaDon",
                column: "SanPhamMaSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_ChiTietSanPhamId",
                table: "ChiTietHoaDon",
                column: "ChiTietSanPhamId",
                principalTable: "ChiTietSanPham",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_SanPham_SanPhamMaSanPham",
                table: "ChiTietHoaDon",
                column: "SanPhamMaSanPham",
                principalTable: "SanPham",
                principalColumn: "MaSanPham");
        }
    }
}
