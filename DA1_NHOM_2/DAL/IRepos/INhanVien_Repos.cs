using App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.IRepos
{
    public interface INhanVien_Repos
    {
        public List<NhanVien> GetAll();
        public bool AddNV(NhanVien nv);
        public bool UpdateNV(NhanVien nv);
        public bool RemoveNV(NhanVien nv);
    }
}
