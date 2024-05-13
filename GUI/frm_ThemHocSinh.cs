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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class frm_ThemHocSinh : Form
    {
        public frm_ThemHocSinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void frm_ThemHocSinh_Load(object sender, EventArgs e)
        {
            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> layDSNamHoc = namHocBUS.LayDSNamHoc();
            cbb_NamHoc.DataSource = layDSNamHoc;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";

            LopHocBUS lopHocBUS = new LopHocBUS();
            List<LopHocDTO> layDSLopHoc = lopHocBUS.LayDSLopTheoNamHoc(cbb_NamHoc.SelectedValue.ToString());
            cbb_LopHoc.DataSource = layDSLopHoc;
            cbb_LopHoc.DisplayMember = "tenLop";
            cbb_LopHoc.ValueMember = "maLop";
            cbb_LopHoc.SelectedIndex = -1;
        }//xong
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nhập thiếu thông tin
                if (string.IsNullOrEmpty(txt_MaHS.Text) || string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_SoCCCD.Text) || string.IsNullOrEmpty(txt_QueQuan.Text) || string.IsNullOrEmpty(txt_SoDienThoai.Text) || string.IsNullOrEmpty(txt_Email.Text) || cbb_GioiTinh.SelectedIndex == -1 || cbb_LopHoc.SelectedIndex == -1 || cbb_NamHoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Khai báo các thuộc tính học sinh;
                string maHS, cccd, hoHS, tenHS, queQuan, soDT, mail, lop, trangThai;
                int gioiTinh;
                DateTime ngaySinh, namNhapHoc;

                //check thông tin;
                string hoTen = txt_HoTen.Text;
                int viTriKhoangTrangCuoi = hoTen.LastIndexOf(' ');
                if (viTriKhoangTrangCuoi > 0)
                {
                    tenHS = hoTen.Substring(viTriKhoangTrangCuoi + 1);
                    hoHS = hoTen.Remove(viTriKhoangTrangCuoi).Trim();
                }
                else
                {
                    MessageBox.Show("Họ và tên sai định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime ngayHienTai = DateTime.Now;
                DateTime checkNgaySinh = date_NgaySinh.Value;
                if(checkNgaySinh < ngayHienTai)
                {
                    ngaySinh = checkNgaySinh;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maHS = txt_MaHS.Text;
                cccd = txt_HoTen.Text;
                gioiTinh = cbb_GioiTinh.SelectedIndex;
                queQuan = txt_QueQuan.Text;
                soDT = txt_SoDienThoai.Text;
                mail = txt_Email.Text;
                lop = cbb_LopHoc.SelectedValue.ToString();
                namNhapHoc = date_NamNhapHoc.Value;
                trangThai = txt_TrangThai.Text;
              
                // Hiển thị hộp thoại xác nhận
                string tb = $"Thêm học sinh:\n\nMã HS: {maHS}\n\nSố CCCD: {cccd}\n\nHọ và tên: {hoHS} {tenHS}\n\nGiới tính{cbb_GioiTinh.Text}\n\n";
                tb += $"Ngày sinh: {ngaySinh}\n\nQuê quán: {queQuan}\n\nSố DT: {soDT}\n\nEmail: {mail}\n\nLớp: {cbb_LopHoc.Text}\n\nNăm nhập học: {namNhapHoc}\n\nTrạng thái: {trangThai}\n------------------------------";

                DialogResult dialogResult = MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HocSinhBUS hocSinhBUS = new HocSinhBUS();
                    bool add = hocSinhBUS.AddHocSinh(maHS, cccd, hoHS, tenHS, gioiTinh, ngaySinh, queQuan, soDT, mail, lop, namNhapHoc, trangThai);
                    if(add)
                    {
                        ResetInputControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//xong
        private void ResetInputControls()
        {
            txt_MaHS.Text = "";
            txt_HoTen.Text = "";
            txt_SoCCCD.Text = "";
            txt_QueQuan.Text = "";
            txt_SoDienThoai.Text = "";
            txt_Email.Text = "";
            cbb_GioiTinh.SelectedIndex = -1;
            cbb_LopHoc.SelectedIndex = -1;
            cbb_NamHoc.SelectedIndex = -1;
        }//xong
        public void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào
            }
        }//xong
        public void RangBuocDoDaiDuLieu(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text.Length > 10)
            {
                txt_SoDienThoai.Text = txt_SoDienThoai.Text.Substring(0, 10);
                MessageBox.Show("Số điện thoại chỉ nhập 10 số","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);// Chỉ lấy 10 ký tự đầu tiên
               
            }
            if(txt_SoCCCD.Text.Length > 12)
            {
                txt_SoCCCD.Text = txt_SoCCCD.Text.Substring(0,12);
                MessageBox.Show("Số CCCD sai định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txt_MaHS.Text.Length > 30)
            {
                txt_MaHS.Text = txt_MaHS.Text.Substring (0,30);
                MessageBox.Show("Mã học sinh sai định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txt_HoTen.Text.Length > 250) 
            {
                txt_HoTen.Text = txt_HoTen.Text.Substring(0, 250);
            }
        }//xong
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes) 
            {
                Close();
            }
        }//xong
    }
}
