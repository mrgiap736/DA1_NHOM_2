﻿using App.Data.Data;
using App.Data.Entities;
using App.Data.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
    public class SanPham_Repos : ISanPham_Repos
    {
        AppDBContext _context;

        public SanPham_Repos()
        {
            _context = new AppDBContext();    
        }

        public List<ChiTietSanPham> GetAll()
        {
            return _context.ChiTietSanPham
                .Include(x => x.SanPham)
                .Include(x => x.MauSac)
                .Include(x => x.HangSanXuat)
                .Include(x => x.ChatLieu)
                .Include(x => x.LoaiRen).ToList();
        }

        public bool UpdateSP(SanPham sp)
        {
            _context.SanPham.Update(sp);
            _context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAllSP()
        {
            return _context.SanPham.ToList();
        }

		public bool AddSP(SanPham sp)
		{
			_context.SanPham.Add(sp);
			_context.SaveChanges();
			return true;
		}

        public bool AddCTSP(ChiTietSanPham ctsp)
        {
            _context.ChiTietSanPham.Add(ctsp);
            _context.SaveChanges();
            return true;
        }


		public bool RemoveCTSP(ChiTietSanPham ctsp)
		{
			_context.Remove(ctsp);
			_context.SaveChanges();
			return true;
		}

		public bool UpdateCTSP(ChiTietSanPham ctsp)
		{
			_context.ChiTietSanPham.Update(ctsp);
			_context.SaveChanges();
			return true;
		}
        public List<ChiTietSanPham> GetFilteredData(string searchText, int filter1Index, int filter2Index)
        {
            var filteredData = GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredData = filteredData.Where(x => x.SanPham.TenSanPham.ToLower().Contains(searchText.ToLower().Trim())).ToList();
            }

            if (filter1Index > 0)
            {
                filteredData = filteredData.Intersect(LocTheoHang(filter1Index)).ToList();
            }

            if (filter2Index > 0)
            {
                // Lọc dữ liệu theo điều kiện từ cbx_Filter2
                if (filter2Index == 1)
                {
                    // Dưới 1 triệu
                    filteredData = filteredData.Where(x => x.GiaBan < 1000000).ToList();
                }
                else if (filter2Index == 2)
                {
                    // Từ 1 triệu đến 10 triệu
                    filteredData = filteredData.Where(x => x.GiaBan >= 1000000 && x.GiaBan <= 10000000).ToList();
                }
                else if (filter2Index == 3)
                {
                    // Từ 10 triệu đến 50 triệu
                    filteredData = filteredData.Where(x => x.GiaBan > 10000000 && x.GiaBan <= 50000000).ToList();
                }
                else if (filter2Index == 4)
                {
                    // Trên 50 triệu
                    filteredData = filteredData.Where(x => x.GiaBan > 50000000).ToList();
                }
            }

            return filteredData;
        }

        public List<ChiTietSanPham> SearchByName(string name)
        {
            return _context.ChiTietSanPham.Where(x => x.SanPham.TenSanPham.ToLower().Contains(name.ToLower().Trim())).ToList();
        }

        public List<ChiTietSanPham> FilterByPrice(int index)
        {
            int max = 0;
            int min = 0;

            if(index >= 0)
            {
                if(index == 0)
                {
                    return GetAll();
                }

                else if(index == 1)
                {
                    max = 1000000;
                    min = 0;
                }
                else if(index == 2)
                {
                    max = 10000000;
                    min = 1000000;
                }
                else if(index == 3)
                {
                    max = 50000000;
                    min = 10000000;
                }
                else
                {
                    max = int.MaxValue;
                    min = 50000000;
                }

                return _context.ChiTietSanPham.Where(x => x.GiaBan > min && x.GiaBan < max).ToList();
            }

            return GetAll();
        }
      


        public List<ChiTietSanPham> LocTheoHang(int index)
        {
            List<string> allManufacturers = GetAllManufacturers();

            if (index == 0)
            {
                return GetAll();
            }
            else if (index > 0 && index <= allManufacturers.Count)
            {
                string selectedManufacturer = allManufacturers[index - 1];

                return _context.ChiTietSanPham.Where(x => x.HangSanXuat.Name == selectedManufacturer).ToList();
            }

            return new List<ChiTietSanPham>();
        }


        public List<string> GetAllManufacturers()
        {
            return _context.ChiTietSanPham
                .Select(s => s.HangSanXuat.Name)
                .Distinct()
                .OrderBy(h => h) // Sắp xếp danh sách theo thứ tự bảng chữ cái
                .ToList();
        }


        public List<ChiTietSanPham> FilterByTheFirm(int index)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllThanhPhan<T>() where T : class
        {
            return _context.Set<T>().ToList();
        }


        //Các hàm tạo thành phẩn sản phẩm 
        public void CreateEntity<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void DeleteEntity<T>(Guid id) where T : class
        {
            var e = _context.Set<T>().Find(id);

            if (e == null)
            {
                throw new Exception($"{typeof(T).Name} not found.");
            }

            // Kiểm tra các ràng buộc toàn vẹn
            if (typeof(T) == typeof(MauSac))
            {
                var mauSac = e as MauSac;
                if (_context.ChiTietSanPham.Any(sp => sp.MaMauSac == mauSac.Id))
                {
                    throw new Exception("Không thể xóa màu");
                }
            }

            if (typeof(T) == typeof(ChatLieu))
            {
                var chatlieu = e as ChatLieu;
                if (_context.ChiTietSanPham.Any(sp => sp.MaChatLieu == chatlieu.Id))
                {
                    throw new Exception("Không thể xóa chất liệu");
                }
            }

            if (typeof(T) == typeof(LoaiRen))
            {
                var loairen = e as LoaiRen;
                if (_context.ChiTietSanPham.Any(sp => sp.MaLoaiRen == loairen.Id))
                {
                    throw new Exception("Không thể xóa loại ren");
                }
            }

            if (typeof(T) == typeof(HangSanXuat))
            {
                var hangsx = e as HangSanXuat;
                if (_context.ChiTietSanPham.Any(sp => sp.MaHangSanXuat == hangsx.Id))
                {
                    throw new Exception("Không thể xóa hãng sản xuất");
                }
            }

            _context.Set<T>().Remove(e);
            _context.SaveChanges();
        }
    }
}
