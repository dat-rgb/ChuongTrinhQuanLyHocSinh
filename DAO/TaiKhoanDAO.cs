using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public bool KiemTraDangNhap(string tenTaiKhoan, string matKhau, string loaiTaiKhoan)
        {
            bool ketQua = false;
            //loaiTaiKhoan = ""; // Khởi tạo loại tài khoản

            try
            {
                // Kết nối CSDL
                SqlConnection conn = DataProvider.KetNoiCSDL();

                // Tạo câu truy vấn SQL
                string sCauTruyVan = "SELECT COUNT(*) AS Count FROM TaiKhoan WHERE tenTaiKhoan = @tenTaiKhoan AND matKhau = @matKhau AND loaiTaiKhoan = @loaiTaiKhoan";

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

                // Thêm các tham số vào câu truy vấn
                cmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);
                cmd.Parameters.AddWithValue("@loaiTaiKhoan", loaiTaiKhoan);
                // Thực thi truy vấn và lấy kết quả
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int count = dr.GetInt32(dr.GetOrdinal("Count")); // Lấy số lượng tài khoản
                    if (count > 0)
                    {
                        ketQua = true; // Đánh dấu đăng nhập thành công
                        
                    }
                }

                // Đóng SqlDataReader
                dr.Close();

                // Đóng kết nối
                conn.Close();
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
