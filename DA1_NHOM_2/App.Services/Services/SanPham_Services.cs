using App.Data.Entities;
using App.Data.Repos;

namespace App.Services.Services
{
	public class SanPham_Services
    {
		SanPham_Repos _repos;
		public SanPham_Services()
		{
			_repos = new SanPham_Repos();

		}
		public string Add(SanPham sp)	
		{

            if (_repos.AddSP(sp) == true)
			{
				return "Sản phẩm đã thêm thành công";
			}
			else
			{
				return "Thêm sản phẩm thất bại";
			}
        }

		public string Update(SanPham sp)
		{
			//var clone = _repos.GetAll().FirstOrDefault(x => x.MaSanPham == sp.MaSanPham); //cần sửa
			//clone.MaSanPham = sp.MaSanPham;
			//clone.TenSanPham = sp.TenSanPham;
			//clone.HangSanXuat = sp.HangSanXuat;
			//clone.ThongSoKyThuat = sp.ThongSoKyThuat;
			//clone.GiaNhap = sp.GiaNhap;
			//clone.GiaBan = sp.GiaBan;
			//clone.TrangThai = sp.TrangThai;///
			//clone.HinhAnh = sp.HinhAnh;
			//if (_repos.UpdateSP(clone) == true)
			//{
			//	return "Update sản phẩm thành công";
			//}
			//else
			//{
			//	return "Update sản phẩm thất bại";
			//}

			return null;
		}

		public string Remove(SanPham sp)
		{
			//var clone = _repos.GetAll().FirstOrDefault(x => x.MaSanPham == sp.MaSanPham); //cần sửa
			//if (_repos.RemoveSP(clone) == true)
			//{
			//	return "Đã xoá sản phẩm ";
			//}
			//else
			//{
			//	return "Xoá sản phẩm thất bại";
			//}
			return null;
		}

		public List<ChiTietSanPham> GetAll(string search)
		{
			if (search == null)
			{
				return _repos.GetAll();
			}
			else
			{
				return _repos.GetAll().Where(x => x.SanPham.TenSanPham.Contains(search)).ToList();
			}
		}

		public List<HangSanXuat> GetAllHangSanXuat()
		{
			return _repos.GetAllHangSanXuat();
		}

		public List<MauSac> GetAllMauSac()
		{
			return _repos.GetAllMauSac();
		}

		public List<ChatLieu> GetAllChatLieu()
		{
			return _repos.GetAllChatLieu();
		}

		public List<LoaiRen> GetAllLoaiRen()
		{
			return _repos.GetAllLoaiRen();
		}

    }
}