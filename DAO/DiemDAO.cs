using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DiemDAO
    {
        public List<DiemDTO> LayDSDiem()
        {
            List<DiemDTO> lst = new List<DiemDTO>();

            string sCauTruyVan = "SELECT D.hocSinh, M.tenMonHoc, HK.tenHocKy, D.diemTX, D.diemKT1, D.diemKT2, D.diemThi, D.DiemTB ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "JOIN MonHoc M ON D.monHoc = M.maMonHoc ";
            sCauTruyVan += "JOIN HocKy HK ON D.hocKy = HK.maHocKy ";
            sCauTruyVan += "WHERE H.trangThai = '1'";
            try
            {
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);
                
                while (dr.Read())
                { 
                    DiemDTO diemDTO = new DiemDTO();
                  
                    if (!dr.IsDBNull(0))
                        diemDTO.hocSinh = dr.GetString(0);
                    if (!dr.IsDBNull(1))
                        diemDTO.monHoc = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        diemDTO.hocKy = dr.GetString(2);
                    if (!dr.IsDBNull(3))
                        diemDTO.diemTX = (float)dr.GetDouble(3);
                    if (!dr.IsDBNull(4))
                        diemDTO.diemKT1 = (float)dr.GetDouble(4);
                    if (!dr.IsDBNull(5))
                        diemDTO.diemKT2 = (float)dr.GetDouble(5);
                    if (!dr.IsDBNull(6))
                        diemDTO.diemThi = (float)dr.GetDouble(6);
                    if (!dr.IsDBNull(7))
                        diemDTO.diemTB = (float)dr.GetDouble(7);

                    lst.Add(diemDTO);
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, ví dụ:
                throw new Exception("Lỗi khi lấy dữ liệu điểm: " + ex.Message);
            }

            return lst;
        }
        public DiemDTO LayDuLieuTuDataGridView(string hocSinh, string monHoc, string hocKy, float diemTX, float diemKT1, float diemKT2, float diemThi, float diemTB)
        {
            DiemDTO diemDTO = new DiemDTO();

            // Gán dữ liệu vào các thuộc tính của đối tượng DiemDTO
            diemDTO.hocSinh = hocSinh;
            diemDTO.monHoc = monHoc;
            diemDTO.hocKy = hocKy;
            diemDTO.diemTX = diemTX;
            diemDTO.diemKT1 = diemKT1;
            diemDTO.diemKT2 = diemKT2;
            diemDTO.diemThi = diemThi;
            diemDTO.diemTB = diemTB;

            return diemDTO;
        }
        public List<DiemDTO> LayDSDiemTheoMaHSVaHocKy(string hocSinh, string hocKy)
        {
            List<DiemDTO> diemDTOs = new List<DiemDTO>();
            string sCauTruyVan = "SELECT D.hocSinh, M.tenMonHoc, HK.tenHocKy, D.diemTX, D.diemKT1, D.diemKT2, D.diemThi, D.DiemTB ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "JOIN MonHoc M ON D.monHoc = M.maMonHoc ";
            sCauTruyVan += "JOIN HocKy HK ON D.hocKy = HK.maHocKy ";
            sCauTruyVan += " WHERE D.hocSinh = @hocSinh AND D.hocKy = @hocKy";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

            cmd.Parameters.AddWithValue("@hocSinh", hocSinh);
            cmd.Parameters.AddWithValue("@hocKy", hocKy);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DiemDTO diemDTO = new DiemDTO();
                if (!dr.IsDBNull(0))
                    diemDTO.hocSinh = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    diemDTO.monHoc = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    diemDTO.hocKy = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    diemDTO.diemTX = (float)dr.GetDouble(3);
                if (!dr.IsDBNull(4))
                    diemDTO.diemKT1 = (float)dr.GetDouble(4);
                if (!dr.IsDBNull(5))
                    diemDTO.diemKT2 = (float)dr.GetDouble(5);
                if (!dr.IsDBNull(6))
                    diemDTO.diemThi = (float)dr.GetDouble(6);
                if (!dr.IsDBNull(7))
                    diemDTO.diemTB = (float)dr.GetDouble(7);

                diemDTOs.Add(diemDTO);
            }
            dr.Close();
            conn.Close();

            return diemDTOs;
        }
        public List<DiemDTO> LayDSDiemLopHocVaHocKy(string lopHoc, string hocKy)
        {
            List<DiemDTO> diemDTOs = new List<DiemDTO>();
            string sCauTruyVan = "SELECT D.hocSinh, M.tenMonHoc, HK.tenHocKy, D.diemTX, D.diemKT1, D.diemKT2, D.diemThi, D.DiemTB ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "JOIN MonHoc M ON D.monHoc = M.maMonHoc ";
            sCauTruyVan += "JOIN HocKy HK ON D.hocKy = HK.maHocKy ";
            sCauTruyVan += " WHERE L.maLop = @lopHoc AND D.hocKy = @hocKy";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

            cmd.Parameters.AddWithValue("@lopHoc", lopHoc);
            cmd.Parameters.AddWithValue("@hocKy", hocKy);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DiemDTO diemDTO = new DiemDTO();
                if (!dr.IsDBNull(0))
                    diemDTO.hocSinh = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    diemDTO.monHoc = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    diemDTO.hocKy = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    diemDTO.diemTX = (float)dr.GetDouble(3);
                if (!dr.IsDBNull(4))
                    diemDTO.diemKT1 = (float)dr.GetDouble(4);
                if (!dr.IsDBNull(5))
                    diemDTO.diemKT2 = (float)dr.GetDouble(5);
                if (!dr.IsDBNull(6))
                    diemDTO.diemThi = (float)dr.GetDouble(6);
                if (!dr.IsDBNull(7))
                    diemDTO.diemTB = (float)dr.GetDouble(7);

                diemDTOs.Add(diemDTO);
            }
            dr.Close();
            conn.Close();

            return diemDTOs;
        }
        public List<DiemDTO> LayDSDiemTheoMaHSMonHocVaHocKy(string hocSinh, string monHoc, string hocKy)
        {
            List<DiemDTO> lstDiem = new List<DiemDTO>() ;
            string sCauTruyVan = "SELECT D.hocSinh, M.tenMonHoc, HK.tenHocKy, D.diemTX, D.diemKT1, D.diemKT2, D.diemThi, D.DiemTB ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "JOIN MonHoc M ON D.monHoc = M.maMonHoc ";
            sCauTruyVan += "JOIN HocKy HK ON D.hocKy = HK.maHocKy ";
            sCauTruyVan += "WHERE D.hocSinh = @hocSinh AND D.monHoc = @monHoc AND D.hocKy = @hocKy";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

            cmd.Parameters.AddWithValue("@hocSinh", hocSinh);
            cmd.Parameters.AddWithValue("@monHoc", monHoc);
            cmd.Parameters.AddWithValue("@hocKy", hocKy);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DiemDTO diemDTO = new DiemDTO();
                if (!dr.IsDBNull(0))
                    diemDTO.hocSinh = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    diemDTO.monHoc = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    diemDTO.hocKy = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    diemDTO.diemTX = (float)dr.GetDouble(3);
                if (!dr.IsDBNull(4))
                    diemDTO.diemKT1 = (float)dr.GetDouble(4);
                if (!dr.IsDBNull(5))
                    diemDTO.diemKT2 = (float)dr.GetDouble(5);
                if (!dr.IsDBNull(6))
                    diemDTO.diemThi = (float)dr.GetDouble(6);
                if (!dr.IsDBNull(7))
                    diemDTO.diemTB = (float)dr.GetDouble(7);

                lstDiem.Add(diemDTO);
            }
            dr.Close();
            conn.Close();

            return lstDiem;
        }
        public List<DiemDTO> LayDSDiemTheoLopMonHocVaHocKy(string lopHoc, string monHoc, string hocKy)
        {
            List<DiemDTO> lstDiem = new List<DiemDTO>();
            string sCauTruyVan = "SELECT D.hocSinh, M.tenMonHoc, HK.tenHocKy, D.diemTX, D.diemKT1, D.diemKT2, D.diemThi, D.DiemTB ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "JOIN MonHoc M ON D.monHoc = M.maMonHoc ";
            sCauTruyVan += "JOIN HocKy HK ON D.hocKy = HK.maHocKy ";
            sCauTruyVan += "WHERE L.maLop = @lopHoc AND D.monHoc = @monHoc AND D.hocKy = @hocKy";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

            cmd.Parameters.AddWithValue("@lopHoc", lopHoc );
            cmd.Parameters.AddWithValue("@monHoc", monHoc);
            cmd.Parameters.AddWithValue("@hocKy", hocKy);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DiemDTO diemDTO = new DiemDTO();
                if (!dr.IsDBNull(0))
                    diemDTO.hocSinh = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    diemDTO.monHoc = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    diemDTO.hocKy = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    diemDTO.diemTX = (float)dr.GetDouble(3);
                if (!dr.IsDBNull(4))
                    diemDTO.diemKT1 = (float)dr.GetDouble(4);
                if (!dr.IsDBNull(5))
                    diemDTO.diemKT2 = (float)dr.GetDouble(5);
                if (!dr.IsDBNull(6))
                    diemDTO.diemThi = (float)dr.GetDouble(6);
                if (!dr.IsDBNull(7))
                    diemDTO.diemTB = (float)dr.GetDouble(7);

                lstDiem.Add(diemDTO);
            }
            dr.Close();
            conn.Close();

            return lstDiem;
        }
        public List<DiemTrungBinhDTO> TinhDiemTrungBinhHocKy(string hocKy1)
        {
            List<DiemTrungBinhDTO> lstDiemTrungBinh = new List<DiemTrungBinhDTO>();

            string sCauTruyVan = "SELECT D.hocSinh, ROUND(AVG(D.DiemTB), 1) AS DiemTrungBinh ";
            sCauTruyVan += "FROM Diem D ";
            sCauTruyVan += "JOIN HocSinh H ON D.hocSinh = H.maHS ";
            sCauTruyVan += "WHERE H.trangThai = '1' AND D.hocKy = @hocKy ";
            sCauTruyVan += "GROUP BY D.hocSinh;";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);

            // Gán giá trị tham số
            cmd.Parameters.AddWithValue("@hocKy", hocKy1);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DiemTrungBinhDTO diemTrungBinh = new DiemTrungBinhDTO();
                if (!dr.IsDBNull(0))
                    diemTrungBinh.hocSinh = dr.GetString(0);
                if (!dr.IsDBNull(1))
                {
                    // Sử dụng GetDouble hoặc GetDecimal thay vì GetFloat
                    diemTrungBinh.diemTBHocKy= (float)dr.GetDouble(1); // hoặc (float)dr.GetDecimal(1)
                }

                lstDiemTrungBinh.Add(diemTrungBinh);
            }
            dr.Close();
            conn.Close();

            return lstDiemTrungBinh;
        }
        public void XoaDiemHS(string hocSinh, string monHoc)
        {
            try
            {
                string sSQL = "DELETE FROM Diem WHERE hocSinh = @hocSinh AND monHoc = @monHoc";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@hocSinh", hocSinh);
                cmd.Parameters.AddWithValue("@monHoc", monHoc);

                int kq = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
