using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NamHocDTO
    {
        public string tenNamHoc {  get; set; }
        public string trangThai { get; set; }   
      
       
        public NamHocDTO() 
        {
            tenNamHoc = string.Empty;
            trangThai = string.Empty;
           
        }
    }
}
