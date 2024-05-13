using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongHocBUS
    {
        public List<PhongHocDTO> LayDSPhongHoc()
        {
            PhongHocDAO phongHocDAO = new PhongHocDAO();
            List<PhongHocDTO> lst = phongHocDAO.LayDSPhongHoc(); ;
            return lst;
        }
        public List<PhongHocDTO> LayDSPhongHocChuaCoLop(string namHoc)
        {
            PhongHocDAO phongHocDAO = new PhongHocDAO();
            List<PhongHocDTO> lst = phongHocDAO.LayDSPhongHocChuaCoLop(namHoc);

            return lst;
        }
    }
}
