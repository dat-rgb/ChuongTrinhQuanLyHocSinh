using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHocBUS
    {
        public List<MonHocDTO> LayDSMonHoc()
        {
            MonHocDAO monHocDAO = new MonHocDAO();
            List<MonHocDTO> lst = monHocDAO.LayDSMonHoc();
            return lst;
        }
    }
}
