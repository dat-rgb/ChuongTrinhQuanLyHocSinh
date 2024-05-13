using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class LichGiangDayBUS
    {
        public List<LichGiangDayDTO> LayDSLichGiangDay()
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            return lichGiangDayDAO.LayDSLichGiangDay();
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoTrangThai(string trangThai)
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            return lichGiangDayDAO.LayDSLichGiangDayTheoTrangThai(trangThai);
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoLop(string lop, string trangThai)
        {
            LichGiangDayDAO lichGiangDayDAO= new LichGiangDayDAO();
            return lichGiangDayDAO.LayDSLichGiangDayTheoLop(lop, trangThai);
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoMonHoc(string monHoc, string trangThai)
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            return  lichGiangDayDAO.LayDSLichGiangDayTheoMonHoc(monHoc, trangThai);
        }
        public List<LichGiangDayDTO> LayDSLichGiangDayTheoMonHocGiaoVien(string monHoc, string giaoVien, string trangThai)
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            return lichGiangDayDAO.LayDSLichGiangDayTheoMonHocGiaoVien(monHoc, giaoVien, trangThai);
        }
        public void TaoLichGiangDay(string thu, DateTime ngayBatDau, DateTime ngayKetThuc, string monHoc, int buoi, int tietBatDau, int tietKethuc, string lop, string giaoVien, string trangThai)
        {
            try
            {
                LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
                bool check = lichGiangDayDAO.KiemTraLichGiangDayTrung(giaoVien, monHoc, lop, thu, tietBatDau, tietKethuc, ngayBatDau, ngayKetThuc);

                if (check)
                {
                    MessageBox.Show("Đã có lịch giảng dạy trong danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool them = lichGiangDayDAO.TaoLichGiangDay(thu, ngayBatDau, ngayKetThuc, monHoc, buoi, tietBatDau, tietKethuc, lop, giaoVien, trangThai);
                    if (them)
                    {
                        MessageBox.Show("Tạo lịch giảng dạy thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tạo lịch giảng dạy không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaLichGiangDay(int maLich)
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            bool xoa = lichGiangDayDAO.XoaLichGiangDay(maLich); 
            if (xoa)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa không thành công","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//xong
        public bool HoanThanhLichGiangDay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            bool kq = true;
            LichGiangDayDAO lichGiangDayDAO=new LichGiangDayDAO();
            bool hoanThanh = lichGiangDayDAO.HoanThanhLichGiangDay(ngayBatDau, ngayKetThuc);
            if (!hoanThanh)
            {
               kq = false;
            }
            return kq;
        }//xong
        public void CapNhatLichGiangDay(int maLich, string thu, DateTime ngayBatDau, DateTime ngayKetThuc, string monHoc, int buoi, int tietBatDau, int tietKethuc, string lop, string giaoVien, string trangThai)
        {
            LichGiangDayDAO lichGiangDayDAO = new LichGiangDayDAO();
            bool capNhat = lichGiangDayDAO.CapNhatLichGiangDay(maLich, thu, ngayBatDau,ngayKetThuc , monHoc , buoi , tietBatDau ,tietKethuc , lop , giaoVien, trangThai);
            if (capNhat)
            {
                MessageBox.Show("Cập nhật thông tin thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
