using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BangCapBUS
    {
        public List<BangCapDTO> LayDSBangCap()
        {
            BangCapDAO bangCapDAO = new BangCapDAO();
            List<BangCapDTO> lst = bangCapDAO.LayDSBangCap();
            return lst; ;
        }
           
    }
}
