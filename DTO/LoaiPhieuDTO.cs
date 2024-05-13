using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhieuDTO
    {
        public string maLoaiPhieu {  get; set; }
        public string tenPhieu { get; set; }
      
        public LoaiPhieuDTO() 
        {
            maLoaiPhieu = string.Empty;
            tenPhieu = string.Empty;
             
        }
    }
}
