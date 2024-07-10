using App.Data.Data;
using App.Data.Entities;
using App.Data.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
    public class KhachHang_Repos : IKhachHang_Repos
    {
        AppDBContext context;
        public KhachHang_Repos()
        {
            context = new AppDBContext();
        }
        public bool AddKH(KhachHang kh)
        {
            context.Add(kh);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return context.KhachHang.ToList();
        }

        public bool RemoveKH(KhachHang kh)
        {
            List<HoaDon> _lsthd = context.HoaDon.Where(x => x.MaKhachHang == kh.MaKhachHang).ToList();


            if(_lsthd != null)
            {
                foreach (var item in _lsthd)
                {
                    foreach (var item2 in context.ChiTietHoaDon.Where(x => x.MaHoaDon == item.MaHoaDon))
                    {
                        context.ChiTietHoaDon.Remove(item2);
                    }
                    context.HoaDon.Remove(item);
                    context.SaveChanges();
                }
                context.Remove(kh);
                context.SaveChanges();
            }
            else
            {
                context.Remove(kh);
                context.SaveChanges();
            }         
            return true;
        }

        public KhachHang SearchByName(string name)
        {
            return context.KhachHang.FirstOrDefault(x => x.TenKhachHang.Trim().ToLower().Contains(name.ToLower().Trim()));
        }

        public KhachHang SearchByPhone(string phone)
        {
            return context.KhachHang.FirstOrDefault(x => x.SoDienThoai == phone);
        }

        public bool UpdateKH(KhachHang kh)
        {
            context.Update(kh);
            context.SaveChanges();
            return true;
        }
    }
}
