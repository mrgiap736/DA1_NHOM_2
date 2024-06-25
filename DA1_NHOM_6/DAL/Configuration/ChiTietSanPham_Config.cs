using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class ChiTietSanPham_Config : IEntityTypeConfiguration<ChiTietSanPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietSanPham> builder)
        {
            builder.HasKey(x => x.MaSanPham);
            builder.HasOne(x => x.SanPham).WithOne(x => x.ChiTietSanPham).HasForeignKey<ChiTietSanPham>(x => x.MaSanPham);
        }
    }
}
