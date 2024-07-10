using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepos
{
    public interface IKhachHang_Repos
    {
        public List<KhachHang> GetAll();
        public bool AddKH(KhachHang kh);
        public bool UpdateKH(KhachHang kh);
        public bool RemoveKH(KhachHang kh);
        public KhachHang SearchByPhone(string phone);
        public KhachHang SearchByName(string name);
    }
}
