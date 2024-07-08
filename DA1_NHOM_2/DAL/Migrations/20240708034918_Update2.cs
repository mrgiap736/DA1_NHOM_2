using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "ChatLieuId",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "MauSacId",
                table: "ChiTietSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaChatLieu",
                table: "ChiTietSanPham",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaMauSac",
                table: "ChiTietSanPham",
                column: "MaMauSac");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham",
                column: "MaChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham",
                column: "MaMauSac",
                principalTable: "MauSac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_MauSac_MaMauSac",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_MaChatLieu",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_MaMauSac",
                table: "ChiTietSanPham");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatLieuId",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MauSacId",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_ChatLieuId",
                table: "ChiTietSanPham",
                column: "ChatLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MauSacId",
                table: "ChiTietSanPham",
                column: "MauSacId");

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
    }
}
