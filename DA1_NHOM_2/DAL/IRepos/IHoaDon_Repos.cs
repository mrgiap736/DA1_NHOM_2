using App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.IRepos
{
	public interface IHoaDon_Repos
	{
		public List<HoaDon> GetAll();
		public void Create(HoaDon hoaDon);
		public void Update(Guid a, int b, int c, int d);
		public HoaDon Get(Guid id);
        public List<HoaDon> SearchByNameKH(string name);
		public List<HoaDon> FilByTT(int tt);
    }
}
