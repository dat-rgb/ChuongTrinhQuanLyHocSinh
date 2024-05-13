using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichThiDAO
    {
        public void TaoLichThi(int soLuongHocSinh, string kyThi, string monThi, string diaDiem, DateTime ngayThi, string trangThai)
        {
            try
            {
                string query = @"INSERT INTO LichThi (kyThi, hocSinh, monThi, diaDiem, ngayThi, trangThai)
                         SELECT @KyThi, H.maHS, @MonThi, @DiaDiem, @NgayThi, @TrangThai
                         FROM (
                             SELECT TOP (@SoLuong) maHS
                             FROM HocSinh
                             WHERE trangThai = '1'
                             ORDER BY tenHS, hoHS
                         ) AS HocSinh20";

                using (SqlConnection connection = DataProvider.KetNoiCSDL())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SoLuong", soLuongHocSinh);
                        command.Parameters.AddWithValue("@KyThi", kyThi);
                        command.Parameters.AddWithValue("@MonThi", monThi);
                        command.Parameters.AddWithValue("@DiaDiem", diaDiem);
                        command.Parameters.AddWithValue("@NgayThi", ngayThi);
                        command.Parameters.AddWithValue("@TrangThai", trangThai);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
