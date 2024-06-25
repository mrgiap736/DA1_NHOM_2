using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ChiTietSanPham
    {
        [Key,ForeignKey("MaSanPham")]
        public Guid MaSanPham {  get; set; }
        public int? ChieuDai { get; set; }
        public string? ChatLieu { get; set; }
        public string? MauSac {  get; set; }
        public SanPham SanPham { get; set; }

    }
}
