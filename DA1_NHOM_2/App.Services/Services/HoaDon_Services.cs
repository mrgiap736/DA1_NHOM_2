using App.Data.Entities;
using App.Data.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
	public class HoaDon_Services
	{
		HoaDon_Repos hdrp;

		public HoaDon_Services()
		{
			hdrp = new HoaDon_Repos();
		}

		public void TaoHoaDon(HoaDon hd)
		{
			hdrp.Create(hd);
		}

		public List<HoaDon> GetAllHoaDon()
		{
			return hdrp.GetAll();
		}

		public void CapNhatHoaDon(HoaDon hoaDon)
		{
			hdrp.Update(hoaDon);
		}

		public HoaDon GetHD(Guid id)
		{
			return hdrp.Get(id);
		}

		public List<HoaDon> SearchByNameKH(string name)
		{
			return hdrp.SearchByNameKH(name);
		}

		public List<HoaDon> FilByTT(string tt)
		{
			return hdrp.FilByTT(tt);
		}

        //Hàm chuyển số ngăn cách phần nghìn 
        public string AddThousandSeparators(int number)
        {
            // Chuyển đổi số sang chuỗi và sử dụng phương thức Format để thêm dấu chấm ngăn cách
            string formattedNumber = string.Format("{0:N0}", number);

            return formattedNumber;
        }

    }
}
