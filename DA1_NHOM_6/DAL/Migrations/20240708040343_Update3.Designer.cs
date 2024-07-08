﻿// <auto-generated />
using System;
using App.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240708040343_Update3")]
    partial class Update3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Data.Entities.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("App.Data.Entities.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("MaChiTietHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<Guid>("MaChiTietSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietHoaDon");

                    b.HasIndex("MaChiTietSanPham");

                    b.HasIndex("MaHoaDon");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("App.Data.Entities.ChiTietSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CanNang")
                        .HasColumnType("float");

                    b.Property<double>("ChieuDai")
                        .HasColumnType("float");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("MaChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHangSanXuat")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaLoaiRen")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaChatLieu");

                    b.HasIndex("MaHangSanXuat");

                    b.HasIndex("MaLoaiRen");

                    b.HasIndex("MaMauSac");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietSanPham");
                });

            modelBuilder.Entity("App.Data.Entities.HangSanXuat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangSanXuat");
                });

            modelBuilder.Entity("App.Data.Entities.HoaDon", b =>
                {
                    b.Property<Guid>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("GiamGia")
                        .HasColumnType("int");

                    b.Property<Guid>("MaKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("datetime2");

                    b.Property<int>("TienKhachTra")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("App.Data.Entities.KhachHang", b =>
                {
                    b.Property<Guid>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TichLuy")
                        .HasColumnType("int");

                    b.HasKey("MaKhachHang");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SoDienThoai")
                        .IsUnique();

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("App.Data.Entities.LoaiRen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiRen");
                });

            modelBuilder.Entity("App.Data.Entities.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("App.Data.Entities.NhanVien", b =>
                {
                    b.Property<Guid>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SoDienThoai")
                        .IsUnique();

                    b.HasIndex("TaiKhoan")
                        .IsUnique();

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("App.Data.Entities.SanPham", b =>
                {
                    b.Property<Guid>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaSanPham");

                    b.HasIndex("TenSanPham")
                        .IsUnique();

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("App.Data.Entities.ChiTietHoaDon", b =>
                {
                    b.HasOne("App.Data.Entities.ChiTietSanPham", "ChiTietSanPham")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaChiTietSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSanPham");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("App.Data.Entities.ChiTietSanPham", b =>
                {
                    b.HasOne("App.Data.Entities.ChatLieu", "ChatLieu")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("MaChatLieu");

                    b.HasOne("App.Data.Entities.HangSanXuat", "HangSanXuat")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("MaHangSanXuat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.LoaiRen", "LoaiRen")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("MaLoaiRen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.MauSac", "MauSac")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("MaMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.SanPham", "SanPham")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("MaSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("HangSanXuat");

                    b.Navigation("LoaiRen");

                    b.Navigation("MauSac");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("App.Data.Entities.HoaDon", b =>
                {
                    b.HasOne("App.Data.Entities.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Data.Entities.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("App.Data.Entities.ChatLieu", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("App.Data.Entities.ChiTietSanPham", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("App.Data.Entities.HangSanXuat", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("App.Data.Entities.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("App.Data.Entities.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("App.Data.Entities.LoaiRen", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("App.Data.Entities.MauSac", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("App.Data.Entities.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("App.Data.Entities.SanPham", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
