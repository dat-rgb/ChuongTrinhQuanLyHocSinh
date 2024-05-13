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
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_HocSinh_Click(object sender, EventArgs e)
        {
            frm_QuanLyHocSinh quanLyHocSinh = new frm_QuanLyHocSinh();  
            quanLyHocSinh.Show();
        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            frm_QuanLyGiaoVien quanLyGiaoVien = new frm_QuanLyGiaoVien();
            quanLyGiaoVien.Show();
        }

        private void btn_MonHoc_Click(object sender, EventArgs e)
        {
            frm_QuanLyMonHoc quanLyMonHoc = new frm_QuanLyMonHoc();
            quanLyMonHoc.Show();
        }

        private void btn_LopHoc_Click(object sender, EventArgs e)
        {
            frm_QuanLyLopHoc quanLyLopHoc = new frm_QuanLyLopHoc();
            quanLyLopHoc.Show();
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
        private void btn_School_Click(object sender, EventArgs e)
        {
            frm_School school = new frm_School();
            school.Show();
        }

        private void btn_PhongHoc_Click(object sender, EventArgs e)
        {
            frm_QuanLyPhongHoc phongHoc = new frm_QuanLyPhongHoc();
            phongHoc.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            frm_ThongKe thongKe = new frm_ThongKe();
            thongKe.Show();
        }

        private void btn_ThuChi_Click(object sender, EventArgs e)
        {
            frm_QuanLyThuChi thuChi = new frm_QuanLyThuChi();
            thuChi.Show();
        }

        private void btn_LichThi_Click(object sender, EventArgs e)
        {
            frm_QuanLyLichThi quanLyLichThi = new frm_QuanLyLichThi();
            quanLyLichThi.Show();
        }

        private void btn_LichGiangDay_Click(object sender, EventArgs e)
        {
            frm_QuanLyLichGiangDay quanLyLichGiangDay = new frm_QuanLyLichGiangDay();
            quanLyLichGiangDay.Show();
        }
    }
}
