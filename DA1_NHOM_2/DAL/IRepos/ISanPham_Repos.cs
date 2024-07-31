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
		public List<SanPham> GetAllSP();
		public bool AddSP(SanPham sp);
		public bool AddCTSP(ChiTietSanPham ctsp);
		public bool UpdateCTSP(ChiTietSanPham sp);
		public bool RemoveCTSP(ChiTietSanPham ctsp);
		public List<ChiTietSanPham> SearchByName(string name);
		public List<ChiTietSanPham> FilterByPrice(int index);
		public List<ChiTietSanPham> FilterByTheFirm(int index);

		public List<T> GetAllThanhPhan<T>() where T : class;

		public void CreateEntity<T>(T entity) where T : class;

		public void DeleteEntity<T>(Guid id) where T : class;

    }
}
