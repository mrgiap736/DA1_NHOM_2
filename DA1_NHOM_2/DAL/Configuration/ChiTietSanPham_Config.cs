using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configuration
{
    internal class ChiTietSanPham_Config : IEntityTypeConfiguration<ChiTietSanPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietSanPham> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.HangSanXuat).WithMany(x => x.ChiTietSanPhams).HasForeignKey(x => x.MaHangSanXuat).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.ChiTietHoaDons).WithOne(x => x.ChiTietSanPham).HasForeignKey(x => x.MaChiTietSanPham).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.MauSac).WithMany(x => x.ChiTietSanPhams).HasForeignKey(x => x.MaMauSac).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ChatLieu).WithMany(x => x.ChiTietSanPhams).HasForeignKey(x => x.MaChatLieu).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.LoaiRen).WithMany(x => x.ChiTietSanPhams).HasForeignKey(x => x.MaLoaiRen).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
