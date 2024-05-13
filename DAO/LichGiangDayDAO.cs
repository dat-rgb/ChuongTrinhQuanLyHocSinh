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
    public class LichGiangDayDAO
    {
        public List<LichGiangDayDTO> LayDSLichGiangDay()
        {
            List<LichGiangDayDTO>lst = new List<LichGiangDayDTO>();
            try
            {
                string sCauTruyVan = "SELECT LGD.maLich, LGD.Thu, LGD.ngayBatDau, LGD.ngayKetThuc, M.tenMonHoc, LGD.buoi, LGD.tietBD, LGD.tietKT, L.tenLop, GV.hoGV+' '+GV.tenGV as hoTen, LGD.trangThai";
                sCauTruyVan += " FROM LichGiangDay LGD";
                sCauTruyVan += " JOIN GiaoVien GV ON LGD.giaoVien = GV.maGV";
                sCauTruyVan += " JOIN MonHoc M ON LGD.monHoc = M.maMonHoc";
                sCauTruyVan += " JOIN LopHoc L ON LGD.lop = L.maLop";
                sCauTruyVan += " WHERE LGD.trangThai = '1'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, connection);

                while (dr.Read())
                {
                    LichGiangDayDTO lichGiangDayDTO = new LichGiangDayDTO();
                    if (!dr.IsDBNull(0))
                        lichGiangDayDTO.maLich = dr.GetInt32(0);
                    if (!dr.IsDBNull(1))
                        lichGiangDayDTO.thu = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        lichGiangDayDTO.ngayBatDau = dr.GetDateTime(2);
                    if (!dr.IsDBNull(3))
                        lichGiangDayDTO.ngayKetThuc = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        lichGiangDayDTO.monHoc = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        lichGiangDayDTO.buoi = dr.GetInt32(5);
                    if (!dr.IsDBNull(6))
                        lichGiangDayDTO.tietBatDau = dr.GetInt32(6);
                    if (!dr.IsDBNull(7))
                        lichGiangDayDTO.tietKetThuc = dr.GetInt32(7);
                    if (!dr.IsDBNull(8))
                        lichGiangDayDTO.lop = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        lichGiangDayDTO.giaoVien = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        lichGiangDayDTO.trangThai = dr.GetString(10);
                    lst.Add(lichGiangDayDTO);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            return lst;
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoTrangThai(string trangThai)
        {
            List<LichGiangDayDTO> lst = new List<LichGiangDayDTO>();
            try
            {
                string sCauTruyVan = "SELECT LGD.maLich, LGD.Thu, LGD.ngayBatDau, LGD.ngayKetThuc, M.tenMonHoc, LGD.buoi, LGD.tietBD, LGD.tietKT, L.tenLop, GV.hoGV+' '+GV.tenGV as hoTen, LGD.trangThai";
                sCauTruyVan += " FROM LichGiangDay LGD";
                sCauTruyVan += " JOIN GiaoVien GV ON LGD.giaoVien = GV.maGV";
                sCauTruyVan += " JOIN MonHoc M ON LGD.monHoc = M.maMonHoc";
                sCauTruyVan += " JOIN LopHoc L ON LGD.lop = L.maLop";
                sCauTruyVan += " WHERE LGD.trangThai = N'"+trangThai+"'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, connection);

                while (dr.Read())
                {
                    LichGiangDayDTO lichGiangDayDTO = new LichGiangDayDTO();
                    if (!dr.IsDBNull(0))
                        lichGiangDayDTO.maLich = dr.GetInt32(0);
                    if (!dr.IsDBNull(1))
                        lichGiangDayDTO.thu = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        lichGiangDayDTO.ngayBatDau = dr.GetDateTime(2);
                    if (!dr.IsDBNull(3))
                        lichGiangDayDTO.ngayKetThuc = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        lichGiangDayDTO.monHoc = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        lichGiangDayDTO.buoi = dr.GetInt32(5);
                    if (!dr.IsDBNull(6))
                        lichGiangDayDTO.tietBatDau = dr.GetInt32(6);
                    if (!dr.IsDBNull(7))
                        lichGiangDayDTO.tietKetThuc = dr.GetInt32(7);
                    if (!dr.IsDBNull(8))
                        lichGiangDayDTO.lop = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        lichGiangDayDTO.giaoVien = dr.GetString(9);
                    if(!dr.IsDBNull(10))
                        lichGiangDayDTO.trangThai = dr.GetString(10);
                    lst.Add(lichGiangDayDTO);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            return lst;
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoLop(string lop, string trangThai)
        {
            List<LichGiangDayDTO> lst = new List<LichGiangDayDTO>();
            try
            {
                string sCauTruyVan = "SELECT LGD.maLich, LGD.Thu, LGD.ngayBatDau, LGD.ngayKetThuc, M.tenMonHoc, LGD.buoi, LGD.tietBD, LGD.tietKT, L.tenLop, GV.hoGV+' '+GV.tenGV as hoTen, LGD.trangThai";
                sCauTruyVan += " FROM LichGiangDay LGD";
                sCauTruyVan += " JOIN GiaoVien GV ON LGD.giaoVien = GV.maGV";
                sCauTruyVan += " JOIN MonHoc M ON LGD.monHoc = M.maMonHoc";
                sCauTruyVan += " JOIN LopHoc L ON LGD.lop = L.maLop";
                sCauTruyVan += " WHERE LGD.lop = N'" + lop + "' AND LGD.trangThai = N'"+trangThai+"'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, connection);

                while (dr.Read())
                {
                    LichGiangDayDTO lichGiangDayDTO = new LichGiangDayDTO();
                    if (!dr.IsDBNull(0))
                        lichGiangDayDTO.maLich = dr.GetInt32(0);
                    if (!dr.IsDBNull(1))
                        lichGiangDayDTO.thu = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        lichGiangDayDTO.ngayBatDau = dr.GetDateTime(2);
                    if (!dr.IsDBNull(3))
                        lichGiangDayDTO.ngayKetThuc = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        lichGiangDayDTO.monHoc = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        lichGiangDayDTO.buoi = dr.GetInt32(5);
                    if (!dr.IsDBNull(6))
                        lichGiangDayDTO.tietBatDau = dr.GetInt32(6);
                    if (!dr.IsDBNull(7))
                        lichGiangDayDTO.tietKetThuc = dr.GetInt32(7);
                    if (!dr.IsDBNull(8))
                        lichGiangDayDTO.lop = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        lichGiangDayDTO.giaoVien = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        lichGiangDayDTO.trangThai = dr.GetString(10);
                    lst.Add(lichGiangDayDTO);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            return lst;
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoMonHoc(string monHoc, string trangThai)
        {
            List<LichGiangDayDTO> lst = new List<LichGiangDayDTO>();
            try
            {
                string sCauTruyVan = "SELECT LGD.maLich, LGD.Thu, LGD.ngayBatDau, LGD.ngayKetThuc, M.tenMonHoc, LGD.buoi, LGD.tietBD, LGD.tietKT, L.tenLop, GV.hoGV+' '+GV.tenGV as hoTen, LGD.trangThai";
                sCauTruyVan += " FROM LichGiangDay LGD";
                sCauTruyVan += " JOIN GiaoVien GV ON LGD.giaoVien = GV.maGV";
                sCauTruyVan += " JOIN MonHoc M ON LGD.monHoc = M.maMonHoc";
                sCauTruyVan += " JOIN LopHoc L ON LGD.lop = L.maLop";
                sCauTruyVan += " WHERE LGD.monHoc = N'" + monHoc + "' AND LGD.trangThai = N'" + trangThai + "'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, connection);

                while (dr.Read())
                {
                    LichGiangDayDTO lichGiangDayDTO = new LichGiangDayDTO();
                    if (!dr.IsDBNull(0))
                        lichGiangDayDTO.maLich = dr.GetInt32(0);
                    if (!dr.IsDBNull(1))
                        lichGiangDayDTO.thu = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        lichGiangDayDTO.ngayBatDau = dr.GetDateTime(2);
                    if (!dr.IsDBNull(3))
                        lichGiangDayDTO.ngayKetThuc = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        lichGiangDayDTO.monHoc = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        lichGiangDayDTO.buoi = dr.GetInt32(5);
                    if (!dr.IsDBNull(6))
                        lichGiangDayDTO.tietBatDau = dr.GetInt32(6);
                    if (!dr.IsDBNull(7))
                        lichGiangDayDTO.tietKetThuc = dr.GetInt32(7);
                    if (!dr.IsDBNull(8))
                        lichGiangDayDTO.lop = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        lichGiangDayDTO.giaoVien = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        lichGiangDayDTO.trangThai = dr.GetString(10);
                    lst.Add(lichGiangDayDTO);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            return lst;
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoMonHocGiaoVien(string monHoc, string giaoVien, string trangThai)
        {
             List<LichGiangDayDTO> lst = new List<LichGiangDayDTO>();
            try
            {
                string sCauTruyVan = "SELECT LGD.maLich, LGD.Thu, LGD.ngayBatDau, LGD.ngayKetThuc, M.tenMonHoc, LGD.buoi, LGD.tietBD, LGD.tietKT, L.tenLop, GV.hoGV+' '+GV.tenGV as hoTen, LGD.trangThai";
                sCauTruyVan += " FROM LichGiangDay LGD";
                sCauTruyVan += " JOIN GiaoVien GV ON LGD.giaoVien = GV.maGV";
                sCauTruyVan += " JOIN MonHoc M ON LGD.monHoc = M.maMonHoc";
                sCauTruyVan += " JOIN LopHoc L ON LGD.lop = L.maLop";
                sCauTruyVan += " WHERE LGD.monHoc = N'" + monHoc + "' AND LGD.giaoVien = '"+giaoVien+ "' AND LGD.trangThai = N'" + trangThai + "'";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, connection);

                while (dr.Read())
                {
                    LichGiangDayDTO lichGiangDayDTO = new LichGiangDayDTO();
                    if (!dr.IsDBNull(0))
                        lichGiangDayDTO.maLich = dr.GetInt32(0);
                    if (!dr.IsDBNull(1))
                        lichGiangDayDTO.thu = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        lichGiangDayDTO.ngayBatDau = dr.GetDateTime(2);
                    if (!dr.IsDBNull(3))
                        lichGiangDayDTO.ngayKetThuc = dr.GetDateTime(3);
                    if (!dr.IsDBNull(4))
                        lichGiangDayDTO.monHoc = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        lichGiangDayDTO.buoi = dr.GetInt32(5);
                    if (!dr.IsDBNull(6))
                        lichGiangDayDTO.tietBatDau = dr.GetInt32(6);
                    if (!dr.IsDBNull(7))
                        lichGiangDayDTO.tietKetThuc = dr.GetInt32(7);
                    if (!dr.IsDBNull(8))
                        lichGiangDayDTO.lop = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        lichGiangDayDTO.giaoVien = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        lichGiangDayDTO.trangThai = dr.GetString(10);
                    lst.Add(lichGiangDayDTO);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            return lst;
        }
        public bool KiemTraLichGiangDayTrung(string giaoVien, string monDay, string lop, string thu, int tietBD, int tietKT, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                string sCauTruyVan = "";
                sCauTruyVan += "SELECT COUNT(*) FROM LichGiangDay ";
                sCauTruyVan += "WHERE giaoVien = '" + giaoVien + "' AND ";
                sCauTruyVan += "monHoc = '" + monDay + "' AND ";
                sCauTruyVan += "lop = '" + lop + "' AND ";
                sCauTruyVan += "thu = N'" + thu + "' AND ";
                sCauTruyVan += "tietBD = " + tietBD + " AND ";
                sCauTruyVan += "tietKT = " + tietKT + " AND ";
                sCauTruyVan += "ngayBatDau = '" + ngayBatDau.ToString("yyyy-MM-dd") + "' AND ";
                sCauTruyVan += "ngayKetThuc = '" + ngayKetThuc.ToString("yyyy-MM-dd") + "' ";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(sCauTruyVan, connection);

                int kiemTra =(int) cmd.ExecuteScalar();

                return kiemTra > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool TaoLichGiangDay(string thu, DateTime ngayBatDau, DateTime ngayKetThuc, string monHoc, int buoi, int tietBatDau, int tietKethuc, string lop, string giaoVien, string trangThai)
        {
            bool ketQua = true;
            try
            {
                string sCauTruyVan = "INSERT INTO LichGiangDay VALUES(";
                sCauTruyVan += " N'"+thu+"', ";
                sCauTruyVan += " '"+ngayBatDau+"', ";
                sCauTruyVan += " '" + ngayKetThuc + "', ";
                sCauTruyVan += " '" + monHoc + "', ";
                sCauTruyVan +=  buoi + ", ";
                sCauTruyVan +=  tietBatDau + ", ";
                sCauTruyVan +=  tietKethuc + ", ";
                sCauTruyVan += " '" + lop + "',";
                sCauTruyVan += " '" + giaoVien + "', ";
                sCauTruyVan += " N'" + trangThai + "') ";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                int add = (int)DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                if (add == 0)
                {
                    ketQua = false;
                }
            }catch (Exception ex) { throw ex; }
            return ketQua;  
        }
        public bool XoaLichGiangDay(int maLich)
        {
            bool xoa = true;
            try
            {
                string sCauTruyVan = "DELETE FROM LichGiangDay ";
                sCauTruyVan += "WHERE maLich = " + maLich + "";
               

                SqlConnection connection = DataProvider.KetNoiCSDL();
                int count = (int)DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                if (count == 0)
                {
                    xoa = false;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return xoa;
        }
        public bool HoanThanhLichGiangDay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            bool hoanThanh = true;
            try
            {
                string sCauTruyVan = "UPDATE LichGiangDay SET trangThai = N'Đã hoàn thành' WHERE ";
                sCauTruyVan += "ngayBatDau = '" + ngayBatDau.ToString("yyyy-MM-dd") + "' AND ";
                sCauTruyVan += "ngayKetThuc = '" + ngayKetThuc.ToString("yyyy-MM-dd") + "' ";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                int count = (int)DataProvider.ThucThiTruyVan(sCauTruyVan, connection);
                if(count == 0)
                {
                    hoanThanh = false;
                }
                connection.Close();
            }catch (Exception ex) { throw ex; }
            return hoanThanh;
        }
        public bool CapNhatLichGiangDay(int maLich, string thu, DateTime ngayBatDau, DateTime ngayKetThuc, string monHoc, int buoi, int tietBatDau, int tietKethuc, string lop, string giaoVien, string trangThai)
        {
            bool capNhat = true;
            try
            {
                string sCauTruyVan = " UPDATE LichGiangDay SET ";
                sCauTruyVan += " thu = N'" + thu + "', ";
                sCauTruyVan += " ngayBatDau = '" + ngayBatDau + "', ";
                sCauTruyVan += " ngayKetThuc = '" + ngayKetThuc + "', ";
                sCauTruyVan += " monHoc = '" + monHoc + "', ";
                sCauTruyVan += " buoi = " + buoi + ", ";
                sCauTruyVan += " tietBD = " + tietBatDau + ", ";
                sCauTruyVan += " tietKT = " + tietKethuc + ", ";
                sCauTruyVan += " lop = '" + lop + "', ";
                sCauTruyVan += " giaoVien = '" + giaoVien + "', ";
                sCauTruyVan += " trangThai = N'" + trangThai + "' ";
                sCauTruyVan += " WHERE maLich =" + maLich + "";

                SqlConnection connection = DataProvider.KetNoiCSDL();
                int cout = (int)DataProvider.ThucThiTruyVan(sCauTruyVan, connection);

                if(cout == 0)
                {
                    capNhat = false;
                }

            }catch (Exception ex)
            {
                throw ex;
            }
            return capNhat;
        }
    }
}
