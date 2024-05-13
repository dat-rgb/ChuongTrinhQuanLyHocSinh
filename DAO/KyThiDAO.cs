using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KyThiDAO
    {

        public List<KyThiDTO> LayDSKyThi()
        {
            List<KyThiDTO> lst = new List<KyThiDTO>();
            string sCauTruyVan = " SELECT maKyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThu, trangThai ";
            sCauTruyVan += " FROM KyThi ";
            sCauTruyVan += " WHERE trangThai = '1'";

            try
            {
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

                while (dr.Read())
                {
                    KyThiDTO kyThiDTO = new KyThiDTO();
                    if (!dr.IsDBNull(0))
                        kyThiDTO.maKyThi = dr.GetString(0);
                    if (!dr.IsDBNull(1))
                        kyThiDTO.tenKyThi = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        kyThiDTO.namHoc = dr.GetString(2);
                    if (!dr.IsDBNull(3))
                        kyThiDTO.ngayBatDau = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        kyThiDTO.ngayKetThuc = dr.GetDateTime(4);
                    if (!dr.IsDBNull(5))
                        kyThiDTO.trangThai = dr.GetString(5);

                    lst.Add(kyThiDTO);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            return lst;
        }
        public List<KyThiDTO> LayDSTatCaKyThi()
        {
            List<KyThiDTO> lst = new List<KyThiDTO>();
            string sCauTruyVan = " SELECT maKyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThu, trangThai ";
            sCauTruyVan += " FROM KyThi ";
            

            try
            {
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

                while (dr.Read())
                {
                    KyThiDTO kyThiDTO = new KyThiDTO();
                    if (!dr.IsDBNull(0))
                        kyThiDTO.maKyThi = dr.GetString(0);
                    if (!dr.IsDBNull(1))
                        kyThiDTO.tenKyThi = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        kyThiDTO.namHoc = dr.GetString(2);
                    if (!dr.IsDBNull(3))
                        kyThiDTO.ngayBatDau = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        kyThiDTO.ngayKetThuc = dr.GetDateTime(4);
                    if (!dr.IsDBNull(5))
                        kyThiDTO.trangThai = dr.GetString(5);

                    lst.Add(kyThiDTO);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            return lst;
        }
        public bool KiemTraKyThiTrung(string maKyThi)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM KyThi WHERE maKyThi = @maKyThi";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maKyThi", maKyThi);

                int count = (int)command.ExecuteScalar();

                return count > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ThemKyThi(string maKyThi, string tenKyThi, string namHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                string query = "INSERT INTO KyThi (maKyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThu, trangThai) VALUES (@maKyThi, @TenKyThi, @namHoc, @NgayBatDau, @NgayKetThuc, '1')";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maKyThi", maKyThi);
                command.Parameters.AddWithValue("@TenKyThi", tenKyThi);
                command.Parameters.AddWithValue("@namHoc", namHoc);
                command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool XoaKyThi(string maKyThi)
        {
            bool xoa = false;
            try
            {
                string query = "DELETE FROM KyThi WHERE maKyThi = @maKyThi";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maKyThi", maKyThi);
                command.ExecuteNonQuery();
                xoa = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                xoa = false;
            }
            return xoa;
        }
        public void HoanThanhKyThi(string maKyThi)
        {
            try
            {
                string sCauTruyVan = " UPDATE KyThi ";
                sCauTruyVan += " SET trangThai = N'Hoàn thành' ";
                sCauTruyVan += " WHERE maKyThi = '" + maKyThi +"'";
                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);
                int kq = DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                connection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaKyThi(string maKyThi, string tenKyThi, string namHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                string sCauTruyVan = " UPDATE KyThi ";
                sCauTruyVan += " SET tenKyThi = N'" + tenKyThi + "',";
                sCauTruyVan += " namHoc = '" + namHoc +"', ";
                sCauTruyVan += " ngayBatDau = '" + ngayBatDau +"',";
                sCauTruyVan += " ngayKetThu = '" +ngayKetThuc + "'";             
                sCauTruyVan += " WHERE maKyThi = '" + maKyThi +"'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);
                int kq = DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi sửa kỳ thi: " + ex.Message);
            }
        }

    }
}
