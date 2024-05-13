using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangCapDTO
    {
        public string maBangCap {  get; set; }
        public string tenBangCap { get; set; }
        public string moTa { get; set; }
        public BangCapDTO() 
        {
            maBangCap= string.Empty;
            tenBangCap= string.Empty;
            moTa= string.Empty;
        }
    }
}
