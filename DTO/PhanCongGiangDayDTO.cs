using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongGiangDayDTO
    {
        public int maPhanCong {  get; set; }
        public string giaoVien { get; set; }
        public string monDay { get; set; }
        public string moTa { get; set; }

        public PhanCongGiangDayDTO()
        {
            maPhanCong = 0;
            giaoVien = "";
            monDay = "";
            moTa = "";
        }
        
    }
}
