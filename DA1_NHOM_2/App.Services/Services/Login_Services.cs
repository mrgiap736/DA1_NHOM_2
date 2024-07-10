using A_DAL.Entities;
using A_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class Login_Services
    {
        NhanVien_Repos nvrp;
        public Login_Services()
        {
             nvrp = new NhanVien_Repos();
        }

        public NhanVien GetUS_PW(string username, string password)
        {
            NhanVien nv = null;
            List<NhanVien> _lstnv = nvrp.GetAll();

            for (int i = 0; i < _lstnv.Count; i++)
            {
                if (_lstnv[i].TaiKhoan.Equals(username) && _lstnv[i].MatKhau.Equals(password))
                {
                    nv = _lstnv[i];
                }
            }

            return nv;
        }
    }
}
