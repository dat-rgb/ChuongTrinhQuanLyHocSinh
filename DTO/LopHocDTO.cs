using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocDTO
    {
       
        public string maLop { get; set; }
        public string tenLop { get; set; }
        public int soLuongHS { get; set; }
        public string giaoVienCN { get; set; }
        public string phongHoc { get; set; }
        public string namHoc { get; set; }
        public string trangThai { get; set; }
        
        public LopHocDTO() {
            maLop = "";
            tenLop = "";
            soLuongHS = 0;
            giaoVienCN = string.Empty;
            phongHoc = string.Empty;
            namHoc = string.Empty;
            trangThai = string.Empty;
        }

    }
}
