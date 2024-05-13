using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiPhieuBUS
    {
        public List<LoaiPhieuDTO> LayDSLoaiPhieu()
        {
            LoaiPhieuDAO loaiPhieuDAO = new LoaiPhieuDAO();
            List<LoaiPhieuDTO> loaiPhieuDTO = loaiPhieuDAO.LayDSLoaiPhieu();
            return loaiPhieuDTO;
        }
    }
}
