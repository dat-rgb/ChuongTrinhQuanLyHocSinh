using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QuanLyLichGiangDay : Form
    {
        List<LichGiangDayDTO> dsLichGiangDay_Truoc = new List<LichGiangDayDTO>();
        List<LichGiangDayDTO> dsLichGiangDay_Sau = new List<LichGiangDayDTO>();
        public frm_QuanLyLichGiangDay()
        {
            InitializeComponent();
        }
        private void frm_QuanLyLichGiangDay_Load(object sender, EventArgs e)
        {
            ResetForm();
            MonHocBUS monHocBUS = new MonHocBUS();
            List<MonHocDTO> dsMonHoc = monHocBUS.LayDSMonHoc();
            cbb_Mon.DataSource = dsMonHoc;
            cbb_Mon.DisplayMember = "tenMonHoc";
            cbb_Mon.ValueMember = "maMonHoc";
            cbb_Mon.SelectedIndex = -1;

        }
        public void ResetControls()
        {
            txt_MaLich.Text =string.Empty;
            cbb_Thu.SelectedIndex = -1;
            date_NgayBatBau.Value = DateTime.Now;
            date_NgayKetThuc.Value = DateTime.Now;
            cbb_Mon.SelectedIndex = -1;
            cbb_GiaoVien.SelectedIndex = -1;
            nud_TietBatDau.Value = 1;
            nud_TietKetThu.Value = 1;
            cbb_Lop.SelectedIndex = -1;
            cbb_Buoi.SelectedIndex = -1;

        }
        public void ResetForm()
        {
            MonHocBUS monHocBUS = new MonHocBUS();
            List<MonHocDTO> dsMonHoc = monHocBUS.LayDSMonHoc();
            cbb_Mon.DataSource = dsMonHoc;
            cbb_Mon.DisplayMember = "tenMonHoc";
            cbb_Mon.ValueMember = "maMonHoc";
            cbb_Mon.SelectedIndex = -1;

            LopHocBUS lopHocBUS = new LopHocBUS();
            List<LopHocDTO> dsLopHoc = lopHocBUS.LayDSLop();
            cbb_Lop.DataSource = dsLopHoc;
            cbb_Lop.DisplayMember = "tenLop";
            cbb_Lop.ValueMember = "maLop";

            cbb_Lop.SelectedIndex = -1;
           

            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            List<GiaoVienDTO> giaoVienDTOs = giaoVienBUS.LayDSGVLenCombobox();
            cbb_GiaoVien.DataSource = giaoVienDTOs;
            cbb_GiaoVien.DisplayMember = "tenGV";
            cbb_GiaoVien.ValueMember = "maGV";
            cbb_GiaoVien.SelectedIndex = -1;

            LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
            dsLichGiangDay_Truoc = lichGiangDayBUS.LayDSLichGiangDay();
            dsLichGiangDay_Sau = lichGiangDayBUS.LayDSLichGiangDay();

            dgv_DSLichGiangDay.DataSource = dsLichGiangDay_Sau;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void cbb_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
            List<GiaoVienDTO> dsGiaoVienPhanCongMonDay = new List<GiaoVienDTO>();
            if (string.IsNullOrEmpty(cbb_Mon.Text))
            {
                dsGiaoVienPhanCongMonDay = giaoVienBUS.LayDSGVLenCombobox();
              
            }
            else 
            {
                string monDay = cbb_Mon.SelectedValue.ToString();
                dsGiaoVienPhanCongMonDay = giaoVienBUS.LayDSGVPhanCongTheoMonDay(monDay);
             
            }
            cbb_GiaoVien.DataSource = dsGiaoVienPhanCongMonDay;
            cbb_GiaoVien.DisplayMember = "tenGV";
            cbb_GiaoVien.ValueMember = "maGV";
            cbb_GiaoVien.SelectedIndex = -1;
        }
        private void btn_TaoLich_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbb_Mon.Text)|| string.IsNullOrEmpty(cbb_GiaoVien.Text) || string.IsNullOrEmpty(cbb_Lop.Text) || string.IsNullOrEmpty(cbb_TrangThai.Text)|| string.IsNullOrEmpty(cbb_Buoi.Text)|| cbb_TrangThai.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string thu, monHoc, lop, giaoVien, trangThai;
                DateTime ngayBatDau, ngayKetThuc;
                int buoi, tietBatDau, tietKetThuc;

                thu = cbb_Thu.Text;
                monHoc = cbb_Mon.SelectedValue.ToString();
                lop = cbb_Lop.SelectedValue.ToString();
                giaoVien = cbb_GiaoVien.SelectedValue.ToString();
                trangThai = cbb_TrangThai.Text;
                ngayBatDau = date_NgayBatBau.Value;
                ngayKetThuc = date_NgayKetThuc.Value;
                buoi = cbb_Buoi.SelectedIndex;
                tietBatDau = (int)nud_TietBatDau.Value;
                tietKetThuc = (int)nud_TietKetThu.Value;
                
                string sNgayBatDau = ngayBatDau.ToString("dd/MM/yyyy");
                string sNgayKetThuc = ngayKetThuc.ToString("dd/MM/yyyy");

                string xacNhan = $" Bạn muốn tạo lịch giảng dạy?\n\n Thông tin nhập \n\n Giáo viên: {cbb_GiaoVien.Text}\n Môn: {cbb_Mon.Text}\n ----------------------------\n";
                xacNhan += $" Tiết : {tietBatDau}, kết thúc: {tietKetThuc}\n Ngày dạy: {thu}\n Áp dụng ngày: {sNgayBatDau} đến {sNgayKetThuc}";
                DialogResult dialogResult = MessageBox.Show(xacNhan, "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
                    lichGiangDayBUS.TaoLichGiangDay(thu, ngayBatDau, ngayKetThuc, monHoc, buoi, tietBatDau, tietKetThuc, lop, giaoVien, trangThai);
                    ResetForm();
                }
            }
        }//xong
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
        
            string monDay, giaoVien, lop, thu, trangThai;
            int buoi, tietBatDau, tietKetThuc, maLich;
            DateTime ngayBatDau, ngayKetThuc;
            maLich = int.Parse(txt_MaLich.Text);
            monDay = cbb_Mon.SelectedValue.ToString();
            giaoVien = cbb_GiaoVien.SelectedValue.ToString();
            lop = cbb_Lop.SelectedValue.ToString();
            thu = cbb_Thu.Text;
            string sBuoi = cbb_Buoi.Text;
            buoi = (sBuoi == "Sáng") ? 0 : 1;
            tietBatDau = (int)nud_TietBatDau.Value;
            tietKetThuc = (int)nud_TietKetThu.Value;
            ngayBatDau = date_NgayBatBau.Value;
            ngayKetThuc = date_NgayKetThuc.Value;
            trangThai = cbb_TrangThai.Text;

            string sNgayBatDau = ngayBatDau.ToString("dd/MM/yyyy");
            string sNgayKetThuc = ngayKetThuc.ToString("dd/MM/yyyy");
            string xacNhan = $" Bạn muốn xóa lịch giảng dạy có mã: {maLich}?\n\n Giáo viên: {cbb_GiaoVien.Text}\n Môn: {cbb_Mon.Text}\n ----------------------------\n";
            xacNhan += $" \n Lớp: {cbb_Lop.Text}\n Tiết : {tietBatDau}, kết thúc: {tietKetThuc}\n Ngày dạy: {thu}\n Trạng thái: {trangThai}\n Áp dụng ngày: {sNgayBatDau} đến {sNgayKetThuc}";
            DialogResult dialogResult1 = MessageBox.Show(xacNhan, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult1 == DialogResult.Yes)
            {
                LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
                lichGiangDayBUS.XoaLichGiangDay(maLich);
                ResetControls();
                ResetForm();
            }
        
        }//xong
        private void dgv_DSLichGiangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DSLichGiangDay.Rows.Count)
            {
                LayThongTinTuDataGridView();
            }
        }
        public void LayThongTinTuDataGridView()
        {

            string monDay, giaoVien, lop, thu, trangThai;
            int buoi, tietBatDau, tietKetThuc, maLich;
            DateTime ngayBatDau, ngayKetThuc;

            maLich = (int)dgv_DSLichGiangDay.CurrentRow.Cells["maLich"].Value;
            monDay = dgv_DSLichGiangDay.CurrentRow.Cells["monHoc"].Value.ToString();
            giaoVien = dgv_DSLichGiangDay.CurrentRow.Cells["giaoVien"].Value.ToString();
            lop = dgv_DSLichGiangDay.CurrentRow.Cells["lop"].Value.ToString();
            thu = dgv_DSLichGiangDay.CurrentRow.Cells["thu"].Value.ToString();
            buoi = (int)dgv_DSLichGiangDay.CurrentRow.Cells["buoi"].Value;
            tietBatDau = (int)dgv_DSLichGiangDay.CurrentRow.Cells["tietBatDau"].Value;
            tietKetThuc = (int)dgv_DSLichGiangDay.CurrentRow.Cells["tietKetThuc"].Value;
            ngayBatDau = (DateTime)dgv_DSLichGiangDay.CurrentRow.Cells["ngayBatDau"].Value;
            ngayKetThuc = (DateTime)dgv_DSLichGiangDay.CurrentRow.Cells["ngayKetThuc"].Value;
            trangThai = dgv_DSLichGiangDay.CurrentRow.Cells["trangThai"].Value.ToString();

            string sBuoi = (buoi == 0) ? "Sáng" : "Chiều";

            txt_MaLich.Text = maLich.ToString();
            cbb_Mon.Text = monDay;
            cbb_GiaoVien.Text = giaoVien;
            cbb_Lop.Text = lop;
            cbb_Thu.Text = thu;
            cbb_Buoi.Text = sBuoi.ToString();
            nud_TietBatDau.Value = tietBatDau;
            nud_TietKetThu.Value = tietKetThuc;
            date_NgayBatBau.Value = ngayBatDau;
            date_NgayKetThuc.Value = ngayKetThuc;
            cbb_TrangThai.Text = trangThai;
        }
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if(date_NgayBatBau.Value == DateTime.Now || date_NgayKetThuc.Value == DateTime.Now)
            {
                MessageBox.Show("Nhập ngày để hoàn thành", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DateTime ngayBatDau, ngayKetThuc;
                ngayBatDau = date_NgayBatBau.Value;
                ngayKetThuc = date_NgayKetThuc.Value;

                string sNgayBatDau = ngayBatDau.ToString("dd/MM/yyyy");
                string sNgayKetThuc = ngayKetThuc.ToString("dd/MM/yyyy");
                string xacNhan = $"Bạn muốn hoàn thành các lịch giảng dạy được áp dụng ngày: {sNgayBatDau} đến {sNgayKetThuc}";
                DialogResult dialogResult = MessageBox.Show(xacNhan, "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
                    bool hoanThanh = lichGiangDayBUS.HoanThanhLichGiangDay(ngayBatDau, ngayKetThuc);
                    if(hoanThanh)
                    {
                        MessageBox.Show("Kết thúc lịch giảng dạy thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show($"Không có lịch giảng dạy nào được áp dụng ngày: {sNgayBatDau} đến {sNgayKetThuc}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }//xong
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Mon.Text) || string.IsNullOrEmpty(cbb_GiaoVien.Text) || string.IsNullOrEmpty(cbb_Lop.Text) || string.IsNullOrEmpty(cbb_TrangThai.Text) || string.IsNullOrEmpty(cbb_Buoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string monDay, giaoVien, lop, thu, trangThai;
            int buoi, tietBatDau, tietKetThuc, maLich;
            DateTime ngayBatDau, ngayKetThuc;
            maLich = int.Parse(txt_MaLich.Text);
            monDay = cbb_Mon.SelectedValue.ToString();
            giaoVien = cbb_GiaoVien.SelectedValue.ToString();
            lop = cbb_Lop.SelectedValue.ToString();
            thu = cbb_Thu.Text;
            string sBuoi = cbb_Buoi.Text;
            buoi = (sBuoi == "Sáng") ? 0 : 1;
            tietBatDau = (int)nud_TietBatDau.Value;
            tietKetThuc = (int)nud_TietKetThu.Value;
            ngayBatDau = date_NgayBatBau.Value;
            ngayKetThuc = date_NgayKetThuc.Value;
            trangThai = cbb_TrangThai.Text;
            string sNgayBatDau = ngayBatDau.ToString("dd/MM/yyyy");
            string sNgayKetThuc = ngayKetThuc.ToString("dd/MM/yyyy");
            string xacNhan = $" Bạn muốn cập nhật lịch giảng dạy?\n\n Mã lịch: {maLich}\n Giáo viên: {cbb_GiaoVien.Text}\n Môn: {cbb_Mon.Text}\n ----------------------------\n";
            xacNhan += $" Tiết : {tietBatDau}, kết thúc: {tietKetThuc}\n Ngày dạy: {thu}\n Trạng thái: {trangThai}\n Áp dụng ngày: {sNgayBatDau} đến {sNgayKetThuc}";
            DialogResult dialogResult1 = MessageBox.Show(xacNhan, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult1 == DialogResult.Yes)
            {
                LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
                lichGiangDayBUS.CapNhatLichGiangDay(maLich, thu, ngayBatDau, ngayKetThuc, monDay, buoi, tietBatDau, tietKetThuc, lop, giaoVien, trangThai);
                ResetForm();
            }
        
        }//xong

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
            List<LichGiangDayDTO>lst = new List<LichGiangDayDTO>();

            if (string.IsNullOrEmpty(cbb_Lop.Text) && string.IsNullOrEmpty(cbb_Mon.Text) || string.IsNullOrEmpty(cbb_TrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp hoặc môn học để tìm kiếm","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!string.IsNullOrEmpty(cbb_Lop.Text)&& string.IsNullOrEmpty(cbb_Mon.Text) && string.IsNullOrEmpty(cbb_GiaoVien.Text))
            {
                string lop = cbb_Lop.SelectedValue.ToString();
                string trangThai = cbb_TrangThai.Text;
              
                lst = lichGiangDayBUS.LayDSLichGiangDayTheoLop(lop, trangThai);
                if(lst.Count ==0 || lst == null)
                {
                    MessageBox.Show($"Không có Lớp: {cbb_Lop.Text} trong danh sách lịch giảng dạy","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                }
                
            }
            else if(string.IsNullOrEmpty(cbb_Lop.Text) && !string.IsNullOrEmpty(cbb_Mon.Text) && string.IsNullOrEmpty(cbb_GiaoVien.Text))
            {
                string mon = cbb_Mon.SelectedValue.ToString();
                string trangThai = cbb_TrangThai.Text;
               
                lichGiangDayBUS.LayDSLichGiangDayTheoMonHoc(mon, trangThai);
                if (lst.Count == 0 || lst == null)
                {
                    MessageBox.Show($"Không có Môn: {cbb_Mon.Text} trong danh sách lịch giảng dạy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                }
                else
                {
                    dgv_DSLichGiangDay.DataSource = lst;
                }
            }
            else if (string.IsNullOrEmpty(cbb_Lop.Text) && !string.IsNullOrEmpty(cbb_Mon.Text) && !string.IsNullOrEmpty(cbb_GiaoVien.Text))
            {
                string mon = cbb_Mon.SelectedValue.ToString();
                string giaoVien = cbb_GiaoVien.SelectedValue.ToString();
                string trangThai = cbb_TrangThai.Text;

                lichGiangDayBUS.LayDSLichGiangDayTheoMonHocGiaoVien(mon, giaoVien, trangThai);
                if (lst.Count == 0 || lst == null)
                {
                    MessageBox.Show($"Không có Giáo viên: {cbb_GiaoVien.Text} - Dạy môn: {cbb_Mon.Text} trong danh sách lịch giảng dạy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                }
                else
                {
                    dgv_DSLichGiangDay.DataSource = lst;
                }
            }
           
        }
        private void cbb_TrangThai_ChonLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbb_TrangThai_ChonLoc.Text;
            LichGiangDayBUS lichGiangDayBUS = new LichGiangDayBUS();
            dsLichGiangDay_Truoc = lichGiangDayBUS.LayDSLichGiangDayTheoTrangThai(trangThai);
            dsLichGiangDay_Sau = lichGiangDayBUS.LayDSLichGiangDayTheoTrangThai(trangThai);

            dgv_DSLichGiangDay.DataSource = dsLichGiangDay_Sau;
        }
    }   
}
