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
using Microsoft.VisualBasic;
namespace GUI
{
    public partial class frm_HocSinh : Form
    {
        public frm_HocSinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void HienThiThongTinHocSinh(string maHS)
        {
            try
            {
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                HocSinhDTO hocSinhDTO = hocSinhBUS.HienThiThongTinHocSinh(maHS);

                // Hiển thị thông tin lên các control tương ứng trên form
                txt_MaHS.Text = hocSinhDTO.maHS;
                txt_CCCD.Text = hocSinhDTO.cccd;
                string ho = hocSinhDTO.hoHS;
                string ten = hocSinhDTO.tenHS;
                txt_HoTen.Text = $"{ho} {ten}";
                txt_Lop.Text = hocSinhDTO.lop;
                date_NgaySinh.Value = hocSinhDTO.ngaySinh;
                txt_QueQuan.Text = hocSinhDTO.queQuan;
                txt_SoDienThoai.Text = hocSinhDTO.soDT;
                txt_Email.Text = hocSinhDTO.mail;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin học sinh: " + ex.Message);
            }
        }
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            frm_HocSinhTraCuu hocSinhTraCuu = new frm_HocSinhTraCuu();
            hocSinhTraCuu.HienThiThongTinHocSinh(txt_MaHS.Text);
            hocSinhTraCuu.ShowDialog();
        }

        private void btn_XemDiem_Click(object sender, EventArgs e)
        {
            frm_HocSinhDiem hocSinhDiem = new frm_HocSinhDiem();
            hocSinhDiem.HienThiThongTinHocSinh(txt_MaHS.Text);
            hocSinhDiem.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin học sinh từ các controls trên giao diện
                string maHS = txt_MaHS.Text;              
                string hoTen = txt_HoTen.Text.Trim();
                string soDT = txt_SoDienThoai.Text;
                string queQuan = txt_QueQuan.Text;
                // Gọi phương thức cập nhật thông tin học sinh từ tầng BUS
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn cập nhật\n\n Mã HS: {maHS}\n\n Họ tên: {hoTen}\n\n Số DT: {soDT}\n\n Quê quán: {queQuan}","Xác Nhân", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HocSinhBUS hocSinhBUS = new HocSinhBUS();
                    hocSinhBUS.CapNhatThongTinHocSinh(maHS, hoTen, soDT, queQuan);
                    MessageBox.Show("Đã cập nhật thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin học sinh: " + ex.Message);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }
    }
}
