using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAO
{
    public class HocSinhDAO
    {
        // Lấy danh sách học sinh(tất cả học sinh ở trạng thái 1)
        public List<HocSinhDTO> LayDSHS()
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE H.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();

                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);

                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//xong
        public List<HocSinhDTO> LayDSHSTheoTrangThai(string trangThai)
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE  H.trangThai = N'"+ trangThai+"'";
            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();
                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);
                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<HocSinhDTO> LayDSHSTheoNamHoc(string namHoc)
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE  L.namHoc = '" + namHoc + "'";
            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();
                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);
                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public List<HocSinhDTO> TimKiemHocSinh_TheoMaHS(string maHS)
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE H.maHS LIKE '%' + @maHS + '%' AND H.trangThai = '1' ";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@maHS", maHS);
            
            SqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();
                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);
                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//xong
        public List<HocSinhDTO> TimKiemHocSinh_TheoTenHS(string tenHS)
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE H.hoHS + ' ' + H.tenHS LIKE '%' + @tenHS + '%' AND H.trangThai = '1'";
            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@tenHS", tenHS);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();
                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);
                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//xong
        public List<HocSinhDTO> TimKiemHocSinh_TheoKhoi(string lop)
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
            sCauTruyVan += "FROM HocSinh H ";
            sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
            sCauTruyVan += "WHERE L.tenLop  LIKE '%" + lop + "%' AND H.trangThai = '1'";
            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                HocSinhDTO hocSinhDTO = new HocSinhDTO();
                if (!dr.IsDBNull(0))
                    hocSinhDTO.maHS = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    hocSinhDTO.cccd = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    hocSinhDTO.hoHS = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    hocSinhDTO.tenHS = dr.GetString(3);
                if (!dr.IsDBNull(4))
                    hocSinhDTO.gioiTinh = dr.GetInt32(4);
                if (!dr.IsDBNull(5))
                    hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                if (!dr.IsDBNull(6))
                    hocSinhDTO.queQuan = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    hocSinhDTO.soDT = dr.GetString(7);
                if (!dr.IsDBNull(8))
                    hocSinhDTO.mail = dr.GetString(8);
                if (!dr.IsDBNull(9))
                    hocSinhDTO.lop = dr.GetString(9);
                if (!dr.IsDBNull(10))
                    hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                if (!dr.IsDBNull(11))
                    hocSinhDTO.trangThai = dr.GetString(11);
                lst.Add(hocSinhDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//xong
        public bool CapNhatThongTinHocSinh(HocSinhDTO hocSinhDTO)
        {
            bool ketQua = true;
            try
            {
                string sSQL = "UPDATE HocSinh SET ";
                sSQL += "hoHS = N'" + hocSinhDTO.hoHS + "', ";
                sSQL += "tenHS = N'" + hocSinhDTO.tenHS + "', ";
                sSQL += "soDT = '" + hocSinhDTO.soDT + "', ";
                sSQL += "queQuan = N'" + hocSinhDTO.queQuan + "' ";
                sSQL += "WHERE maHS = '" + hocSinhDTO.maHS + "'";

                SqlConnection conn = DataProvider.KetNoiCSDL();
               
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                if( kq == 0 )
                {
                    ketQua = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ketQua;
        }//xong
        public bool XoaHocSinh(string maHS)
        {
            bool xoa = true;
            try
            {
                string sSQL = "UPDATE HocSinh SET trangThai = N'Xóa' WHERE maHS = '" + maHS + "'";
                SqlConnection conn = DataProvider.KetNoiCSDL();
               
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                if( kq == 0 )
                {
                    xoa = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return xoa;
        }//xong
        public bool KhoiPhucHocSinhDaXoa(string maHS)
        {
            bool res = true;
            try
            {
                string sSQL = "UPDATE HocSinh SET trangThai = '1' WHERE maHS = '" + maHS + "'";
                SqlConnection conn = DataProvider.KetNoiCSDL();
              
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                if( kq == 0)
                {
                    res = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }//xong
        public bool AddHocSinh(string maHS, string cccd, string hoHS, string tenHS, int gioiTinh, DateTime ngaySinh, string queQuan, string soDT, string mail, string lop, DateTime namNhapHoc, string trangThai)
        {
            bool ketQua = true;
            try
            {
                string sSQL = "INSERT INTO HocSinh VALUES(";
                sSQL += "'" + maHS + "',";
                sSQL += "'" + cccd + "',";
                sSQL += "N'" + hoHS + "',";
                sSQL += "N'" + tenHS + "',";
                sSQL += gioiTinh + ",";
                sSQL += "'" + ngaySinh.ToString("yyyy-MM-dd") + "',"; 
                sSQL += "N'" + queQuan + "',";
                sSQL += "'" + soDT + "',";
                sSQL += "'" + mail + "',";
                sSQL += "'" + lop + "',";
                sSQL += "'" + namNhapHoc.ToString("yyyy-MM-dd") + "',"; 
                sSQL += "N'" + trangThai + "',";
                sSQL += " '')";


                SqlConnection connection = DataProvider.KetNoiCSDL();
                int them = DataProvider.ThucThiTruyVan(sSQL, connection);
                if (them == 0)
                {
                    ketQua = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ketQua;
        }
        //hiển thị thông tin vào trang học sinh.
        public HocSinhDTO HienThiThongTinHocSinh(string maHS)
        {
            HocSinhDTO hocSinhDTO = null; // Khởi tạo đối tượng HocSinhDTO
            try
            {
                string sCauTruyVan = "SELECT H.maHS, H.cccd, H.hoHS, H.tenHS, H.gioiTinh, H.ngaySinh, H.queQuan, H.soDT, H.mail, L.tenLop, H.namNhapHoc, H.trangThai ";
                sCauTruyVan += "FROM HocSinh H ";
                sCauTruyVan += "INNER JOIN LopHoc L ON H.lop = L.maLop ";
                sCauTruyVan += "WHERE H.maHS LIKE '%' + @maHS + '%' AND H.trangThai = '1' ";

                SqlConnection conn = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
                cmd.Parameters.AddWithValue("@maHS", maHS);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    hocSinhDTO = new HocSinhDTO();
                    if (!dr.IsDBNull(0))
                        hocSinhDTO.maHS = dr.GetString(0);
                    if (!dr.IsDBNull(1))
                        hocSinhDTO.cccd = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        hocSinhDTO.hoHS = dr.GetString(2);
                    if (!dr.IsDBNull(3))
                        hocSinhDTO.tenHS = dr.GetString(3);
                    if (!dr.IsDBNull(4))
                        hocSinhDTO.gioiTinh = dr.GetInt32(4);
                    if (!dr.IsDBNull(5))
                        hocSinhDTO.ngaySinh = dr.GetDateTime(5);
                    if (!dr.IsDBNull(6))
                        hocSinhDTO.queQuan = dr.GetString(6);
                    if (!dr.IsDBNull(7))
                        hocSinhDTO.soDT = dr.GetString(7);
                    if (!dr.IsDBNull(8))
                        hocSinhDTO.mail = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        hocSinhDTO.lop = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        hocSinhDTO.namNhapHoc = dr.GetDateTime(10);
                    if (!dr.IsDBNull(11))
                        hocSinhDTO.trangThai = dr.GetString(11);
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hocSinhDTO;
        }
        public bool KiemTraMaHocSinhTrung(string maHocSinh)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM HocSinh WHERE maHS = '"+maHocSinh+"' ";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(query, connection);

                // Sử dụng ExecuteScalar để lấy giá trị đầu tiên từ kết quả truy vấn
                // và ép kiểu sang kiểu số nguyên
                int count = (int)command.ExecuteScalar();

                // Trả về true nếu có ít nhất một học sinh có mã trùng
                return count > 0;
            }catch(Exception ex) 
            {
                throw ex; 
            }
        }
        public bool KiemTraCCCDTrung(string cccd)
        {
            try
            {
                string sCauTruyVan = "SELECT COUNT(*) FROM HocSinh WHERE cccd = '"+cccd+"'";
                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);
                int cout = (int)command.ExecuteScalar();

                return cout > 0;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DemSoLuongHocSinhTrangThai1(string maHS)
        {
            int soLuong = 0;
            try
            {
                string sCauTruyVan = "SELECT COUNT(*) FROM HocSinh WHERE trangThai = '1' AND maHS = @MaHS";
                SqlConnection sqlConnection = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sCauTruyVan, sqlConnection);
                cmd.Parameters.AddWithValue("@MaHS", maHS);
                soLuong = (int)cmd.ExecuteScalar();

            }
            catch(Exception ex) 
            { 
                throw ex;
            }
            return soLuong;
        }
        public int DemSoLuongHocSinhTheoKhoi(string khoi)
        {
            int soLuong = 0;
            try
            {
                string sCauTruyVan = "SELECT COUNT(maHS) FROM HocSinh WHERE trangThai = '1' AND lop LIKE '%' + @Khoi + '%'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);

                command.Parameters.AddWithValue("@khoi", khoi);

                soLuong = (int)command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return soLuong;
        }
        public int DemSoLuongHocSinhTrongLichThi(string khoi, string monHoc)
        {
            int soLuong = 0;

            try
            {
                string sCauTruyVan = "SELECT COUNT(L.hocSinh) FROM LichThi L ";
                sCauTruyVan += " JOIN HocSinh H ON L.hocSinh = H.maHS ";
                sCauTruyVan += " WHERE L.trangThai = '1'  AND L.monThi = @monHoc AND H.lop LIKE '%' + @Khoi + '%'";


                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand command = new SqlCommand(sCauTruyVan, connection);

                command.Parameters.AddWithValue("@khoi", khoi);
                command.Parameters.AddWithValue("@monHoc", monHoc);

                soLuong = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return soLuong;
        }
    }
}

