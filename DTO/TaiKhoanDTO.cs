using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int maTaiKhoan { get; set; }
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public string loaiTaiKhoan { get; set; }
        public TaiKhoanDTO() { 
            maTaiKhoan = 0;
            tenTaiKhoan = " ";
            matKhau = " ";
            loaiTaiKhoan = " ";
        }
    }
}
