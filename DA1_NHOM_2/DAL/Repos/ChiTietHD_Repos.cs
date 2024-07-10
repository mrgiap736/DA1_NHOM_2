using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using A_DAL.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
	public class ChiTietHD_Repos : IChiTietHD_Repos
	{
		SqlTheCtzContext context;

        public ChiTietHD_Repos()
        {
			context = new SqlTheCtzContext();	
        }
        public void Create(ChiTietHoaDon cthd)
		{
			context.ChiTietHoaDons.Add(cthd);
			context.SaveChanges();
			return;
		}

        public void Delete(ChiTietHoaDon cthd)
        {
            context.ChiTietHoaDons.Remove(cthd);
			context.SaveChanges();
			return;
        }

        public List<ChiTietHoaDon> GetAll(int mahd)
		{
			return context.ChiTietHoaDons.Include("MaSanPhamNavigation").Where(x => x.MaHoaDon.Equals(mahd)).ToList();
		}

        public void Update(ChiTietHoaDon cthd)
        {
			context.ChiTietHoaDons.Update(cthd);
			context.SaveChanges();
			return; 
        }

    }
}
