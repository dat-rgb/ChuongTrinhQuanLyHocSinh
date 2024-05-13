using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuChiDAO
    {
        public bool KiemTraHocSinhThuChi(string hocSinh, string loaiPhieu)
        {
            bool ketQua = false;
            try
            {
                SqlConnection conn = DataProvider.KetNoiCSDL();
                string sCauTruyVan = "SELECT COUNT(*) FROM ThuChi WHERE hocSinh = @hocSinh AND loaiPhieu = @loaiPhieu";

                SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

                // Thêm các tham số vào câu truy vấn
                cmd.Parameters.AddWithValue("@hocSinh", hocSinh);
                cmd.Parameters.AddWithValue("@loaiPhieu", loaiPhieu);

                // Thực thi truy vấn và lấy kết quả
                int count = (int)cmd.ExecuteScalar(); // Sử dụng ExecuteScalar để lấy giá trị đơn giản trả về từ câu truy vấn

                if (count > 0)
                {
                    ketQua = true; // Đánh dấu đăng nhập thành công
                }

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
