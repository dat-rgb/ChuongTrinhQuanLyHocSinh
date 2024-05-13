using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ThuChiBUS
    {
        public bool KiemTraThuChi(string hocSinh, string loaiPhieu)
        {
            bool ketQua = false;

            try
            {
                ThuChiDAO thuChiDAO = new ThuChiDAO();
                ketQua = thuChiDAO.KiemTraHocSinhThuChi(hocSinh, loaiPhieu);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw ex;
            }

            return ketQua;
        }
    }
}
