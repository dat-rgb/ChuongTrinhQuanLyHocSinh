using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuChiDTO
    {
        public int maThuChi { get; set; }
        public string loaiPhieu { get; set; }
        public string hocSinh { get; set; }
        public string nienKhoa { get; set; }
        public string moTa { get; set; }

        public ThuChiDTO() { 
            maThuChi = 0;
            loaiPhieu = string.Empty;
            hocSinh = string.Empty;
            nienKhoa = string.Empty;
            moTa = string.Empty;
        }
    }
}
