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
    
    public partial class frm_School : Form
    {
        List<KyThiDTO> lstKyThi_Truoc = new List<KyThiDTO>();
        List<KyThiDTO> lstKyThi_Sau = new List<KyThiDTO>();
        public frm_School()
        {
            InitializeComponent();
        }

        private void frm_School_Load(object sender, EventArgs e)
        {
            NamHocBUS namHocBUS = new NamHocBUS();
           
            List<NamHocDTO> dsNamHoc = namHocBUS.LayTatCaNamHoc();
            dgv_DanhSach.DataSource = dsNamHoc;

            List<NamHocDTO> lst = namHocBUS.LayDSNamHoc();
            cbb_NamHoc.DataSource = lst;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";
            cbb_NamHoc.SelectedIndex = -1;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(!chk_ThemKythi.Checked && !chk_themNamhoc.Checked)
            {
                MessageBox.Show("Vui lòng chức năng!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(chk_themNamhoc.Checked)
            {
                string tenNamHoc = txt_NamHoc.Text;
                string trangThai = cbb_TrangThai.Text;

                NamHocBUS namHocBUS = new NamHocBUS();
                namHocBUS.ThemNamHoc(tenNamHoc, trangThai);
                ResetForm();
            }
            else if (chk_ThemKythi.Checked)
            {
                string maKyThi = txt_MaKyThi.Text;
                string tenKyThi = txt_TenKyThi.Text;
                string namHoc = cbb_NamHoc.Text;
                DateTime ngayBatDau = date_NgayBatDau.Value;
                DateTime ngayKetThuc = date_NgayKetThuc.Value;

                KyThiBUS kyThiBUS = new KyThiBUS();
                kyThiBUS.ThemKyThi(maKyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThuc);
                ResetKyThi();

            }
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            ResetForm();
            ResetControls();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!chk_ThemKythi.Checked && !chk_themNamhoc.Checked || chk_ThemKythi.Checked && chk_themNamhoc.Checked)
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (chk_themNamhoc.Checked)
            {
                string tenNamHoc = dgv_DanhSach.CurrentRow.Cells["tenNamHoc"].Value.ToString();

                NamHocBUS namHocBUS = new NamHocBUS();
                namHocBUS.XoaNamHoc(tenNamHoc);
                ResetControls();
                ResetForm();
            }
            else if (chk_ThemKythi.Checked)
            {
                string maKythi = txt_MaKyThi.Text;

                KyThiBUS kyThiBUS = new KyThiBUS();
                kyThiBUS.XoaKyThi(maKythi);
                ResetControls();
                ResetKyThi();
            }
        }

        private void btn_DSKyThi_Click(object sender, EventArgs e)
        {
            KyThiBUS kyThiBUS = new KyThiBUS();
            lstKyThi_Truoc = kyThiBUS.LayDSTatCaKyThi();
            lstKyThi_Sau = kyThiBUS.LayDSTatCaKyThi();

            dgv_DanhSach.DataSource = lstKyThi_Sau;
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if(!chk_ThemKythi.Checked && !chk_themNamhoc.Checked || chk_ThemKythi.Checked && chk_themNamhoc.Checked)
            {
                MessageBox.Show("Vui lòng chọn chức năng","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (chk_themNamhoc.Checked)
            {
                string tenNamHoc = dgv_DanhSach.CurrentRow.Cells["tenNamHoc"].Value.ToString();

                NamHocBUS namHocBUS = new NamHocBUS();
                namHocBUS.HoanThanhNamHoc(tenNamHoc);
                ResetForm();
                
            }
            else if(chk_ThemKythi.Checked)
            {
                string maKyThi = txt_MaKyThi.Text;
                
                KyThiBUS kyThiBUS = new KyThiBUS();
                kyThiBUS.HoanThanhKyThi(maKyThi);
                ResetKyThi();
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!chk_ThemKythi.Checked && !chk_themNamhoc.Checked || chk_ThemKythi.Checked && chk_themNamhoc.Checked)
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (chk_themNamhoc.Checked)
            {
                string tenNamHoc = dgv_DanhSach.CurrentRow.Cells["tenNamHoc"].Value.ToString();
                string trangThai =  cbb_TrangThai.Text;

                NamHocBUS namHocBUS = new NamHocBUS();
                namHocBUS.SuaNamHoc(tenNamHoc,trangThai);
                ResetForm();

            }
            else if (chk_ThemKythi.Checked)
            {
                string namHoc = cbb_NamHoc.Text;
                string maKyThi =  txt_MaKyThi.Text;
                string tenKyThi = txt_TenKyThi.Text;
                DateTime ngayBatDau = date_NgayBatDau.Value;
                DateTime ngayKetThuc = date_NgayKetThuc.Value;

                KyThiBUS kyThiBUS = new KyThiBUS();
                kyThiBUS.SuaKyThi(maKyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThuc);
                ResetKyThi();
            }
        }

        public void ResetControls()
        {
            txt_NamHoc.Text = "";
            cbb_NamHoc.SelectedIndex = -1;
            cbb_TrangThai.Text = string.Empty;
            txt_MaKyThi.Text = string.Empty;
            txt_TenKyThi.Text = string.Empty;
            date_NgayBatDau.Value = DateTime.Now;
            date_NgayKetThuc.Value = DateTime.Now;
        }

        public void ResetForm()
        {
            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> lst = namHocBUS.LayTatCaNamHoc();
            dgv_DanhSach.DataSource = lst;
        }
        public void ResetKyThi()
        {
            KyThiBUS kyThiBUS = new KyThiBUS();
            lstKyThi_Truoc = kyThiBUS.LayDSKyThi();
            lstKyThi_Sau = kyThiBUS.LayDSKyThi();

            dgv_DanhSach.DataSource = lstKyThi_Sau;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void chk_themNamhoc_CheckedChanged(object sender, EventArgs e)
        {
            chk_ThemKythi.Checked = false;
            ResetForm();
        }

        private void chk_ThemKythi_CheckedChanged(object sender, EventArgs e)
        {
            chk_themNamhoc.Checked = false;
            ResetKyThi();
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chk_ThemKythi.Checked)
            {
                string maKyThi = dgv_DanhSach.CurrentRow.Cells["maKyThi"].Value.ToString();
                string tenKyThi = dgv_DanhSach.CurrentRow.Cells["tenKyThi"].Value.ToString();
                string namHoc = dgv_DanhSach.CurrentRow.Cells["namHoc"].Value.ToString();
                DateTime ngaybatDau =(DateTime) dgv_DanhSach.CurrentRow.Cells["ngayBatDau"].Value;
                DateTime ngayKetThuc = (DateTime)dgv_DanhSach.CurrentRow.Cells["ngayKetThuc"].Value;

                txt_MaKyThi.Text = maKyThi;
                txt_TenKyThi.Text= tenKyThi;
                cbb_NamHoc.Text = namHoc;
                date_NgayBatDau.Value = ngaybatDau;
                date_NgayKetThuc.Value = ngayKetThuc;
            }
            else if(chk_themNamhoc.Checked)
            {
                string tenNamHoc = dgv_DanhSach.CurrentRow.Cells["tenNamHoc"].Value.ToString();
                string trangThai = dgv_DanhSach.CurrentRow.Cells["trangThai"].Value.ToString();

                txt_NamHoc.Text= tenNamHoc;
                cbb_TrangThai.Text = trangThai;
            }
        }
    }
}
