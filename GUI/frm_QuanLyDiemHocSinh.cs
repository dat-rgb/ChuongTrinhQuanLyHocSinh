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
    public partial class frm_QuanLyDiemHocSinh : Form
    {
        List<DiemDTO>lstDiem_Truoc = new List<DiemDTO>();
        List<DiemDTO> lstDiem_Sau = new List<DiemDTO>();

        public frm_QuanLyDiemHocSinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_QuanLyDiemHocSinh_Load(object sender, EventArgs e)
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
            lstDiem_Truoc = diemBUS.LayDSDiem();
            lstDiem_Sau = diemBUS.LayDSDiem();

            dgv_QuanLyDanhSachDiemHS.DataSource = lstDiem_Sau;
        }
       
        private void btn_XemDiemTB_Click(object sender, EventArgs e)
        {
            frm_QuanLyDiemTrungBinh frm_QuanLyDiemTrungBinh = new frm_QuanLyDiemTrungBinh();
            frm_QuanLyDiemTrungBinh.ShowDialog();
        }
        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            DiemBUS diemBUS = new DiemBUS();
            lstDiem_Truoc = diemBUS.LayDSDiem();
            lstDiem_Sau = diemBUS.LayDSDiem();

            dgv_QuanLyDanhSachDiemHS.DataSource = lstDiem_Sau;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string lopHoc = cbb_LopHoc.SelectedValue.ToString();
                string hocky = cbb_HocKy.SelectedValue.ToString();
                DiemBUS diemBUS = new DiemBUS();
                if (string.IsNullOrEmpty(cbb_MonHoc.Text))
                {
                    lstDiem_Truoc = diemBUS.LayDSDiemLopHocVaHocKy(lopHoc, hocky);
                    if (lstDiem_Truoc.Count == 0 || lstDiem_Truoc == null)
                    {
                        MessageBox.Show($"Chưa có danh sách điểm của lớp: {cbb_LopHoc.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_QuanLyDanhSachDiemHS.DataSource = lstDiem_Truoc;
                    }

                }else
                {
                    string monHoc = cbb_MonHoc.SelectedValue.ToString();
                    lstDiem_Truoc = diemBUS.LayDSDiemTheoLopMonHocVaHocKy(lopHoc, monHoc, hocky);
                    if (lstDiem_Truoc.Count == 0 || lstDiem_Truoc == null)
                    {
                        MessageBox.Show($"Chưa có danh sách điểm Môn: {cbb_MonHoc.Text}, của lớp: {cbb_LopHoc.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dgv_QuanLyDanhSachDiemHS.DataSource = lstDiem_Truoc;
                    }
                }
               
                
               
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi...Chi tiết: " + ex.Message);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có hàng nào được chọn
                if (dgv_QuanLyDanhSachDiemHS.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một học sinh để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin học sinh và môn học từ hàng hiện tại trong DataGridView
                string hocSinh = dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["hocSinh"].Value.ToString();
                string monHoc = dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["monHoc"].Value.ToString();

                // Hiển thị hộp thoại xác nhận từ người dùng
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa điểm của học sinh {hocSinh}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng xác nhận muốn xóa
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa dữ liệu
                    DiemBUS diemBUS = new DiemBUS();
                    diemBUS.XoaDiem(hocSinh, monHoc);

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Đã xóa điểm của học sinh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại dữ liệu trên DataGridView (nếu cần)
                    // Cập nhậtDanhSachDiemHS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa điểm của học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_QuanLyDanhSachDiemHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các ô trong hàng hiện tại của DataGridView
                string hocSinh = dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["hocSinh"].Value.ToString();
                string monHoc = dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["monHoc"].Value.ToString();
                string hocKy = dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["hocKy"].Value.ToString();
                float diemTX = float.Parse(dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["diemTX"].Value.ToString());
                float diemKT1 = float.Parse(dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["diemKT1"].Value.ToString());
                float diemKT2 = float.Parse(dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["diemKT2"].Value.ToString());
                float diemThi = float.Parse(dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["diemThi"].Value.ToString());
                float diemTB = float.Parse(dgv_QuanLyDanhSachDiemHS.CurrentRow.Cells["diemTB"].Value.ToString());

                DiemBUS diemBUS = new DiemBUS();
                DiemDTO diemDTO = diemBUS.LayDuLieuTuDataGridView(hocSinh, monHoc, hocKy, diemTX, diemKT1, diemKT2, diemThi, diemTB);

                txt_MaHS.Text = hocSinh.ToString();
                cbb_MonHoc.Text = monHoc.ToString();
                cbb_HocKy.Text = hocKy.ToString();
                txt_DiemTX.Text = diemTX.ToString();
                txt_DiemKT1.Text = diemKT1.ToString();
                txt_DiemKT2.Text = diemKT2.ToString();
                txt_DiemThi.Text = diemThi.ToString();
                txt_DiemTB.Text = diemTB.ToString();


            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
