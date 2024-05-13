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
    public partial class frm_HocSinhDiem : Form
    {
        List<DiemDTO> lstDSDiem_Truoc = new List<DiemDTO>();
        List<DiemDTO> lstDSDiem_Sau = new List<DiemDTO>();
        public frm_HocSinhDiem()
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
                string ho = hocSinhDTO.hoHS;
                string ten = hocSinhDTO.tenHS;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin học sinh: " + ex.Message);
            }
        }
        private void frm_HocSinhDiem_Load(object sender, EventArgs e)
        {
            MonHocBUS monHocBUS = new MonHocBUS();
            List<MonHocDTO> lstMonHoc = monHocBUS.LayDSMonHoc();
            cbb_MonHoc.DataSource = lstMonHoc;
            cbb_MonHoc.DisplayMember = "tenMonHoc";
            cbb_MonHoc.ValueMember = "maMonHoc";

            cbb_MonHoc.SelectedIndex = -1;

            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> namHocDTO = namHocBUS.LayDSNamHoc();
            cbb_NamHoc.DataSource = namHocDTO;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";

            DiemBUS diemBUS = new DiemBUS();
            string hocSinh = txt_MaHS.Text;
            string hocKy = cbb_HocKy.SelectedValue.ToString();
            List<DiemDTO> diemDTOs = diemBUS.LayDSDiemTheoMaHSVaHocKy(hocSinh, hocKy);
            if (diemDTOs.Count == 0)
            {
                MessageBox.Show($"Bạn chưa có thông tin Điểm của học kỳ: {cbb_HocKy.Text}, năm học: {cbb_NamHoc.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dgv_DSDiem.DataSource = lstDSDiem_Sau;
            }

            
        }
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                DiemBUS diemBUS = new DiemBUS();
                if (string.IsNullOrEmpty(cbb_MonHoc.Text))
                {
                    string hocSinh = txt_MaHS.Text;
                    string hocKy = cbb_HocKy.SelectedValue.ToString();
                    lstDSDiem_Truoc = diemBUS.LayDSDiemTheoMaHSVaHocKy(hocSinh, hocKy);
                    lstDSDiem_Sau = diemBUS.LayDSDiemTheoMaHSVaHocKy(hocSinh, hocKy);
                    if (lstDSDiem_Sau.Count == 0)
                    {
                        MessageBox.Show($"Bạn chưa có thông tin Điểm của học kỳ: {cbb_HocKy.Text}, năm học: {cbb_NamHoc.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_DSDiem.DataSource = lstDSDiem_Sau;
                    }
                }
                else if (!string.IsNullOrEmpty(cbb_MonHoc.Text))
                {
                    string hocSinh = txt_MaHS.Text;
                    string hocKy = cbb_HocKy.SelectedValue.ToString();
                    string monHoc = cbb_MonHoc.SelectedValue.ToString();
                    lstDSDiem_Truoc = diemBUS.LayDSDiemTheoMaHSMonHocVaHocKy(hocSinh, monHoc, hocKy);
                    lstDSDiem_Sau = diemBUS.LayDSDiemTheoMaHSMonHocVaHocKy(hocSinh, monHoc, hocKy);
                    if (lstDSDiem_Sau.Count == 0 || lstDSDiem_Sau == null)
                    {
                        MessageBox.Show($"Bạn chưa có thông tin Điểm của học kỳ: {cbb_HocKy.Text}, môn: {cbb_MonHoc.Text}, năm học: {cbb_NamHoc.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_DSDiem.DataSource = lstDSDiem_Sau;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi...Chi tiết: " + ex.Message);
            }
        }
        private void dgv_DSDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
