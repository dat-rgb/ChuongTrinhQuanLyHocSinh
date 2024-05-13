using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QuanLyHocSinh : Form
    {
        List<HocSinhDTO> lstHS_Truoc = new List<HocSinhDTO>();
        List<HocSinhDTO> lstHS_Sau = new List<HocSinhDTO>();
        public frm_QuanLyHocSinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> namHocDTO = namHocBUS.LayDSNamHoc();
            
            cbb_NamHoc.DataSource = namHocDTO;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";

            ResetForm();

        }//xong
        private void dgv_DanhSachHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_HoTen.Focus();
            try
            {
                //string maHS, string cccd, string hoHS, string tenHS, int gioiTinh, DateTime ngaySinh, string queQuan, string soDT, string mail, string lop, DateTime namNhapHoc, string trangThai
                string maHS = dgv_DanhSachHocSinh.CurrentRow.Cells["maHS"].Value.ToString();
                string cccd = dgv_DanhSachHocSinh.CurrentRow.Cells["cccd"].Value.ToString();
                string hoHS = dgv_DanhSachHocSinh.CurrentRow.Cells["hoHS"].Value.ToString();
                string tenHS = dgv_DanhSachHocSinh.CurrentRow.Cells["tenHS"].Value.ToString();
                int iGioiTinh = int.Parse(dgv_DanhSachHocSinh.CurrentRow.Cells["gioiTinh"].Value.ToString());
                DateTime ngaySinh = (DateTime)dgv_DanhSachHocSinh.CurrentRow.Cells["ngaySinh"].Value;
                string queQuan = dgv_DanhSachHocSinh.CurrentRow.Cells["queQuan"].Value.ToString();
                string soDT = dgv_DanhSachHocSinh.CurrentRow.Cells["soDT"].Value.ToString();
                string mail = dgv_DanhSachHocSinh.CurrentRow.Cells["mail"].Value.ToString();
                string lop = dgv_DanhSachHocSinh.CurrentRow.Cells["lop"].Value.ToString();
                DateTime namNhapHoc = (DateTime)dgv_DanhSachHocSinh.CurrentRow.Cells["namNhapHoc"].Value;
                string trangThai = dgv_DanhSachHocSinh.CurrentRow.Cells["trangThai"].Value.ToString();


                //Chuyển đổi dữ liệu
                string hoTen = $"{hoHS} {tenHS}";
                string sGioiTinh = (iGioiTinh == 1) ? "Nam" : "Nữ";

                //Đổ dữ liệu lên DataGirdView
                txt_MaHS.Text = maHS.ToString();
                txt_SoCCCD.Text = cccd.ToString();
                txt_HoTen.Text = hoTen.ToString();
                cbb_GioiTinh.Text = sGioiTinh.ToString();
                date_NgaySinh.Value = ngaySinh;
                txt_QueQuan.Text = queQuan.ToString();
                txt_SoDienThoai.Text = soDT.ToString();
                txt_Email.Text = mail.ToString();
                cbb_LopHoc.Text = lop.ToString();
                date_NamNhapHoc.Value = namNhapHoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!! Chi tiết: " + ex.Message);
            }
        }//xong
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaHS.Text) && string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh hoặc họ tên học sinh!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                if (!string.IsNullOrEmpty(txt_MaHS.Text))
                {
                    string maHS = txt_MaHS.Text;
                    lstHS_Truoc = hocSinhBUS.TimKiemHocSinh_TheoMaHS(maHS);
                }
                else if (!string.IsNullOrEmpty(txt_HoTen.Text))
                {
                    string tenHS = txt_HoTen.Text;

                    lstHS_Truoc = hocSinhBUS.TimKiemHocSinh_TheoTenHS(tenHS);
                }
                if (lstHS_Truoc.Count > 0)
                {
                    dgv_DanhSachHocSinh.DataSource = lstHS_Truoc;
                }
                else
                {
                    ResetForm();
                }
            }
        }//xong
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }//xong
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maHS = txt_MaHS.Text;
                string hoTen = txt_HoTen.Text.Trim();
                string soDT = txt_SoDienThoai.Text;
                string queQuan = txt_QueQuan.Text;

                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                hocSinhBUS.CapNhatThongTinHocSinh(maHS, hoTen, soDT, queQuan);
                ResetControls();
                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin học sinh: " + ex.Message);
            }
        }//xong
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maHS = txt_MaHS.Text;
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                hocSinhBUS.XoaHocSinh(maHS);
                ResetForm();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa học sinh: " + ex.Message);
            }
        }//xong
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemHocSinh themHocSinh = new frm_ThemHocSinh();
            themHocSinh.ShowDialog();
        }//xong
        private void btn_KhoiPhucHSDaXoa_Click(object sender, EventArgs e)
        {
            try
            {

                string maHS = txt_MaHS.Text;
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                hocSinhBUS.KhoiPhucHocSinhDaXoa(maHS);
                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục học sinh: " + ex.Message);
            }
        }
        private void btn_DiemHS_Click(object sender, EventArgs e)
        {
            frm_QuanLyDiemHocSinh quanLyDiemHocSinh = new frm_QuanLyDiemHocSinh();
            quanLyDiemHocSinh.ShowDialog();
        }
        private void cbb_NamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tenNamHoc = cbb_NamHoc.Text;

                LopHocBUS lopHocBUS = new LopHocBUS();
                List<LopHocDTO> lstLopHoc = lopHocBUS.LayDSLopTheoNamHoc(tenNamHoc);
                cbb_LopHoc.DataSource = lstLopHoc;
                cbb_LopHoc.DisplayMember = "tenLop";
                cbb_LopHoc.ValueMember = "maLop";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi...Chi tiết: " + ex.Message);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }//xong
        public void ResetControls()
        {
            txt_MaHS.Text = string.Empty;
            txt_SoCCCD.Text = string.Empty;
            txt_HoTen.Text = string.Empty;
            cbb_GioiTinh.SelectedIndex = -1;
            date_NgaySinh.Value = DateTime.Now;
            txt_QueQuan.Text = string.Empty;
            txt_SoDienThoai.Text = string.Empty;
            txt_Email.Text = string.Empty;
            cbb_LopHoc.SelectedIndex = -1;
            date_NamNhapHoc.Value = DateTime.Now;
        }
        public void ResetForm()
        {
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            lstHS_Truoc = hocSinhBUS.LayDSHS();
            lstHS_Sau = hocSinhBUS.LayDSHS();
            dgv_DanhSachHocSinh.DataSource = lstHS_Sau;
        }
        private void btn_refesh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }//xong
        public void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào
            }
        }//xong
        private void cbb_Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khoi = cbb_Khoi.Text;
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            lstHS_Truoc = hocSinhBUS.TimKiemHocSinh_TheoKhoi(khoi);
            lstHS_Sau = hocSinhBUS.TimKiemHocSinh_TheoKhoi(khoi);

            dgv_DanhSachHocSinh.DataSource = lstHS_Sau;
        }
        private void cbb_TrangThaiChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbb_TrangThaiChon.Text;
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            lstHS_Truoc = hocSinhBUS.LayDSHSTheoTrangThai(trangThai);
            lstHS_Sau = hocSinhBUS.LayDSHSTheoTrangThai(trangThai);

            dgv_DanhSachHocSinh.DataSource = lstHS_Sau;
        }
    }
}

