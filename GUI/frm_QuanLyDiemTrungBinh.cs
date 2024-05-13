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
    public partial class frm_QuanLyDiemTrungBinh : Form
    {
        public frm_QuanLyDiemTrungBinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_QuanLyDiemTrungBinh_Load(object sender, EventArgs e)
        {
            NamHocBUS namHocBUS = new NamHocBUS();
            List<NamHocDTO> namHocDTO = namHocBUS.LayDSNamHoc();
            cbb_NamHoc.DataSource = namHocDTO;
            cbb_NamHoc.DisplayMember = "tenNamHoc";
            cbb_NamHoc.ValueMember = "tenNamHoc";
        }
        private void btn_TinhDiemTBHK_Click(object sender, EventArgs e)
        {
            string hocKy = cbb_HocKy.SelectedValue.ToString();
            DiemBUS tinhDiemTrungBinhBUS = new DiemBUS();
            List<DiemTrungBinhDTO> diemTB = tinhDiemTrungBinhBUS.TinhDiemTrungBinhHocKy1(hocKy);
            dgv_DanhSachDiemHS.DataSource = diemTB;
        }
    }
}
