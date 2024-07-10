using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
    public class KhachHang_Repos : IKhachHang_Repos
    {
        SqlTheCtzContext context;
        public KhachHang_Repos()
        {
            context = new SqlTheCtzContext();
        }
        public bool AddKH(KhachHang kh)
        {
            context.Add(kh);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }

        public bool RemoveKH(KhachHang kh)
        {
            List<HoaDon> _lsthd = context.HoaDons.Where(x => x.MaKhachHang == kh.MaKhachHang).ToList();


            if(_lsthd != null)
            {
                foreach (var item in _lsthd)
                {
                    foreach (var item2 in context.ChiTietHoaDons.Where(x => x.MaHoaDon == item.MaHoaDon))
                    {
                        context.ChiTietHoaDons.Remove(item2);
                    }
                    context.HoaDons.Remove(item);
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
            return context.KhachHangs.FirstOrDefault(x => x.TenKhachHang.Trim().ToLower().Contains(name.ToLower().Trim()));
        }

        public KhachHang SearchByPhone(string phone)
        {
            return context.KhachHangs.FirstOrDefault(x => x.SoDienThoai == phone);
        }

        public bool UpdateKH(KhachHang kh)
        {
            context.Update(kh);
            context.SaveChanges();
            return true;
        }
    }
}
