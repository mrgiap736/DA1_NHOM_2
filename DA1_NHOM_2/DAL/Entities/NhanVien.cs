using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entities
{
    public class NhanVien
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

        public string TrangThai {  get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}


