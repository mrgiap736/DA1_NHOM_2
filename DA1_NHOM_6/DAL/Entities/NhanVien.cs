using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public partial class NhanVien
{
    [Key]
    public Guid MaNhanVien { get; set; }

    public string TenNhanVien { get; set; } = null!;

    [Phone]
    public string SoDienThoai { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string ChucVu { get; set; } = null!;

    public string TaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
