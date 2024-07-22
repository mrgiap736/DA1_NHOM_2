using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entities
{
    public class KhachHang
    {
        [Key]
        public Guid MaKhachHang { get; set; }

        public string TenKhachHang { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string SoDienThoai { get; set; } = null!;

        public int? TichLuy { get; set; } //Sửa 

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }

}

