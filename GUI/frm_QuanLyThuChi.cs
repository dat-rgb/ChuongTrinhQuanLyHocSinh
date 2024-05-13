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
    public partial class frm_QuanLyThuChi : Form
    {
        public frm_QuanLyThuChi()
        {
            InitializeComponent();
        }

        private void frm_QuanLyThuChi_Load(object sender, EventArgs e)
        {
            LoaiPhieuBUS loaiPhieuBUS = new LoaiPhieuBUS();
            List<LoaiPhieuDTO> loaiPhieuDTO = loaiPhieuBUS.LayDSLoaiPhieu();

            cbb_LoaiPhieu.DataSource = loaiPhieuDTO;
            cbb_LoaiPhieu.DisplayMember = "tenPhieu";
            cbb_LoaiPhieu.ValueMember = "maLoaiPhieu";
            cbb_LoaiPhieu.SelectedIndex = -1;

            dgv_DanhSach.DataSource = loaiPhieuDTO;

        }
    }
}
