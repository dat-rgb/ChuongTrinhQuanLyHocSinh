using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichGiangDayDTO
    {
        public int maLich {  get; set; }    
        public string giaoVien {  get; set; }
        public string lop { get; set; }
        public string thu {  get; set; }
        public string monHoc {  get; set; }
        public int buoi {  get; set; }
        public int tietBatDau { get; set; }
        public int tietKetThuc { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string trangThai { get; set;}
    }
}
