using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVienDTO
    {
        public string maGV { get; set; }
        public string cccd { get; set; }
        public string hoGV { get; set; }
        public string tenGV { get; set; }
        public int gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string queQuan { get; set; }
        public string soDT { get; set; }
        public string mail { get; set; }
        public string bangCap { get; set; }
        public DateTime ngayVao { get; set; }
        public string chucVu { get; set; }
        public string trangThai { get; set; }

        public GiaoVienDTO() { 
            maGV = string.Empty;
            cccd = string.Empty;
            hoGV = string.Empty;
            tenGV = string.Empty;
            gioiTinh = 1;
            ngaySinh = DateTime.MinValue;
            queQuan = string.Empty;
            soDT = string.Empty;
            mail = string.Empty;
            bangCap = string.Empty;
            ngayVao = DateTime.MinValue;
            chucVu = string.Empty;
            trangThai = string.Empty;
        }
    }
}
