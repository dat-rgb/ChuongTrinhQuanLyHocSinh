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
    public partial class frm_QuanLyLopHoc : Form
    {
        List<LopHocDTO> lstDSLop_Truoc = new List<LopHocDTO>();
        List<LopHocDTO> lstDSLop_Sau = new List<LopHocDTO>();
        public frm_QuanLyLopHoc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_QuanLyLopHoc_Load(object sender, EventArgs e)
        {

            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> namHocDTOs = namHocBUS.LayDSNamHoc();
            cbb_NamHoc.DataSource = namHocDTOs;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";

            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            List<GiaoVienDTO> giaoVienDTOs = giaoVienBUS.LayDSGVLenCombobox();
            cbb_GiaoVien.DataSource = giaoVienDTOs;
            cbb_GiaoVien.DisplayMember = "tenGV";
            cbb_GiaoVien.ValueMember = "maGV";
            cbb_GiaoVien.SelectedIndex = -1;

            PhongHocBUS phongHocBUS = new PhongHocBUS();
            List<PhongHocDTO> phongHocDTOs = phongHocBUS.LayDSPhongHoc();

            cbb_PhongHoc.DataSource = phongHocDTOs;
            cbb_PhongHoc.DisplayMember = "tenPhong";
            cbb_PhongHoc.ValueMember = "maPhong";
            cbb_PhongHoc.SelectedIndex = -1;

            LopHocBUS lopHocBUS = new LopHocBUS();
            lstDSLop_Truoc = lopHocBUS.LayDSLop();
            lstDSLop_Sau = lopHocBUS.LayDSLop();

            dgv_DanhSachLopHoc.DataSource = lstDSLop_Sau;
        }

        private void dgv_DanhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maLop = dgv_DanhSachLopHoc.CurrentRow.Cells["maLop"].Value.ToString();
                string tenLop = dgv_DanhSachLopHoc.CurrentRow.Cells["tenLop"].Value.ToString();
                int soLuongHS = int.Parse(dgv_DanhSachLopHoc.CurrentRow.Cells["soLuongHS"].Value.ToString());
                string giaoVienCN = dgv_DanhSachLopHoc.CurrentRow.Cells["giaoVienCN"].Value.ToString();
                string phongHoc = dgv_DanhSachLopHoc.CurrentRow.Cells["phongHoc"].Value.ToString();
                string namHoc = dgv_DanhSachLopHoc.CurrentRow.Cells["namHoc"].Value.ToString();

                LopHocBUS lopHocBUS = new LopHocBUS();
                lopHocBUS.LayDuLieuTuDataGridView(maLop, tenLop, soLuongHS, giaoVienCN, phongHoc, namHoc);

                txt_MaLop.Text = maLop.ToString();
                txt_TenLop.Text = tenLop.ToString();
                nud_SoLuong.Value = soLuongHS;
                cbb_GiaoVien.Text = giaoVienCN.ToString();
                cbb_PhongHoc.Text = phongHoc.ToString();
                cbb_NamHoc.Text = namHoc.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi..." + ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaLop.Text = string.Empty;
            txt_TenLop.Text = string.Empty;
            cbb_GiaoVien.Text = string.Empty;
            cbb_NamHoc.SelectedIndex = 0;
            cbb_PhongHoc.Text = string.Empty;
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            LopHocBUS lopHocBUS = new LopHocBUS();
            lstDSLop_Truoc = lopHocBUS.LayDSLop();
            lstDSLop_Sau = lopHocBUS.LayDSLop();

            dgv_DanhSachLopHoc.DataSource = lstDSLop_Sau;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string lop = dgv_DanhSachLopHoc.CurrentRow.Cells["maLop"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa lớp", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LopHocBUS lopHocBUS = new LopHocBUS();
                    lopHocBUS.XoaLop(lop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi..." + ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txt_MaLop.Text;
                string tenLop = txt_TenLop.Text;
                int soLuongHS = (int)nud_SoLuong.Value;
                string giaoVienCN = cbb_GiaoVien.SelectedValue.ToString();
                string phongHoc = cbb_PhongHoc.SelectedValue.ToString();
                string namHoc = cbb_NamHoc.SelectedValue.ToString();

                LopHocBUS lopHocBUS = new LopHocBUS();
                lopHocBUS.themLop(maLop, tenLop, soLuongHS, giaoVienCN, phongHoc, namHoc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi...." + ex.Message);
            }
        }
        private void chk_ThemLop_CheckedChanged(object sender, EventArgs e)
        {
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            PhongHocBUS phongHocBUS = new PhongHocBUS();

            if (chk_ThemLop.Checked)
            {
                string namHoc = cbb_NamHoc.SelectedValue.ToString();

                List<GiaoVienDTO> giaoVienDTOs = giaoVienBUS.LayDSGVChuaChuNhiem();
                cbb_GiaoVien.DataSource = giaoVienDTOs;
                cbb_GiaoVien.DisplayMember = "tenGV";
                cbb_GiaoVien.ValueMember = "maGV";
                cbb_GiaoVien.SelectedIndex = -1;

                List<PhongHocDTO> phongHocDTOs = phongHocBUS.LayDSPhongHocChuaCoLop(namHoc);
                cbb_PhongHoc.DataSource = phongHocDTOs;
                cbb_PhongHoc.DisplayMember = "tenPhong";
                cbb_PhongHoc.ValueMember = "maPhong";
                cbb_PhongHoc.SelectedIndex = -1;
            }
            else
            {
                List<GiaoVienDTO> giaoVienDTOs = giaoVienBUS.LayDSGVLenCombobox();
                cbb_GiaoVien.DataSource = giaoVienDTOs;
                cbb_GiaoVien.DisplayMember = "tenGV";
                cbb_GiaoVien.ValueMember = "maGV";
                cbb_GiaoVien.SelectedIndex = -1;

                List<PhongHocDTO> phongHocDTOs = phongHocBUS.LayDSPhongHoc();
                cbb_PhongHoc.DataSource = phongHocDTOs;
                cbb_PhongHoc.DisplayMember = "tenPhong";
                cbb_PhongHoc.ValueMember = "maPhong";
                cbb_PhongHoc.SelectedIndex = -1;
            }
        }
    }
}
