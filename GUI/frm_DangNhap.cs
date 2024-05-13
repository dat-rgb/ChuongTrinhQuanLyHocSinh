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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text)|| string.IsNullOrEmpty(cbb_LoaiTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Lấy thông tin từ giao diện
                    string tenTaiKhoan = txt_Username.Text;
                    string matKhau = txt_Password.Text;
                    string loaiTaiKhoan = cbb_LoaiTaiKhoan.Text;

                    // Gọi phương thức kiểm tra đăng nhập từ tầng BUS
                    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
                    bool dangNhapThanhCong = taiKhoanBUS.KiemTraDangNhap(tenTaiKhoan, matKhau, loaiTaiKhoan);

                    // Xử lý kết quả đăng nhập
                    if (dangNhapThanhCong)
                    {
                        if (loaiTaiKhoan == "admin")
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_QuanLy frmQuanLy = new frm_QuanLy();
                            frmQuanLy.ShowDialog();
                            this.Close();
                        }
                        else if (loaiTaiKhoan == "gv")
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_GiaoVien giaoVien = new frm_GiaoVien();
                            giaoVien.HienThiThongTinGiaoVien(tenTaiKhoan);

                            giaoVien.ShowDialog();
                            this.Close();

                        }
                        else if (loaiTaiKhoan == "hs")
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_HocSinh hocSinh = new frm_HocSinh();
                            hocSinh.HienThiThongTinHocSinh(tenTaiKhoan);

                            hocSinh.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
            }
        }




    }
}
