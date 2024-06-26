using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entities
{
    public class SanPham
    {
        [Key]
        public Guid MaSanPham { get; set; }

        public string TenSanPham { get; set; } = null!;

        public int SoLuong { get; set; }

        public int GiaBan { get; set; }

        public int TrangThai { get; set; }

        public byte[]? HinhAnh { get; set; } // Thêm thuộc tính HinhAnh
        public ChiTietSanPham ChiTietSanPham { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }
        public HangSanXuat HangSanXuat { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}


