using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCTSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_HangSanXuat_MaHangSanXuat",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaMauSac",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaLoaiRen",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaHangSanXuat",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon",
                column: "MaChiTietSanPham",
                principalTable: "ChiTietSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham",
                column: "MaChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_HangSanXuat_MaHangSanXuat",
                table: "ChiTietSanPham",
                column: "MaHangSanXuat",
                principalTable: "HangSanXuat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham",
                column: "MaLoaiRen",
                principalTable: "LoaiRen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham",
                column: "MaMauSac",
                principalTable: "MauSac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_HangSanXuat_MaHangSanXuat",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaMauSac",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MaLoaiRen",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MaHangSanXuat",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_MaChiTietSanPham",
                table: "ChiTietHoaDon",
                column: "MaChiTietSanPham",
                principalTable: "ChiTietSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham",
                column: "MaChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_HangSanXuat_MaHangSanXuat",
                table: "ChiTietSanPham",
                column: "MaHangSanXuat",
                principalTable: "HangSanXuat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiRen_MaLoaiRen",
                table: "ChiTietSanPham",
                column: "MaLoaiRen",
                principalTable: "LoaiRen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham",
                column: "MaMauSac",
                principalTable: "MauSac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
