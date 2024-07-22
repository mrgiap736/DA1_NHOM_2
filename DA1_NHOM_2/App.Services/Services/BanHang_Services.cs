using App.Data.Entities;
using App.Data.Repos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Services.Services
{
    public class BanHang_Services
    {
        SanPham_Repos sprp;
        KhachHang_Repos khrp;
        HoaDon_Repos hdrp;
        ChiTietHD_Repos cthdrp;
        SanPham_Services spsv;

        public BanHang_Services()
        {
            sprp = new SanPham_Repos();
            khrp = new KhachHang_Repos();
            hdrp = new HoaDon_Repos();
            cthdrp = new ChiTietHD_Repos();
            spsv = new SanPham_Services();
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

        //Hàm update số lượng sản phẩm (được gọi sau khi thanh toán)
        public void UpdateSoLuongSP(Guid mahd)
        {
            List<ChiTietHoaDon> lstCTHD = cthdrp.GetAll(mahd);

            foreach (var item in lstCTHD)
            {
                int soluongSP = item.ChiTietSanPham.SoLuong;
                int soluongtru = item.SoLuong;

                //Cập nhật số lượng mới 
                item.ChiTietSanPham.SoLuong = soluongSP - soluongtru;

                spsv.Update(item.ChiTietSanPham);
            }
        }

        
        //Hàm chuyển số ngăn cách phần nghìn 
        public string AddThousandSeparators(int number)
        {
            // Chuyển đổi số sang chuỗi và sử dụng phương thức Format để thêm dấu chấm ngăn cách
            string formattedNumber = string.Format("{0:N0}", number);

            return formattedNumber;
        }

    }
}
