using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepos
{
    public interface ISanPham_Repos
    {
        public List<SanPham> GetAll();
		public bool AddSP(SanPham sp);
		public bool UpdateSP(SanPham sp);
		public bool RemoveSP(SanPham sp);
		public List<SanPham> SearchByName(string name);
		public List<SanPham> FilterByPrice(int index);
		public List<SanPham> FilterByTheFirm(int index);

    }
}
