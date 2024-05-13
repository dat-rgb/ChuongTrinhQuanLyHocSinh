using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class GiaoVienBUS
    {
        public List<GiaoVienDTO> LayDSGV()
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            List<GiaoVienDTO> lst = giaoVienDAO.LayDSGV();
            return lst;
        }
        public List<GiaoVienDTO> LayDSGVPhanCongTheoMonDay(string monDay)
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            List<GiaoVienDTO> dsGiaoVien = giaoVienDAO.LayDSGVPhanCongTheoMonDay(monDay);
            return dsGiaoVien;
        }
        public List<GiaoVienDTO> LayDSGVChuaChuNhiem()
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            List<GiaoVienDTO> lst = giaoVienDAO.LayDSGVChuaChuNhiem();
            return lst;
        }
        public List<GiaoVienDTO> LayDSGVLenCombobox()
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            List<GiaoVienDTO> lst = giaoVienDAO.LayDSGVLenCombobox();
            return lst;
        }
        public GiaoVienDTO LayDuLieuTuDataGridView(string maGV, string cccd, string hoGV, string tenGV, int gioiTinh, DateTime ngaySinh, string queQuan, string soDT, string mail, string bangCap, DateTime ngayVao, string chucVu, string trangThai)
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            return giaoVienDAO.LayDuLieuTuDataGridView(maGV, cccd, hoGV, tenGV, gioiTinh, ngaySinh, queQuan, soDT, mail, bangCap, ngayVao, chucVu, trangThai);
        }
        public List<GiaoVienDTO> TimKiemGiaoVien_TheoMaGV(string maGV)
        {
            GiaoVienDAO timKiemGiaoVien = new GiaoVienDAO();
            List<GiaoVienDTO> lst = timKiemGiaoVien.TimKiemGiaoVien_TheoMaGV(maGV);
            if(lst == null || lst.Count == 0)
            {
                MessageBox.Show($"Không có Giáo Viên mã {maGV}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lst;
        }
        public List<GiaoVienDTO> TimKiemGiaoVien_TheoTenGV(string hoten)
        {
            GiaoVienDAO timkiemGiaoVien = new GiaoVienDAO();
            List<GiaoVienDTO> lst = timkiemGiaoVien.TimKiemGiaoVien_TheoTenGV(hoten);
            return lst;
        }
        public void CapNhatThongTinGiaoVien(string maGV, string hoTen, string soDT, string mail, string queQuan)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(queQuan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ người dùng
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn cập nhật\n\n Mã GV: {maGV}\n\n Họ tên: {hoTen}\n\n Số DT: {soDT}\n\n Email: {mail}\n\n Quê quán: {queQuan}", "Xác Nhân", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Cập nhật thông tin
                    string[] word = hoTen.Split(' ');
                    string hoGV = string.Join(" ", word.Take(word.Length - 1));
                    string tenGV = word.Last();

                    GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                    giaoVienDTO.maGV = maGV;
                    giaoVienDTO.hoGV = hoGV;
                    giaoVienDTO.tenGV = tenGV;
                    giaoVienDTO.soDT = soDT;
                    giaoVienDTO.mail = mail;
                    giaoVienDTO.queQuan = queQuan;

                    GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
                    giaoVienDAO.CapNhatThongTinGiaoVien(giaoVienDTO);

                    MessageBox.Show("Cập nhật thông tin giáo viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin giáo viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaGiaoVien(string maGV)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa giáo viên có mã: {maGV}","Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) 
                {
                    // Gọi phương thức xóa học sinh từ tầng DAO
                    GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
                    giaoVienDAO.XoaGiaoVien(maGV);
                    MessageBox.Show("Xóa thành công","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
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
                if (string.IsNullOrEmpty(maGV))
                {
                    MessageBox.Show("Vui lòng nhập mã giáo viên cần khôi phục","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
                    DialogResult dialogResult = MessageBox.Show($"Bạn có muốn khôi phục giáo viên có mã {maGV}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        giaoVienDAO.KhoiPhucGiaoVienDaXoa(maGV);
                        MessageBox.Show("Phục hồi thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GiaoVienDTO HienThiThongTinGiaoVien(string maGV)
        {
            GiaoVienDAO giaoVienDAO=new GiaoVienDAO();
            GiaoVienDTO thongTinGiaoVien = giaoVienDAO.HienThiThongTinGiaoVien(maGV);

            return thongTinGiaoVien;
        }
    }
}
