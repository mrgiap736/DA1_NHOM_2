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
    public class SanPham_Config : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(x => x.MaSanPham);
            builder.HasMany(x => x.ChiTietSanPhams).WithOne(x => x.SanPham).HasForeignKey(x => x.MaSanPham);
           
            builder.HasIndex(x => x.TenSanPham).IsUnique();

          
        }
    }
}
