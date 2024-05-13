using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanCongGiangDayDAO
    {
        public List<PhanCongGiangDayDTO> LayDSPhanCongGiangDay()
        {
           List<PhanCongGiangDayDTO>lst = new List<PhanCongGiangDayDTO> ();

            string sCauTruyVan = "SELECT PC.maPhanCong, PC.giaoVien, GV.hoGV + ' ' + tenGV AS hoTen, M.tenMonHoc ";
            sCauTruyVan += "FROM PhanCongGiangDay PC ";
            sCauTruyVan += "INNER JOIN MonHoc M on PC.monDay = M.maMonHoc ";
            sCauTruyVan += "INNER JOIN GiaoVien GV on PC.giaoVien = GV.maGV ";
            // sCauTruyVan += "WHERE H.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                PhanCongGiangDayDTO phanCongGiangDayDTO = new PhanCongGiangDayDTO();
                if (!dr.IsDBNull(0))
                    phanCongGiangDayDTO.maPhanCong = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    phanCongGiangDayDTO.giaoVien = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    phanCongGiangDayDTO.moTa = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    phanCongGiangDayDTO.monDay = dr.GetString(3);
                lst.Add(phanCongGiangDayDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//Đã xong
       
        public List<PhanCongGiangDayDTO> TimKiemPhanCong_TheoMonHoc(string monHoc)
        {
            List<PhanCongGiangDayDTO> lst = new List<PhanCongGiangDayDTO>();

            string sCauTruyVan = "SELECT PC.maPhanCong, PC.giaoVien, GV.hoGV + ' ' + tenGV AS hoTen, M.tenMonHoc ";
            sCauTruyVan += "FROM PhanCongGiangDay PC ";
            sCauTruyVan += "INNER JOIN MonHoc M on PC.monDay = M.maMonHoc ";
            sCauTruyVan += "INNER JOIN GiaoVien GV on PC.giaoVien = GV.maGV ";
            sCauTruyVan += "WHERE PC.monDay LIKE '%" + @monHoc + "%' AND GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan,conn);

            while (dr.Read())
            {
                PhanCongGiangDayDTO phanCongGiangDayDTO = new PhanCongGiangDayDTO();
                if (!dr.IsDBNull(0))
                    phanCongGiangDayDTO.maPhanCong = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    phanCongGiangDayDTO.giaoVien = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    phanCongGiangDayDTO.moTa = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    phanCongGiangDayDTO.monDay = dr.GetString(3);
                lst.Add(phanCongGiangDayDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }//Đã xong
        public List<PhanCongGiangDayDTO> TimKiemPhanCong_TheoGiaoVien(string giaoVien)
        {
            List<PhanCongGiangDayDTO> lst = new List<PhanCongGiangDayDTO>();

            string sCauTruyVan = "SELECT PC.maPhanCong, PC.giaoVien, GV.hoGV + ' ' + tenGV AS hoTen, M.tenMonHoc ";
            sCauTruyVan += "FROM PhanCongGiangDay PC ";
            sCauTruyVan += "INNER JOIN MonHoc M on PC.monDay = M.maMonHoc ";
            sCauTruyVan += "INNER JOIN GiaoVien GV on PC.giaoVien = GV.maGV ";
            sCauTruyVan += "WHERE PC.giaoVien LIKE '%" + @giaoVien + "%' AND GV.trangThai = '1'";

            SqlConnection conn = DataProvider.KetNoiCSDL();
           
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                PhanCongGiangDayDTO phanCongGiangDayDTO = new PhanCongGiangDayDTO();
                if (!dr.IsDBNull(0))
                    phanCongGiangDayDTO.maPhanCong = dr.GetInt32(0);
                if (!dr.IsDBNull(1))
                    phanCongGiangDayDTO.giaoVien = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    phanCongGiangDayDTO.moTa = dr.GetString(2);
                if (!dr.IsDBNull(3))
                    phanCongGiangDayDTO.monDay = dr.GetString(3);
                lst.Add(phanCongGiangDayDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public bool CapNhatPhanCongGiaoVien(string giaoVien, string monDay, int maPhanCong)
        {
            bool capNhat = true;
            try
            {
                string sSQL = "UPDATE PhanCongGiangDay SET ";
                sSQL += " monDay = N'" + monDay + "', ";
                sSQL += " giaoVien = N'" + giaoVien + "'";
                sSQL += " WHERE maPhanCong = " + maPhanCong + "";

                SqlConnection conn = DataProvider.KetNoiCSDL();
               
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                if(kq == 0)
                {
                    capNhat = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return capNhat;
        }//Xong
        // xóa
        public bool KiemTraPhanCongGiaoVien(string giaoVien, string monDay)
        {
          
            try
            {
                string sCauTruyVan = " SELECT COUNT(*) FROM PhanCongGiangDay WHERE giaoVien = '" + giaoVien + "' AND monDay ='" + monDay + "'";
                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sCauTruyVan, connection);

                int cout =(int) cmd.ExecuteScalar();
                return cout > 0;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaPhanCongGiaoVienGiangDay(string giaoVien, string monDay)
        {
            bool xoa = true;
            try
            {
                string sSQL = "DELETE PhanCongGiangDay WHERE giaoVien = '" + giaoVien + "' AND monDay = '"+monDay+"'";
                SqlConnection conn = DataProvider.KetNoiCSDL();
                int kq = DataProvider.ThucThiTruyVan(sSQL, conn);
                if(kq == 0)
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
        }
        public bool ThemPhanCongGiaoVien(string giaoVien, string monDay)
        {
            bool add = true;
            try
            {
                string sSQL = "INSERT INTO PhanCongGiangDay (giaoVien, monDay ) ";
                sSQL += "VALUES ('"+giaoVien+"', '"+monDay+"' )";

                SqlConnection conn = DataProvider.KetNoiCSDL();
                int them = DataProvider.ThucThiTruyVan(sSQL,conn);
                if(them == 0)
                {
                    add = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return add;
        }
    }
}
