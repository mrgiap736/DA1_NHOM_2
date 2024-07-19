using App.Data.Data;
using App.Data.Entities;
using App.Data.IRepos;
using App.Data.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
	public class ChiTietHD_Repos : IChiTietHD_Repos
	{
		AppDBContext context;

        public ChiTietHD_Repos()
        {
			context = new AppDBContext();	
        }
        public void Create(ChiTietHoaDon cthd)
		{
			context.ChiTietHoaDon.Add(cthd);
			context.SaveChanges();
			return;
		}

        public void Delete(ChiTietHoaDon cthd)
        {
            context.ChiTietHoaDon.Remove(cthd);
			context.SaveChanges();
			return;
        }

        public List<ChiTietHoaDon> GetAll(Guid mahd)
		{
			return context.ChiTietHoaDon.Include(x => x.ChiTietSanPham.SanPham).Where(x => x.MaHoaDon.Equals(mahd)).ToList();
		}

        public void Update(ChiTietHoaDon cthd)
        {
			context.ChiTietHoaDon.Update(cthd);
			context.SaveChanges();
			return; 
        }

    }
}
