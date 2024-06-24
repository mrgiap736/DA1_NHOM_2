using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class HoaDon
{
    [Key]
    public Guid MaHoaDon { get; set; }

    public DateTime NgayMua { get; set; }

    public int TongTien { get; set; }

    public int TienKhachTra { get; set; }

    public int? GiamGia { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? KhachHang { get; set; }

    public virtual NhanVien? NhanVien { get; set; }
}
