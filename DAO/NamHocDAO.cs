using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NamHocDAO
    {
        public List<NamHocDTO> LayDSNamHoc()
        {
            List<NamHocDTO> lst = new List<NamHocDTO>();
            string sCauTruyVan = "SELECT tenNamHoc FROM NamHoc WHERE trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                NamHocDTO namHocDTO = new NamHocDTO();
                if (!dr.IsDBNull(0))
                    namHocDTO.tenNamHoc = dr.GetString(0);
               
                lst.Add(namHocDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<NamHocDTO> LayTatCaNamHoc()
        {
            List<NamHocDTO> lst = new List<NamHocDTO>();
            string sCauTruyVan = "SELECT tenNamHoc, trangThai FROM NamHoc ";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                NamHocDTO namHocDTO = new NamHocDTO();
                if (!dr.IsDBNull(0))
                    namHocDTO.tenNamHoc = dr.GetString(0);
                if(!dr.IsDBNull(1))
                    namHocDTO.trangThai = dr.GetString(1);
                lst.Add(namHocDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public bool KiemTraNamHocTrung(string tenNamHoc)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM NamHoc WHERE tenNamHoc = @TenNamHoc";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenNamHoc", tenNamHoc);

                int count = (int)command.ExecuteScalar();

                return count > 0;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ThemNamHoc(string tenNamHoc, string trangThai)
        {
            try
            {
                string query = "INSERT INTO NamHoc (tenNamHoc, trangThai) VALUES (@tenNamHoc, @trangThai)";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenNamHoc", tenNamHoc);
                command.Parameters.AddWithValue("@trangThai", trangThai);

                command.ExecuteNonQuery();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool XoaNamHoc(string tenNamHoc)
        {
            bool xoa = false;
            try
            {
                string query = "DELETE FROM NamHoc WHERE tenNamHoc = @tenNamHoc";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenNamHoc", tenNamHoc);
                command.ExecuteNonQuery();
                xoa = true;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và gán xoa = false
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                xoa = false;
            }
            return xoa;
        }
        public void HoanThanhNamHoc(string tenNamHoc)
        {
            try
            {
                string sCauTruyVan = " UPDATE NamHoc ";
                sCauTruyVan += " SET trangThai = N'Hoàn thành' ";
                sCauTruyVan += " WHERE tenNamHoc = '" + tenNamHoc + "' ";
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
        public void SuaNamHoc( string tenNamHoc, string trangThai)
        {
            try
            {
                string sCauTruyVan = " UPDATE NamHoc ";
                sCauTruyVan += " SET trangThai = N'" + trangThai + "'";
                sCauTruyVan += " WHERE tenNamHoc = '" + tenNamHoc + "'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);

                int kq = DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                connection.Close();
              
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi sửa năm học: " + ex.Message);
            }
        }

    }
}
