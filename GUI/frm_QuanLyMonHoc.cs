using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QuanLyMonHoc : Form
    {
        List<MonHocDTO> lstMonHoc_Truoc = new List<MonHocDTO>();
        List<MonHocDTO> lstMonHoc_Sau = new List<MonHocDTO>();
       
        List<PhanCongGiangDayDTO> lstPhanCongGiangDay = new List<PhanCongGiangDayDTO>();
        public frm_QuanLyMonHoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            rad_DSPhanCong.Checked = true;
            
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            List<GiaoVienDTO> giaoVienDTOs = giaoVienBUS.LayDSGVLenCombobox();
            cbb_TatCaGiaoVien.DataSource = giaoVienDTOs;
            cbb_TatCaGiaoVien.DisplayMember = "tenGV";
            cbb_TatCaGiaoVien.ValueMember = "maGV";
            cbb_TatCaGiaoVien.SelectedIndex = -1;
            
            MonHocBUS monHocBUS = new MonHocBUS();
            List<MonHocDTO> lstMonHoc = monHocBUS.LayDSMonHoc();
            
            cbb_TatCaMonhoc.DataSource = lstMonHoc;
            cbb_TatCaMonhoc.DisplayMember = "tenMonHoc";
            cbb_TatCaMonhoc.ValueMember = "maMonHoc";
            cbb_TatCaMonhoc.SelectedIndex = -1;
        }
      
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void dgv_DanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            try
            {
                if(rad_DSPhanCong.Checked == true)
                {
                    string monDay = dgv_DanhSachMonHoc.CurrentRow.Cells["monDay"].Value.ToString();
                    string moTa = dgv_DanhSachMonHoc.CurrentRow.Cells["moTa"].Value.ToString();
                    string giaoVien = dgv_DanhSachMonHoc.CurrentRow.Cells["giaoVien"].Value.ToString();

                    cbb_TatCaMonhoc.Text = monDay;
                    cbb_TatCaGiaoVien.Text = moTa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!! Chi tiết: " + ex.Message);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_MonHoc.Text) && string.IsNullOrEmpty(cbb_GiaoVien.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học hoăc chọn giáo viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                PhanCongGiangDayBUS phanCongGiangDayBUS = new PhanCongGiangDayBUS();
                if (!string.IsNullOrEmpty(cbb_MonHoc.Text))
                {
                    string monHoc = cbb_MonHoc.SelectedValue.ToString();
                    lstPhanCongGiangDay = phanCongGiangDayBUS.TimKiemHocSinh_TheoMonHoc(monHoc);
                    if (lstPhanCongGiangDay.Count == 0 || lstPhanCongGiangDay == null)
                    {
                        MessageBox.Show($"Môn: {cbb_MonHoc.Text} chưa được phân công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_DanhSachMonHoc.DataSource = lstPhanCongGiangDay;
                    }
                }
                else if (!string.IsNullOrEmpty(cbb_GiaoVien.Text))
                {
                    string giaoVien = cbb_GiaoVien.SelectedValue.ToString();
                    lstPhanCongGiangDay = phanCongGiangDayBUS.TimKiemHocSinh_TheoGiaoVien(giaoVien);
                    if (lstPhanCongGiangDay.Count == 0 || lstPhanCongGiangDay == null)
                    {
                        MessageBox.Show($"Giáo viên: {cbb_GiaoVien.Text} chưa được phân công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_DanhSachMonHoc.DataSource = lstPhanCongGiangDay;
                    }
                }
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cbb_TatCaGiaoVien.Text)|| string.IsNullOrEmpty(cbb_TatCaMonhoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Lấy thông tin học sinh từ các controls trên giao diện
                    string giaoVien = cbb_TatCaGiaoVien.SelectedValue.ToString();
                    string monDay = cbb_TatCaMonhoc.SelectedValue.ToString();
                    int maPhanCong =(int) dgv_DanhSachMonHoc.CurrentRow.Cells["maPhanCong"].Value;
                    // Gọi phương thức cập nhật thông tin học sinh từ tầng BUS
                    PhanCongGiangDayBUS phanCongGiangDayBUS = new PhanCongGiangDayBUS();
                    DialogResult dialogResult = MessageBox.Show($"Bạn muốn cập nhật thông tin?\n\nPhân công giáo viên giảng dạy:\n\nHọ tên GV: {cbb_TatCaGiaoVien.Text}\n\nMôn dạy: {cbb_TatCaMonhoc.Text}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        phanCongGiangDayBUS.CapNhatPhanCongGiaoVien(giaoVien, monDay,maPhanCong);
                        ResetForm();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin học sinh: " + ex.Message);
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cbb_TatCaGiaoVien.Text)|| string.IsNullOrEmpty(cbb_TatCaMonhoc.Text))
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string giaoVien = cbb_TatCaGiaoVien.SelectedValue.ToString();
                    string monDay = cbb_TatCaMonhoc.SelectedValue.ToString();

                    PhanCongGiangDayBUS phanCongGiangDayBUS = new PhanCongGiangDayBUS();
                    DialogResult dialogResult = MessageBox.Show($"Bạn muốn xóa phân công giảng dạy của Giáo viên?\n\n Họ tên GV: {cbb_TatCaGiaoVien.Text}\n\n Môn dạy: {cbb_TatCaMonhoc.Text} ", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        phanCongGiangDayBUS.XoaPhanCongGiaoVienGiangDay(giaoVien, monDay);
                        ResetForm();
                        ResetControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa học sinh: " + ex.Message);
            }
        }//xong

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbb_TatCaGiaoVien.Text) || string.IsNullOrEmpty(cbb_TatCaMonhoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string giaoVien = cbb_TatCaGiaoVien.SelectedValue.ToString();
                    string monDay = cbb_TatCaMonhoc.SelectedValue.ToString();

                    PhanCongGiangDayBUS phanCongGiangDayBUS = new PhanCongGiangDayBUS();
                    DialogResult dialogResult = MessageBox.Show($"Thêm Phân công giảng dạy:\n\n______THÔNG TIN______\n\n Giáo viên: {cbb_TatCaGiaoVien.Text}\n\n Môn dạy: {cbb_TatCaMonhoc.Text}\n\n===================", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        phanCongGiangDayBUS.ThemPhanCongGiaoVien(giaoVien, monDay);
                        ResetForm();
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học sinh: " + ex.Message);
            }
        }//xong

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            List<GiaoVienDTO> dsGiaoVienPhanCongMonDay = new List<GiaoVienDTO>();
            string monDay;
            if (string.IsNullOrEmpty(cbb_MonHoc.Text))
            {
                dsGiaoVienPhanCongMonDay = giaoVienBUS.LayDSGVLenCombobox();
               
            }
            else
            {
                monDay = cbb_MonHoc.SelectedValue.ToString();
                dsGiaoVienPhanCongMonDay = giaoVienBUS.LayDSGVPhanCongTheoMonDay(monDay);
            }
            cbb_GiaoVien.DataSource = dsGiaoVienPhanCongMonDay;
            cbb_GiaoVien.DisplayMember = "tenGV";
            cbb_GiaoVien.ValueMember = "maGV";
            cbb_GiaoVien.SelectedIndex = -1;
            
        }
      
        public void ResetControls()
        {
            cbb_TatCaGiaoVien.SelectedIndex = -1;
            cbb_GiaoVien.SelectedIndex = -1;
            cbb_MonHoc.SelectedIndex = -1;
            cbb_TatCaMonhoc.SelectedIndex = -1;
        }
        public void ResetForm()
        {
            if(rad_DSMonHoc.Checked)
            {
                MonHocBUS monHocBUS = new MonHocBUS();
                lstMonHoc_Truoc = monHocBUS.LayDSMonHoc();
                lstMonHoc_Sau = monHocBUS.LayDSMonHoc();
                dgv_DanhSachMonHoc.DataSource = lstMonHoc_Sau;
            }
            else if (rad_DSPhanCong.Checked)
            {
                PhanCongGiangDayBUS phanCongGiangDayBUS = new PhanCongGiangDayBUS();
                List<PhanCongGiangDayDTO> phanCongGiangDayDTOs = phanCongGiangDayBUS.LayDSPhanCongGiangDay();

                dgv_DanhSachMonHoc.DataSource = phanCongGiangDayDTOs;
            }
        }
        private void rad_DSMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void rad_DSPhanCong_CheckedChanged(object sender, EventArgs e)
        {
            ResetForm();
            MonHocBUS monHocBUS = new MonHocBUS();
            List<MonHocDTO> lstMonHoc = monHocBUS.LayDSMonHoc();
            cbb_MonHoc.DataSource = lstMonHoc;
            cbb_MonHoc.DisplayMember = "tenMonHoc";
            cbb_MonHoc.ValueMember = "maMonHoc";
            cbb_MonHoc.SelectedIndex = -1;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
