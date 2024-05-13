using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemTrungBinhDTO
    {
        public int maDiemTrungBinh { get; set; }
        public string hocSinh { get; set; }
        public string hocKy { get; set; }
        public float diemTBHocKy { get; set; }
        public string xepLoai { get; set; }
        public string trangThai { get; set; }

        // Constructor
        public DiemTrungBinhDTO()
        {
            maDiemTrungBinh = 0;
            hocSinh = "";
            diemTBHocKy = 0.0f;
            xepLoai = "";
            trangThai = "";
        }
    }
}
