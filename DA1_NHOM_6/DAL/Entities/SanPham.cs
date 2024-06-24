using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class SanPham
{
    [Key]
    public Guid MaSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string HangSanXuat { get; set; } = null!;

    public string? ThongSoKyThuat { get; set; } //Sửa

    public int  SoLuong { get; set; }

    public int GiaBan { get; set; }

    public int TrangThai { get; set; }

    public byte[]? HinhAnh { get; set; } // Thêm thuộc tính HinhAnh

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
