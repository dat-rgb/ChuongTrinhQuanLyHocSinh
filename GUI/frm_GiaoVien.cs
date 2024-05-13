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
    public partial class frm_GiaoVien : Form
    {
        public frm_GiaoVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void HienThiThongTinGiaoVien(string maGV)
        {
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            GiaoVienDTO giaoVienDTO = giaoVienBUS.HienThiThongTinGiaoVien(maGV);

            string hoTen = $"{giaoVienDTO.hoGV} {giaoVienDTO.tenGV}";

            txt_MaGV.Text = giaoVienDTO.maGV;
            txt_CCCD.Text = giaoVienDTO.cccd;
            txt_HoTen.Text = hoTen;
            date_NgaySinh.Value = giaoVienDTO.ngaySinh;
            txt_QueQuan.Text = giaoVienDTO.queQuan;
            txt_SoDienThoai.Text = giaoVienDTO.soDT;
            txt_Email.Text = giaoVienDTO.mail;
            txt_ChucVu.Text = giaoVienDTO.chucVu;
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = txt_MaGV.Text;
                string hoTen = txt_HoTen.Text.Trim();
                string soDT = txt_SoDienThoai.Text;
                string queQuan = txt_QueQuan.Text;
                string mail = txt_Email.Text;
                
                GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
                giaoVienBUS.CapNhatThongTinGiaoVien(maGV, hoTen, soDT, mail, queQuan);
                
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi...."+ex.Message);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
