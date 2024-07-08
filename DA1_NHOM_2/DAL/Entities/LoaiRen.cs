using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class LoaiRen
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
