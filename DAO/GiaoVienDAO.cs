using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVienDAO
    {
        public List<GiaoVienDTO> LayDSGV()
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.cccd, GV.hoGV, GV.tenGV, GV.gioiTinh, GV.ngaySinh, GV.queQuan, GV.soDT, GV.mail, B.tenBangCap, GV.ngayVao, C.tenChucVu, GV.trangThai ";
            sCauTruyVan += "FROM GiaoVien GV ";
            sCauTruyVan += "INNER JOIN BangCap B ON GV.bangCap = B.maBangCap ";
            sCauTruyVan += "INNER JOIN ChucVu C ON GV.chucVu = C.maChucVu ";
            sCauTruyVan += "WHERE GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    giaoVienDTO.hoGV = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    giaoVienDTO.tenGV = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    giaoVienDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    giaoVienDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    giaoVienDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    giaoVienDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    giaoVienDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    giaoVienDTO.bangCap = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    giaoVienDTO.ngayVao = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    giaoVienDTO.chucVu = dr.GetString(11);
                if (!dr.IsDBNull(12))
                    giaoVienDTO.trangThai = dr.GetString(12);
                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<GiaoVienDTO> LayDSGVPhanCongTheoMonDay(string monDay)
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.hoGV + ' ' + GV.tenGV as hoTen ";
            sCauTruyVan += " FROM PhanCongGiangDay PC ";
            sCauTruyVan += " JOIN GiaoVien GV ON PC.giaoVien = GV.maGV ";
            sCauTruyVan += " WHERE PC.monDay = '"+monDay+"'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.tenGV = dr.GetString(1);

                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<GiaoVienDTO> LayDSGVLenCombobox()
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.hoGV + ' ' + GV.tenGV as hoTen ";
            sCauTruyVan += "FROM GiaoVien GV ";

            sCauTruyVan += "WHERE GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.tenGV = dr.GetString(1);

                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<GiaoVienDTO> LayDSGVChuaChuNhiem()
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.hoGV + ' ' + GV.tenGV AS hoTen ";
            sCauTruyVan += "FROM GiaoVien GV ";
            sCauTruyVan += "LEFT JOIN LopHoc LH ON GV.maGV = LH.giaoVienCN ";
            sCauTruyVan += "WHERE LH.maLop IS NULL ";
            sCauTruyVan += "AND GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.tenGV = dr.GetString(1);

                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }

        public GiaoVienDTO LayDuLieuTuDataGridView(string maGV, string cccd, string hoGV, string tenGV, int gioiTinh, DateTime ngaySinh, string queQuan, string soDT, string mail, string bangCap, DateTime ngayVao, string chucVu, string trangThai)
        {
            GiaoVienDTO giaoVienDTO = new GiaoVienDTO();

            giaoVienDTO.maGV = maGV;
            giaoVienDTO.cccd = cccd;
            giaoVienDTO.hoGV = hoGV;
            giaoVienDTO.tenGV = tenGV;
            giaoVienDTO.gioiTinh = gioiTinh;
            giaoVienDTO.ngaySinh = ngaySinh;
            giaoVienDTO.queQuan = queQuan;
            giaoVienDTO.soDT = soDT;
            giaoVienDTO.mail = mail;
            giaoVienDTO.bangCap = bangCap;
            giaoVienDTO.ngayVao = ngayVao;
            giaoVienDTO.chucVu = chucVu;
            giaoVienDTO.trangThai = trangThai;

            return giaoVienDTO;
        }
        public List<GiaoVienDTO> TimKiemGiaoVien_TheoMaGV(string maGV)
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.cccd, GV.hoGV, GV.tenGV, GV.gioiTinh, GV.ngaySinh, GV.queQuan, GV.soDT, GV.mail, B.tenBangCap, GV.ngayVao, C.tenChucVu, GV.trangThai ";
            sCauTruyVan += "FROM GiaoVien GV ";
            sCauTruyVan += "INNER JOIN BangCap B ON GV.bangCap = B.maBangCap ";
            sCauTruyVan += "INNER JOIN ChucVu C ON GV.chucVu = C.maChucVu ";
            sCauTruyVan += "WHERE GV.maGV LIKE '%' + @maGV + '%' AND GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@maGV",maGV);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    giaoVienDTO.hoGV = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    giaoVienDTO.tenGV = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    giaoVienDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    giaoVienDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    giaoVienDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    giaoVienDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    giaoVienDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    giaoVienDTO.bangCap = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    giaoVienDTO.ngayVao = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    giaoVienDTO.chucVu = dr.GetString(11);
                if (!dr.IsDBNull(12))
                    giaoVienDTO.trangThai = dr.GetString(12);
                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<GiaoVienDTO> TimKiemGiaoVien_TheoTenGV(string hoTen)
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            string sCauTruyVan = "SELECT GV.maGV, GV.cccd, GV.hoGV, GV.tenGV, GV.gioiTinh, GV.ngaySinh, GV.queQuan, GV.soDT, GV.mail, B.tenBangCap, GV.ngayVao, C.tenChucVu, GV.trangThai ";
            sCauTruyVan += "FROM GiaoVien GV ";
            sCauTruyVan += "INNER JOIN BangCap B ON GV.bangCap = B.maBangCap ";
            sCauTruyVan += "INNER JOIN ChucVu C ON GV.chucVu = C.maChucVu ";
            sCauTruyVan += "WHERE GV.hoGV + ' '+ GV.tenGV LIKE '%' + @hoTen + '%' AND GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                if (!dr.IsDBNull(0))
                    giaoVienDTO.maGV = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    giaoVienDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    giaoVienDTO.hoGV = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    giaoVienDTO.tenGV = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    giaoVienDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    giaoVienDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    giaoVienDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    giaoVienDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    giaoVienDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    giaoVienDTO.bangCap = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    giaoVienDTO.ngayVao = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    giaoVienDTO.chucVu = dr.GetString(11);
                if (!dr.IsDBNull(12))
                    giaoVienDTO.trangThai = dr.GetString(12);
                lst.Add(giaoVienDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public void CapNhatThongTinGiaoVien(GiaoVienDTO giaoVienDTO)
        {
           
            try
            {
                string sSQL = "UPDATE GiaoVien SET ";
                sSQL += "hoGV = N'" + giaoVienDTO.hoGV + "', ";
                sSQL += "tenGv = N'" + giaoVienDTO.tenGV + "', ";
                sSQL += "soDT = '" + giaoVienDTO.soDT + "', ";
                sSQL += "queQuan = N'" + giaoVienDTO.queQuan + "', ";
                sSQL += "mail = N'" + giaoVienDTO.mail + "'";
                sSQL += "WHERE maGV = '" + giaoVienDTO.maGV + "'";

                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void XoaGiaoVien(string maGV)
        {
            try
            {
                string sSQL = "UPDATE GiaoVien SET trangThai = '2' WHERE maGV = '" + maGV + "'";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void KhoiPhucGiaoVienDaXoa(string maGV)
        {
            try
            {
                string sSQL = "UPDATE GiaoVien SET trangThai = '1' WHERE maGV = '" + maGV + "'";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GiaoVienDTO HienThiThongTinGiaoVien(string maGV)
        {
            //Guid hocSinhDTO = null; // Khởi tạo đối tượng HocSinhDTO
            GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
            try
            {
                string sCauTruyVan = "SELECT GV.maGV, GV.cccd, GV.hoGV, GV.tenGV, GV.gioiTinh, GV.ngaySinh, GV.queQuan, GV.soDT, GV.mail, B.tenBangCap, GV.ngayVao, C.tenChucVu, GV.trangThai ";
                sCauTruyVan += "FROM GiaoVien GV ";
                sCauTruyVan += "INNER JOIN BangCap B ON GV.bangCap = B.maBangCap ";
                sCauTruyVan += "INNER JOIN ChucVu C ON GV.chucVu = C.maChucVu ";
                sCauTruyVan += "WHERE GV.maGV LIKE '%' + @maGV + '%' AND GV.trangThai = '1' ";

                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
                cmd.Parameters.AddWithValue("@maGV", maGV);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Khởi tạo đối tượng HocSinhDTO nếu có dữ liệu trả về từ SqlDataReader
                    //GiaoVienDTO giaoVienDTO = new GiaoVienDTO();

                    // Gán giá trị cho các thuộc tính của HocSinhDTO từ dữ liệu trong SqlDataReader
                    if (!dr.IsDBNull(0))
                        giaoVienDTO.maGV = dr.GetString(0);
                    if (!dr.IsDBNull(1))
                        giaoVienDTO.cccd = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        giaoVienDTO.hoGV = dr.GetString(2);
                    if (!dr.IsDBNull(3))
                        giaoVienDTO.tenGV = dr.GetString(3);
                    if (!dr.IsDBNull(4))
                        giaoVienDTO.gioiTinh = dr.GetInt32(4);
                    if (!dr.IsDBNull(5))
                        giaoVienDTO.ngaySinh = dr.GetDateTime(5);
                    if (!dr.IsDBNull(6))
                        giaoVienDTO.queQuan = dr.GetString(6);
                    if (!dr.IsDBNull(7))
                        giaoVienDTO.soDT = dr.GetString(7);
                    if (!dr.IsDBNull(8))
                        giaoVienDTO.mail = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        giaoVienDTO.bangCap = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        giaoVienDTO.ngayVao = dr.GetDateTime(10);
                    if (!dr.IsDBNull(11))
                        giaoVienDTO.chucVu = dr.GetString(11);
                    if (!dr.IsDBNull(12))
                        giaoVienDTO.trangThai = dr.GetString(12);
                 
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return giaoVienDTO ;
        }
    }
}
