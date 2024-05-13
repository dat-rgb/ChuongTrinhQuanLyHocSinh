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
    public class PhanCongGiangDayBUS
    {
        public List<PhanCongGiangDayDTO> LayDSPhanCongGiangDay()
        {
            PhanCongGiangDayDAO phanCongGiangDayDAO = new PhanCongGiangDayDAO();

            List<PhanCongGiangDayDTO> lst = phanCongGiangDayDAO.LayDSPhanCongGiangDay();

            return lst;
        }
       
        public List<PhanCongGiangDayDTO> TimKiemHocSinh_TheoMonHoc(string monHoc)
        {
            PhanCongGiangDayDAO timKiemPhanCong = new PhanCongGiangDayDAO();
            List<PhanCongGiangDayDTO> lst = timKiemPhanCong.TimKiemPhanCong_TheoMonHoc(monHoc);

            return lst;
        }
        public List<PhanCongGiangDayDTO> TimKiemHocSinh_TheoGiaoVien(string giaoVien)
        {
            PhanCongGiangDayDAO timKiemPhanCong = new PhanCongGiangDayDAO();
            List<PhanCongGiangDayDTO> lst = timKiemPhanCong.TimKiemPhanCong_TheoGiaoVien(giaoVien);

            return lst;
        }
        public void CapNhatPhanCongGiaoVien(string giaoVien, string monDay, int maPhanCong)
        {
            try
            {
                
                PhanCongGiangDayDAO phanCongGiangDayDAO = new PhanCongGiangDayDAO();
                bool kiemTra = phanCongGiangDayDAO.KiemTraPhanCongGiaoVien(giaoVien, monDay);
                if (kiemTra)
                {
                    MessageBox.Show("Giáo viên đã có trong danh sách phân công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool capNhat = phanCongGiangDayDAO.CapNhatPhanCongGiaoVien(giaoVien, monDay, maPhanCong);
                    if (capNhat)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//xong
        public void XoaPhanCongGiaoVienGiangDay(string giaoVien, string monDay)
        {
            try
            {
                PhanCongGiangDayDAO phanCongGiangDayDAO = new PhanCongGiangDayDAO();
                bool kiemTra = phanCongGiangDayDAO.KiemTraPhanCongGiaoVien(giaoVien, monDay);

                if (kiemTra)
                {
                    bool xoa = phanCongGiangDayDAO.XoaPhanCongGiaoVienGiangDay(giaoVien, monDay);
                    if (xoa)
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không có giáo viên trong danh sách phân công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//xong
        public void ThemPhanCongGiaoVien(string giaoVien, string monDay)
        {
            try
            {
                PhanCongGiangDayDAO phanCongGiangDayDAO = new PhanCongGiangDayDAO();
                
                bool kiemTra = phanCongGiangDayDAO.KiemTraPhanCongGiaoVien(giaoVien, monDay);
                if (kiemTra)
                {
                    MessageBox.Show("Giáo viên đã có trong danh sách phân công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool add = phanCongGiangDayDAO.ThemPhanCongGiaoVien(giaoVien, monDay);
                    if (add)
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
