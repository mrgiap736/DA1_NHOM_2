using App.Data.Entities;
using App.Data.Repos;


namespace App.Services.Services
{
    public class KhachHang_Services
    {
        KhachHang_Repos _repos;
        public KhachHang_Services()
        {
            _repos = new KhachHang_Repos();
        }
        public string Add(KhachHang kh)
        {

            if (_repos.AddKH(kh) == true)
            {
                return "Khách hàng đã thêm thành công";
            }
            else
            {
                return "Khách hàng thêm thất bại";
            }
        }

        public string Update(KhachHang kh)
        {
            var clone = _repos.GetAll().FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            clone.MaKhachHang = kh.MaKhachHang;
            clone.TenKhachHang = kh.TenKhachHang;
            clone.SoDienThoai = kh.SoDienThoai;
            clone.TichLuy = kh.TichLuy;
            if (_repos.UpdateKH(clone) == true)
            {
                return "Update khách hàng thành công";
            }
            else
            {
                return "Update khách hàng thất bại";
            }
        }

        public string Remove(KhachHang kh)
        {
            var clone = _repos.GetAll().FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            if (_repos.RemoveKH(clone) == true)
            {
                return "Đã xoá khách hàng ";
            }
            else
            {
                return "Xoá khách hàng thất bại";
            }
        }
        public List<KhachHang> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAll();
            }
            else
            {
                return _repos.GetAll().Where(x => x.TenKhachHang.Contains(search)).ToList();
            }
        }

        public KhachHang Search_KH_By_Name(string name)
        {
            return _repos.SearchByName(name);
        }

    }
}
