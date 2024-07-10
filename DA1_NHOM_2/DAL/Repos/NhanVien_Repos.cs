using App.Data.Data;
using App.Data.Entities;
using App.Data.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
    public class NhanVien_Repos : INhanVien_Repos
    {
        AppDBContext context;

        public NhanVien_Repos()
        {
            context = new AppDBContext();
        }

        public bool AddNV(NhanVien nv)
        {
            context.Add(nv);
            context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return context.NhanVien.ToList();
        }

        public bool RemoveNV(NhanVien nv)
        {
            context.Remove(nv);
            context.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien nv)
        {
            context.Update(nv);
            context.SaveChanges();
            return true;
        }
    }
}
