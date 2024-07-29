using App.Data.Entities;
using App.Data.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
    public class NhanVien_Services
    {
        NhanVien_Repos _repos;
        public NhanVien_Services()
        {
            _repos = new NhanVien_Repos();
        }
        public string Add(NhanVien nv)	
		{

            if (_repos.AddNV(nv) == true)
			{
				return "Nhân Viên đã thêm thành công";
			}
			else
			{
				return "NhanVien phẩm thất bại";
			}
        }

		public string Update(NhanVien nv)
		{
			var clone = _repos.GetAll().FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
			clone.TenNhanVien = nv.TenNhanVien;
			clone.ChucVu= nv.ChucVu;
			clone.TaiKhoan = nv.TaiKhoan;
			clone.MatKhau = nv.MatKhau;
			if (_repos.UpdateNV(clone) == true)
			{
				return "Update nhân viên thành công";
			}
			else
			{
				return "Update nhân viên thất bại";
			}
		}

		public string Remove(NhanVien nv)
		{
			var clone = _repos.GetAll().FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
			clone.NgayKetThuc = DateTime.Now;
			clone.TrangThai = "Đã nghỉ việc";
			if (_repos.UpdateNV(clone) == true)
			{
				return "Đã hủy nhân viên ";
			}
			else
			{
				return "Hủy nhân viên thất bại";
			}
		}

		public List<NhanVien> GetAll(string search)
		{
			if (search == null)
			{
				return _repos.GetAll();
			}
			else
			{
				return _repos.GetAll().Where(x => x.TenNhanVien.Contains(search)).ToList();
			}
		}
    }
}
