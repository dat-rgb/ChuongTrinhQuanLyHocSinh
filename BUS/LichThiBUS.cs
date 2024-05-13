using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichThiBUS
    {
        public void TaoLichThi(int soLuongHocSinh, string kyThi, string monThi, string diaDiem, DateTime ngayThi, string trangThai)
        {
            LichThiDAO lichThiDAO = new LichThiDAO(); 
            lichThiDAO.TaoLichThi(soLuongHocSinh, kyThi, monThi, diaDiem, ngayThi, trangThai);
        }
    }
}
