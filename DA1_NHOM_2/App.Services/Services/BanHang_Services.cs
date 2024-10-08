﻿using App.Data.Entities;
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
        ChiTietHD_Repos cthdrp;
        SanPham_Services _spsv;

        public BanHang_Services()
        {
            sprp = new SanPham_Repos();
            khrp = new KhachHang_Repos();
            cthdrp = new ChiTietHD_Repos();
            _spsv = new SanPham_Services();
        }

        public List<ChiTietSanPham> GetAllSanPham()
        {
            return _spsv.GetAll();
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
        public void UpdateCTSP(ChiTietSanPham ctsp)
        {
            _spsv.Update(ctsp);
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
