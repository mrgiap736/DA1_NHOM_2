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

        public string LoaiSanPham { get; set; }

        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }

            
    }
}


