using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ChiTietHoaDon
{
    public int MaChiTietHoaDon { get; set; }

    public int? MaHoaDon { get; set; }

    public string? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public int DonGia { get; set; }

    public virtual HoaDon? HoaDon { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
