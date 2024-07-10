using App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.IRepos
{
    public interface ISanPham_Repos
    {
        public List<ChiTietSanPham> GetAll();
		public bool AddSP(SanPham sp);
		public bool UpdateSP(SanPham sp);
		public bool RemoveSP(SanPham sp);
		public List<ChiTietSanPham> SearchByName(string name);
		public List<ChiTietSanPham> FilterByPrice(int index);
		public List<ChiTietSanPham> FilterByTheFirm(int index);

    }
}
