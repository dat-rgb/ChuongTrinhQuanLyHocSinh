using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KyThiDTO
    {
        public string maKyThi { get; set; }
        public string tenKyThi { get; set; }
        public string namHoc { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string trangThai { get; set; }
    }
}
