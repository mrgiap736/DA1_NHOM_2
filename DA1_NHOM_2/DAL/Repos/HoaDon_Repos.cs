using App.Data.Data;
using App.Data.Entities;
using App.Data.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
	public class HoaDon_Repos : IHoaDon_Repos
	{
		AppDBContext context;

        public HoaDon_Repos()
        {
			context = new AppDBContext();
        }
        public void Create(HoaDon hoaDon)
		{
			context.HoaDon.Add(hoaDon);
			context.SaveChanges();
			return;
		}

        public List<HoaDon> FilByTT(int tt)
        {
			return context.HoaDon.Where(x => x.TrangThai.Equals(tt)).ToList();
        }

        public HoaDon Get(int id)
        {
			return context.HoaDon.SingleOrDefault(x => x.MaHoaDon.Equals(id));
        }

        public List<HoaDon> GetAll()
		{
			return context.HoaDon.Include(x => x.KhachHang).Include(x => x.NhanVien).ToList();
		}

		public List<HoaDon> SearchByNameKH (string name)
		{
			return context.HoaDon.Where(x => x.KhachHang.TenKhachHang.ToLower().Contains(name.Trim().ToLower())).ToList();
		}

		public void Update(int a, int b, int c, int d)
		{
			var hoadonUp = context.HoaDon.Find(a);

			hoadonUp.TienKhachTra = b;
			hoadonUp.GiamGia = c;
			hoadonUp.TongTien = d;
			hoadonUp.TrangThai = 1;

			context.HoaDon.Update(hoadonUp);
			context.SaveChanges();
			return;
		}
	}
}
