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
        public bool Add(SanPham sp)
        {
            try
            {
                _repos.AddSP(sp);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public string AddCTSP(ChiTietSanPham ctsp)
        {
            if (_repos.AddCTSP(ctsp) == true)
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

        public List<ChiTietSanPham> GetAll()
        {
            return _repos.GetAll();
        }

        public List<SanPham> GetAllSP()
        {
            return _repos.GetAllSP();
        }

        //
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
        // Lấy id của các trường dữ liệu

        public Guid GetIdHangSX(string name)
        {
            List<HangSanXuat> lst = GetAllHangSanXuat();

            var hangsx = lst.FirstOrDefault(x => x.Name.Equals(name));

            return hangsx.Id;
        }

        public Guid GetIdMauSac(string name)
        {
            List<MauSac> lst = GetAllMauSac();

            var mausac = lst.FirstOrDefault(x => x.Name.Equals(name));

            return mausac.Id;
        }

        public Guid GetIdChatLieu(string name)
        {
            List<ChatLieu> lst = GetAllChatLieu();

            var chatlieu = lst.FirstOrDefault(x => x.Name.Equals(name));

            return chatlieu.Id;
        }

        public Guid GetIdLoaiRen(string name)
        {
            List<LoaiRen> lst = GetAllLoaiRen();

            var loairen = lst.FirstOrDefault(x => x.Name.Equals(name));

            return loairen.Id;
        }
        //

        public List<ChiTietSanPham> FillSP(List<ChiTietSanPham> lst,
            Func<ChiTietSanPham, bool> dk1 = null,
            Func<ChiTietSanPham, bool> dk2 = null,
            Func<ChiTietSanPham, bool> dk3 = null,
            Func<ChiTietSanPham, bool> dk4 = null
            )
        {
            var query = lst.AsQueryable();

            if (dk1 != null)
            {
                query = query.Where(dk1).AsQueryable();
            }

            if (dk2 != null)
            {
                query = query.Where(dk2).AsQueryable();
            }

            if (dk3 != null)
            {
                query = query.Where(dk3).AsQueryable();
            }

            if (dk4 != null)
            {
                query = query.Where(dk4).AsQueryable();
            }

            return query.ToList();
        }
    }
}