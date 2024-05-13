using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopHocDAO
    {
        public List<LopHocDTO> LayDSLop()
        {
            List<LopHocDTO> lst = new List<LopHocDTO>();

            string sCautruyVan = " SELECT L.maLop, L.tenLop, L.soLuongHS, GV.hoGV + ' ' + GV.tenGV AS giaoVienCN, PH.tenPhong, L.namHoc, L.trangThai ";
            sCautruyVan += " FROM LopHoc L ";
            sCautruyVan += " JOIN GiaoVien GV ON L.giaoVienCN = GV.maGV ";
            sCautruyVan += "JOIN PhongHoc PH ON L.phongHoc = PH.maPhong ";
            sCautruyVan += " WHERE L.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCautruyVan, conn);

            while (dr.Read())
            {
                LopHocDTO lopHocDTO = new LopHocDTO();
                if (!dr.IsDBNull(0))
                    lopHocDTO.maLop = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    lopHocDTO.tenLop = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    lopHocDTO.soLuongHS = dr.GetInt32(2);
                if (!dr.IsDBNull(3))
                    lopHocDTO.giaoVienCN = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    lopHocDTO.phongHoc = dr.GetString(4);
                if (!dr.IsDBNull(5))
                    lopHocDTO.namHoc = dr.GetString(5);
                if (!dr.IsDBNull(6))
                    lopHocDTO.trangThai = dr.GetString(6);
                lst.Add(lopHocDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public LopHocDTO LayDuLieuTuDataGridView(string maLop, string tenLop, int soLuongHS, string giaoVienCN, string phongHoc, string namHoc)
        {
            LopHocDTO lopHocDTO = new LopHocDTO();
            lopHocDTO.maLop = maLop;
            lopHocDTO.tenLop = tenLop;
            lopHocDTO.soLuongHS = soLuongHS;
            lopHocDTO.giaoVienCN = giaoVienCN;
            lopHocDTO.phongHoc = phongHoc;
            lopHocDTO.namHoc = namHoc;

            return lopHocDTO;

        }
        public List<LopHocDTO> LayDSLopTheoNamHoc(string namHoc)
        {
            List<LopHocDTO> lst = new List<LopHocDTO>();

            string sCauTruyVan = "SELECT maLop, tenLop FROM LopHoc ";
            sCauTruyVan += "WHERE namHoc = @namHoc AND trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@namHoc", namHoc);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO lopHocDTO = new LopHocDTO();
                if (!dr.IsDBNull(0))
                    lopHocDTO.maLop = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    lopHocDTO.tenLop = dr.GetString(1);

                lst.Add(lopHocDTO);
            }
            return lst;
        }
        public bool KiemTraTonTaiHocSinhTrongLop(string maLop)
        {
            try
            {
                string sSQL = "SELECT COUNT(*) FROM HocSinh WHERE lop = @maLop";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@maLop", maLop);

                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaLop_CapNhatTrangThaiLop(string maLop)
        {
            try
            {
                string sSQL = "UPDATE LopHoc SET trangThai = '2' WHERE maLop = @maLop";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@maLop", maLop);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool KiemTraMaLopTrung(string maLop)
        {
            string query = "SELECT COUNT(*) FROM LopHoc WHERE maLop = @maLop ";

            using (SqlConnection connection = DataProvider.KetNoiCSDL())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maLop", maLop);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool KiemTraGVCNTrung(string maGV, string namHoc)
        {
            string query = "SELECT COUNT(*) FROM LopHoc WHERE giaoVienCN = @maGV AND namHoc = @namHoc ";

            using (SqlConnection connection = DataProvider.KetNoiCSDL())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maGV", maGV);
                command.Parameters.AddWithValue("@namHoc", namHoc);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool KiemTraPhongHocTrung(string maPhong, string namHoc)
        {
            string query = "SELECT COUNT(*) FROM LopHoc WHERE phongHoc = @maPhong AND namHoc = @namHoc ";

            using (SqlConnection connection = DataProvider.KetNoiCSDL())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maPhong", maPhong);
                command.Parameters.AddWithValue("@namHoc", namHoc);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void ThemLopHoc(string maLop, string tenLop, int soLuongHS, string giaoVienCN, string phongHoc, string namHoc)
        {
            try
            {
                // Tiến hành thêm lớp mới vào cơ sở dữ liệu
                string sSQL = "INSERT INTO LopHoc (maLop, tenLop, soLuongHS, giaoVienCN, phongHoc, namHoc, trangThai) VALUES (@maLop, @tenLop, @soLuongHS, @giaoVienCN, @phongHoc, @namHoc, '1')";

                using (SqlConnection connection = DataProvider.KetNoiCSDL())
                {
                    SqlCommand command = new SqlCommand(sSQL, connection);
                    command.Parameters.AddWithValue("@maLop", maLop);
                    command.Parameters.AddWithValue("@tenLop", tenLop);
                    command.Parameters.AddWithValue("@soLuongHS", soLuongHS);
                    command.Parameters.AddWithValue("@giaoVienCN", giaoVienCN);
                    command.Parameters.AddWithValue("@phongHoc", phongHoc);
                    command.Parameters.AddWithValue("@namHoc", namHoc);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

