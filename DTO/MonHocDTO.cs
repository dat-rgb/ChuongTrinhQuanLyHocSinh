using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        public string maMonHoc {  get; set; }
        public string tenMonHoc { get; set; }
        public string moTa { get; set; }

        public MonHocDTO() 
        {
            maMonHoc = string.Empty;
            tenMonHoc = string.Empty;
            moTa = string.Empty;
        }
    }
}
