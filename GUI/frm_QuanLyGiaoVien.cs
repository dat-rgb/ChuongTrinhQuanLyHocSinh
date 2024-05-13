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
    public partial class frm_QuanLyGiaoVien : Form
    {
        List<GiaoVienDTO> lstGV_Truoc = new List<GiaoVienDTO>();
        List<GiaoVienDTO> lstGV_Sau = new List<GiaoVienDTO>();
        public frm_QuanLyGiaoVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            ChucVuBUS chucVuBUS = new ChucVuBUS();
            List<ChucVuDTO> chucVuDTO = chucVuBUS.LayDSChucVu();
            cbb_ChucVu.DataSource = chucVuDTO;
            cbb_ChucVu.DisplayMember = "tenChucVu";
            cbb_ChucVu.ValueMember = "maChucVu";

            BangCapBUS bangCapBUS = new BangCapBUS();
            List<BangCapDTO> bangCapDTO = bangCapBUS.LayDSBangCap();
            cbb_TrinhDo.DataSource = bangCapDTO;
            cbb_TrinhDo.DisplayMember = "tenBangCap";
            cbb_TrinhDo.ValueMember = "maBangCap";

            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            lstGV_Truoc = giaoVienBUS.LayDSGV();
            lstGV_Sau = giaoVienBUS.LayDSGV();
            dgv_DanhSachGiaoVien.DataSource = lstGV_Sau;
        }
        private void dgv_DanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_HoTen.Focus();
            try
            {
                string maGV = dgv_DanhSachGiaoVien.CurrentRow.Cells["maGV"].Value.ToString();
                string cccd = dgv_DanhSachGiaoVien.CurrentRow.Cells["cccd"].Value.ToString();
                string hoGV = dgv_DanhSachGiaoVien.CurrentRow.Cells["hoGV"].Value.ToString();
                string tenGV = dgv_DanhSachGiaoVien.CurrentRow.Cells["tenGV"].Value.ToString();
                int iGioiTinh = int.Parse(dgv_DanhSachGiaoVien.CurrentRow.Cells["gioiTinh"].Value.ToString());
                DateTime ngaySinh = (DateTime)dgv_DanhSachGiaoVien.CurrentRow.Cells["ngaySinh"].Value;
                string queQuan = dgv_DanhSachGiaoVien.CurrentRow.Cells["queQuan"].Value.ToString();
                string soDT = dgv_DanhSachGiaoVien.CurrentRow.Cells["soDT"].Value.ToString();
                string mail = dgv_DanhSachGiaoVien.CurrentRow.Cells["mail"].Value.ToString();
                string bangCap = dgv_DanhSachGiaoVien.CurrentRow.Cells["bangCap"].Value.ToString();
                DateTime ngayVao = (DateTime)dgv_DanhSachGiaoVien.CurrentRow.Cells["ngayVao"].Value;
                string chucVu = dgv_DanhSachGiaoVien.CurrentRow.Cells["chucVu"].Value.ToString();
                string trangThai = dgv_DanhSachGiaoVien.CurrentRow.Cells["trangThai"].Value.ToString();

                
                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                giaoVienBUS.LayDuLieuTuDataGridView(maGV, cccd, hoGV, tenGV, iGioiTinh, ngaySinh, queQuan, soDT, mail, bangCap, ngayVao, chucVu, trangThai);
                //Chuyển dổi dữ liệu:
                string hoTen = $"{hoGV} {tenGV}";
                string sGioiTinh = (iGioiTinh == 1) ? "Nam" : "Nữ";

                txt_MaGV.Text = maGV.ToString();
                txt_SoCCCD.Text = cccd.ToString();
                txt_HoTen.Text = hoTen.ToString();
                cbb_GioiTinh.Text = sGioiTinh.ToString();
                date_NgaySinh.Value = ngaySinh;
                txt_QueQuan.Text = queQuan.ToString();
                txt_SoDienThoai.Text = soDT.ToString();
                txt_Email.Text = mail.ToString();
                cbb_TrinhDo.Text = bangCap.ToString();
                date_NgayVao.Value = ngayVao;
                cbb_ChucVu.Text = chucVu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!! Chi tiết: " + ex.Message);
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaGV.Text= string.Empty;
            txt_SoCCCD.Text= string.Empty;
            txt_HoTen.Text= string.Empty;
            txt_QueQuan.Text= string.Empty;
            txt_SoDienThoai.Text= string.Empty;
            txt_Email.Text= string.Empty;
            cbb_ChucVu.Text= string.Empty;
            cbb_TrinhDo.Text= string.Empty;
            date_NgaySinh.Value = DateTime.Now;
            date_NgayVao.Value = DateTime.Now;

            dgv_DanhSachGiaoVien.DataSource = lstGV_Sau;

        }
        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            lstGV_Truoc = giaoVienBUS.LayDSGV();
            lstGV_Sau = giaoVienBUS.LayDSGV();

            dgv_DanhSachGiaoVien.DataSource = lstGV_Sau;    
        }
      
        private void btn_KhoiPhucGVDaXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = txt_MaGV.Text;
                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                giaoVienBUS.KhoiPhucGiaoVienDaXoa(maGV);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phục hồi giáo viên: " + ex.Message);
            }
        }
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaGV.Text) && string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giáo viên hoặc họ tên giáo viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                if (!string.IsNullOrEmpty(txt_MaGV.Text))
                {
                    string maGV = txt_MaGV.Text;
                    lstGV_Truoc = giaoVienBUS.TimKiemGiaoVien_TheoMaGV(maGV);
                }
                else if (!string.IsNullOrEmpty(txt_HoTen.Text))
                {
                    string hoTen = txt_HoTen.Text;
                    lstGV_Truoc = giaoVienBUS.TimKiemGiaoVien_TheoTenGV(hoTen);
                }
                dgv_DanhSachGiaoVien.DataSource = lstGV_Truoc;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maGV = txt_MaGV.Text;
                string hoTen = txt_HoTen.Text;
                string soDT = txt_SoDienThoai.Text;
                string mail = txt_Email.Text;
                string queQuan = txt_QueQuan.Text;

                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                giaoVienBUS.CapNhatThongTinGiaoVien(maGV, hoTen, soDT, mail, queQuan);

            }
             catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin giáo viên: " + ex.Message);
            }
            dgv_DanhSachGiaoVien.DataSource = lstGV_Sau ;
        }
        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maGV = dgv_DanhSachGiaoVien.CurrentRow.Cells["maGV"].Value.ToString();
                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                giaoVienBUS.XoaGiaoVien(maGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa giáo viên: " + ex.Message);
            }
        }
    }
}
