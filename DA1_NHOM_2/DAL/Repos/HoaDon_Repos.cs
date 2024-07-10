using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
	public class HoaDon_Repos : IHoaDon_Repos
	{
		SqlTheCtzContext context;

        public HoaDon_Repos()
        {
			context = new SqlTheCtzContext();
        }
        public void Create(HoaDon hoaDon)
		{
			context.HoaDons.Add(hoaDon);
			context.SaveChanges();
			return;
		}

        public List<HoaDon> FilByTT(int tt)
        {
			return context.HoaDons.Where(x => x.TrangThai.Equals(tt)).ToList();
        }

        public HoaDon Get(int id)
        {
			return context.HoaDons.SingleOrDefault(x => x.MaHoaDon.Equals(id));
        }

        public List<HoaDon> GetAll()
		{
			return context.HoaDons.Include("MaKhachHangNavigation").Include("MaNhanVienNavigation").ToList();
		}

		public List<HoaDon> SearchByNameKH (string name)
		{
			return context.HoaDons.Where(x => x.MaKhachHangNavigation.TenKhachHang.ToLower().Contains(name.Trim().ToLower())).ToList();
		}

		public void Update(int a, int b, int c, int d)
		{
			var hoadonUp = context.HoaDons.Find(a);

			hoadonUp.TienKhachTra = b;
			hoadonUp.GiamGia = c;
			hoadonUp.TongTien = d;
			hoadonUp.TrangThai = 1;

			context.HoaDons.Update(hoadonUp);
			context.SaveChanges();
			return;
		}
	}
}
