using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
    public class SanPham_Repos : ISanPham_Repos
    {
        SqlTheCtzContext context;

        public SanPham_Repos()
        {
            context = new SqlTheCtzContext();
            
        }
        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }

		public bool AddSP(SanPham sp)
		{
			context.Add(sp);
			context.SaveChanges();
			return true;
		}


		public bool RemoveSP(SanPham sp)
		{
			context.Remove(sp);
			context.SaveChanges();
			return true;
		}

		public bool UpdateSP(SanPham sp)
		{
			context.Update(sp);
			context.SaveChanges();
			return true;
		}
        public List<SanPham> GetFilteredData(string searchText, int filter1Index, int filter2Index)
        {
            var filteredData = GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredData = filteredData.Where(x => x.TenSanPham.ToLower().Contains(searchText.ToLower().Trim())).ToList();
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

        public List<SanPham> SearchByName(string name)
        {
            return context.SanPhams.Where(x => x.TenSanPham.ToLower().Contains(name.ToLower().Trim())).ToList();
        }

        public List<SanPham> FilterByPrice(int index)
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

                return context.SanPhams.Where(x => x.GiaBan > min && x.GiaBan < max).ToList();
            }

            return GetAll();
        }
      


        public List<SanPham> LocTheoHang(int index)
        {
            List<string> allManufacturers = GetAllManufacturers();

            if (index == 0)
            {
                return GetAll();
            }
            else if (index > 0 && index <= allManufacturers.Count)
            {
                string selectedManufacturer = allManufacturers[index - 1];

                return context.SanPhams.Where(x => x.HangSanXuat == selectedManufacturer).ToList();
            }

            return new List<SanPham>();
        }


        public List<string> GetAllManufacturers()
        {
            return context.SanPhams
                .Select(s => s.HangSanXuat)
                .Distinct()
                .OrderBy(h => h) // Sắp xếp danh sách theo thứ tự bảng chữ cái
                .ToList();
        }


        public List<SanPham> FilterByTheFirm(int index)
        {
            throw new NotImplementedException();
        }
    }
}
