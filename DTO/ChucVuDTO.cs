using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        public string maChucVu { get; set; }
        public string tenChucVu { get; set;}
        public string moTa { get; set; }

        public ChucVuDTO() 
        {
            maChucVu = string.Empty;
            tenChucVu = string.Empty;
            moTa = string.Empty;
        }
    }
}
