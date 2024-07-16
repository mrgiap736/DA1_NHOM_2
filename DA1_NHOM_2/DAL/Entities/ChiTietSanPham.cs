using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class ChiTietSanPham
    {
        public Guid Id { get; set; }

        public Guid MaSanPham {  get; set; }

        public int SoLuong { get; set; }

        public double ChieuDai { get; set; }

        public double CanNang {  get; set; }

        public int GiaBan { get; set; }

        public Guid MaLoaiRen { get; set; }

        public Guid? MaChatLieu { get; set; }

        public Guid MaMauSac { get; set; }

        public string TrangThai { get; set; }

        public byte[]? HinhAnh { get; set; } // Thêm thuộc tính HinhAnh

        public Guid MaHangSanXuat { get; set; }

        public HangSanXuat HangSanXuat { get; set; }

        public ChatLieu? ChatLieu { get; set; }

        public MauSac MauSac { get; set; }

        public LoaiRen LoaiRen { get; set; }

        public SanPham SanPham { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    }
}
