using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        public string maHS { get; set; }
        public string cccd { get; set; }
        public string hoHS { get; set; }
        public string tenHS { get; set; }
        public int gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string queQuan { get; set; }
        public string soDT { get; set; }
        public string mail { get; set; }
        public string lop { get; set; }
        public DateTime namNhapHoc { get; set; }
        public string trangThai { get; set; }

        public HocSinhDTO()
        {
            maHS = "";
            cccd = "";
            hoHS = "";
            tenHS = "";
            gioiTinh = 0;
            ngaySinh = new DateTime(2000, 1, 1);
            queQuan = "";
            soDT = "";
            mail = "";
            lop = "";
            namNhapHoc = new DateTime(2000,1,1) ;
            trangThai = "";
        }
    }

}
