using App.Data.Entities;
using App.Data.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
    public class BanHang_Services
    {
        SanPham_Repos sprp;
        KhachHang_Repos khrp;

        public BanHang_Services()
        {
            sprp = new SanPham_Repos();
            khrp = new KhachHang_Repos();
        }

        public List<ChiTietSanPham> GetAllSanPham()
        {
            return sprp.GetAll();
        }

        public List<ChiTietSanPham> GetSPByName(string name)
        {
            return sprp.SearchByName(name);
        }

        public List<ChiTietSanPham> GetSPByPrice(int index)
        {
            return sprp.FilterByPrice(index);
        }
        public List<ChiTietSanPham> GetSPByFirm(int index)
        {
            return sprp.LocTheoHang(index);
        }public List<ChiTietSanPham> LocALL(string searchText, int filter1Index, int filter2Index)
        {
            return sprp.GetFilteredData( searchText,  filter1Index,  filter2Index);
        }

        public KhachHang GetKhachHang(string phone)
        {
            return khrp.SearchByPhone(phone);
        }

    }
}
