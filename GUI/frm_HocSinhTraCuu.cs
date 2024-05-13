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
    public partial class frm_HocSinhTraCuu : Form
    {
        public frm_HocSinhTraCuu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát","Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        public void HienThiThongTinHocSinh(string maHS)
        {
            try
            {
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                HocSinhDTO hocSinhDTO = hocSinhBUS.HienThiThongTinHocSinh(maHS);
                txt_MaHS.Text = hocSinhDTO.maHS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin học sinh: " + ex.Message);
            }
        }
        private void frm_HocSinhTraCuu_Load(object sender, EventArgs e)
        {
            LoaiPhieuBUS loaiPhieuBUS = new LoaiPhieuBUS();
            List<LoaiPhieuDTO> loaiPhieuDTO = loaiPhieuBUS.LayDSLoaiPhieu();
            cbb_LoaiThuChi.DataSource = loaiPhieuDTO;
            cbb_LoaiThuChi.DisplayMember = "tenPhieu";
            cbb_LoaiThuChi.ValueMember = "maLoaiPhieu";
            cbb_LoaiThuChi.SelectedIndex = -1;

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

           
        }
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            string maHS = txt_MaHS.Text;
            if(!rad_Diem.Checked && !rad_khoangthu.Checked)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                return;
            }
            else
            {
                if (rad_khoangthu.Checked)
                {
                    if (string.IsNullOrEmpty(cbb_LoaiThuChi.Text))
                    {
                        MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        return;
                    }
                    else
                    {
                        string loaiPhieu = cbb_LoaiThuChi.SelectedValue.ToString();
                        ThuChiBUS traCuuThuChi = new ThuChiBUS();
                        bool ketQua = traCuuThuChi.KiemTraThuChi(maHS, loaiPhieu);
                        if (!ketQua)
                        {
                            MessageBox.Show($"Bạn chưa hoàn thành: {cbb_LoaiThuChi.Text}!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Bạn đã hoàn thành: {cbb_LoaiThuChi.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (rad_Diem.Checked)
                {
                    if (string.IsNullOrEmpty(cbb_MonHoc.Text))
                    {
                        MessageBox.Show("Vui lòng chọn thông tin cần tra cứu");
                        return;
                    }
                    else
                    {
                        string monHoc = cbb_MonHoc.SelectedValue.ToString();
                        string hocSinh = txt_MaHS.Text;
                        string hocKy = cbb_HocKy.SelectedValue.ToString();

                        DiemBUS diemBUS = new DiemBUS();
                        List<DiemDTO> dsDiem = diemBUS.LayDSDiemTheoMaHSMonHocVaHocKy(hocSinh, monHoc, hocKy);

                        string kq = "";
                        kq += $"  Mã HS:  {hocSinh}\n  Môn:  {cbb_MonHoc.Text}\n";
                        kq += $"  {cbb_HocKy.Text}\n  Năm học: {cbb_NamHoc.Text}\n";

                        if (dsDiem.Count == 0 || dsDiem == null)
                        {
                            kq += "\n  Điểm chưa cập nhật.";
                        }
                        else
                        {
                            foreach (DiemDTO diem in dsDiem)
                            {
                                kq += $"\n  Điểm TX:  {diem.diemTX}\n";
                                kq += $"\n  Điểm KT 1:  {diem.diemKT1}\n";
                                kq += $"\n  Điểm KT 2:  {diem.diemKT2}\n";
                                kq += $"\n  Điểm Thi:  {diem.diemThi}\n";
                                kq += $"\n  Điểm TB:  {diem.diemTB}\n";
                            }
                        }                    
                        MessageBox.Show(kq, "Thông tin Điểm", MessageBoxButtons.OK);
                    }
                }

            }
        }
        
    }
}
