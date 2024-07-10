using A_DAL.Entities;
using A_DAL.Repos;

namespace B_BUS.Services
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
			var clone = _repos.GetAll().FirstOrDefault(x => x.MaSanPham == sp.MaSanPham);
			clone.MaSanPham = sp.MaSanPham;
			clone.TenSanPham = sp.TenSanPham;
			clone.HangSanXuat = sp.HangSanXuat;
			clone.ThongSoKyThuat = sp.ThongSoKyThuat;
			clone.GiaNhap = sp.GiaNhap;
			clone.GiaBan = sp.GiaBan;
			clone.TrangThai = sp.TrangThai;///
			clone.HinhAnh = sp.HinhAnh;
			if (_repos.UpdateSP(clone) == true)
			{
				return "Update sản phẩm thành công";
			}
			else
			{
				return "Update sản phẩm thất bại";
			}
		}

		public string Remove(SanPham sp)
		{
			var clone = _repos.GetAll().FirstOrDefault(x => x.MaSanPham == sp.MaSanPham);
			if (_repos.RemoveSP(clone) == true)
			{
				return "Đã xoá sản phẩm ";
			}
			else
			{
				return "Xoá sản phẩm thất bại";
			}
		}

		public List<SanPham> GetAll(string search)
		{
			if (search == null)
			{
				return _repos.GetAll();
			}
			else
			{
				return _repos.GetAll().Where(x => x.TenSanPham.Contains(search)).ToList();
			}
		}

    }
}