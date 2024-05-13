using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public bool KiemTraDangNhap(string tenTaiKhoan, string matKhau, string loaiTaiKhoan)
        {
            bool ketQua = false;
            
            try
            {
                // Tạo đối tượng TaiKhoanDAO
                TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

                // Gọi phương thức kiểm tra đăng nhập từ TaiKhoanDAO
                ketQua = taiKhoanDAO.KiemTraDangNhap(tenTaiKhoan, matKhau, loaiTaiKhoan);
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
