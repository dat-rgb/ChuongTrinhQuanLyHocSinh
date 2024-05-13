using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class HocSinhBUS
    {
        public List<HocSinhDTO> LayDSHS()
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            List<HocSinhDTO> lst = hocSinhDAO.LayDSHS();
            return lst;
        }
        public List<HocSinhDTO> LayDSHSTheoTrangThai(string trangThai)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            List<HocSinhDTO>lst = hocSinhDAO.LayDSHSTheoTrangThai(trangThai);

            return lst;
        }
        public List<HocSinhDTO> LayDSHSTheoNamHoc(string namHoc)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            return hocSinhDAO.LayDSHSTheoNamHoc(namHoc);
        }
        public List<HocSinhDTO> TimKiemHocSinh_TheoMaHS(string maHS)
        {
            HocSinhDAO timKiemHocSinh = new HocSinhDAO();
            List<HocSinhDTO> lst = timKiemHocSinh.TimKiemHocSinh_TheoMaHS(maHS);
            if (lst == null || lst.Count == 0)
            {
                MessageBox.Show($"Không có Học sinh mã {maHS}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lst;
        }
        public List<HocSinhDTO> TimKiemHocSinh_TheoTenHS(string tenHS)
        {
            HocSinhDAO timKiemHocSinh = new HocSinhDAO();
            List<HocSinhDTO> lst = timKiemHocSinh.TimKiemHocSinh_TheoTenHS(tenHS);
            if (lst == null || lst.Count == 0)
            {
                MessageBox.Show($"Không có Học sinh tên {tenHS}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lst;
        }
        public List<HocSinhDTO> TimKiemHocSinh_TheoKhoi(string lop)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            return hocSinhDAO.TimKiemHocSinh_TheoKhoi(lop);
        }
        public void CapNhatThongTinHocSinh(string maHS, string hoTen, string soDT, string queQuan)
        {
            try
            {
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(queQuan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Tách hoTen thành hoHS và tenHS
                    string ten = hoTen.Trim();
                    int viTriKhoangTrangCuoi = hoTen.LastIndexOf(' ');
                    string tenHS = ten.Substring(viTriKhoangTrangCuoi + 1);
                    string hoHS = ten.Remove(viTriKhoangTrangCuoi).Trim();
                    HocSinhDTO hocSinhDTO = new HocSinhDTO();
                    hocSinhDTO.maHS = maHS;
                    hocSinhDTO.hoHS = hoHS;
                    hocSinhDTO.tenHS = tenHS;
                    hocSinhDTO.soDT = soDT;
                    hocSinhDTO.queQuan = queQuan;

                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn cập nhật thông tin?\n\n * Họ và tên: {hoTen}\n\n * Số DT: {soDT}\n\n * Quê quán: {queQuan}\n    ---------------", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        HocSinhDAO hocSinhDAO = new HocSinhDAO();
                        bool capNhat = hocSinhDAO.CapNhatThongTinHocSinh(hocSinhDTO);
                        if (capNhat)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaHocSinh(string maHS)
        {
            try
            {
                if (string.IsNullOrEmpty(maHS))
                {
                    MessageBox.Show("Vui lòng nhập mã học sinh cần xóa.","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa Học sinh có mã: {maHS}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HocSinhDAO hocSinhDAO = new HocSinhDAO();
                        bool xoa = hocSinhDAO.XoaHocSinh(maHS);
                        if (xoa)
                        {
                            MessageBox.Show($"Đã xóa học sinh có mã: {maHS}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void KhoiPhucHocSinhDaXoa(string maHS)
        {
            try
            {
                HocSinhDAO hocSinhDAO = new HocSinhDAO();
                if (string.IsNullOrEmpty(maHS))
                {
                    MessageBox.Show("Vui lòng nhập mã học sinh.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(DemSoLuongHocSinhTrangThai1(maHS) == 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn có muốn khôi phục học sinh mã {maHS}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool restore = hocSinhDAO.KhoiPhucHocSinhDaXoa(maHS);
                        if (restore)
                        {
                            MessageBox.Show($"Đã phục hồi học sinh có mã: {maHS}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Phục hồi không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }   
                else
                {
                    MessageBox.Show($"Danh sách xóa không có học sinh mã: {maHS}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//xong
        public bool AddHocSinh(string maHS, string cccd, string hoHS, string tenHS, int gioiTinh, DateTime ngaySinh, string queQuan, string soDT, string mail, string lop, DateTime namNhapHoc, string trangThai)
        {
            bool flag = true;
            try
            {
                HocSinhDAO hocSinhDAO = new HocSinhDAO();
                bool checkMaHS = hocSinhDAO.KiemTraMaHocSinhTrung(maHS);
                bool checkCCCD = hocSinhDAO.KiemTraCCCDTrung(cccd);

                if (checkMaHS)
                {
                    MessageBox.Show($" Mã học sinh: {maHS} đã tồn tại.\n Vui lòng chọn mã học sinh khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                else if (checkCCCD)
                {
                    MessageBox.Show($" Số CCCD: {cccd} đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                else
                {
                    bool add = hocSinhDAO.AddHocSinh(maHS, cccd, hoHS, tenHS, gioiTinh, ngaySinh, queQuan, soDT, mail, lop, namNhapHoc, trangThai);
                    if (add)
                    {
                        MessageBox.Show("Đã thêm học sinh thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm học sinh:....chi tiết: " + ex.Message);
            }
            return flag;
        }

        public HocSinhDTO HienThiThongTinHocSinh(string maHS)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            HocSinhDTO thongTinHS =hocSinhDAO.HienThiThongTinHocSinh(maHS);
            return thongTinHS;
        }
        public int DemSoLuongHocSinhTheoKhoi(string khoi)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            return hocSinhDAO.DemSoLuongHocSinhTheoKhoi(khoi);
        }
        public int DemSoLuongHocSinhTrongLichThi(string khoi, string monHoc)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            return hocSinhDAO.DemSoLuongHocSinhTrongLichThi(khoi, monHoc);
        }
        public int DemSoLuongHocSinhTrangThai1(string maHS)
        {
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            return hocSinhDAO.DemSoLuongHocSinhTrangThai1(maHS);
        }
    }
}
