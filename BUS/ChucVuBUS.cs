using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVuBUS
    {
        public List<ChucVuDTO> LayDSChucVu()
        {
            ChucVuDAO chucVuDAO = new ChucVuDAO();
            List<ChucVuDTO> lst = chucVuDAO.LayDSChucVu();
            return lst; ;

        }
    }
}
