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
    public partial class frm_QuanLyLichThi : Form
    {
        public frm_QuanLyLichThi()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbb_Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khoi = cbb_Khoi.Text;
            string thongBao = "";
            int soLuongHS;
            int soLuongHSTrongLichThi;
            int conLai;
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            soLuongHS = hocSinhBUS.DemSoLuongHocSinhTheoKhoi(khoi);
            soLuongHSTrongLichThi = hocSinhBUS.DemSoLuongHocSinhTrongLichThi(khoi, thongBao);
            conLai = soLuongHS - soLuongHSTrongLichThi;

            thongBao += $" Số lượng học sinh khối {khoi}: {soLuongHS}\n Đã sắp: {soLuongHSTrongLichThi}\n Còn lại: {conLai}";

            rtxt_ThongkeCoBan.Text = thongBao;
        }

        private void cbb_MonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string monHoc = cbb_MonThi.SelectedValue.ToString();
            string khoi = cbb_Khoi.Text;
            string thongBao = "";
            int soLuongHS;
            int soLuongHSTrongLichThi;
            int conLai;
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            soLuongHS = hocSinhBUS.DemSoLuongHocSinhTheoKhoi(khoi);
            soLuongHSTrongLichThi = hocSinhBUS.DemSoLuongHocSinhTrongLichThi(khoi, monHoc);
            conLai = soLuongHS - soLuongHSTrongLichThi;

            thongBao += $" Số lượng học sinh khối {khoi}: {soLuongHS}\n Môn: {cbb_MonThi.Text}\n Đã sắp: {soLuongHSTrongLichThi}\n Còn lại: {conLai}";

            rtxt_ThongkeCoBan.Text = thongBao;
        }

        private void frm_QuanLyLichThi_Load(object sender, EventArgs e)
        {
            MonHocBUS monHocBUS = new MonHocBUS();
            //hiển thị danh sách môn học lên combobox
            List<MonHocDTO> lstMonHoc = monHocBUS.LayDSMonHoc();
            cbb_MonThi.DataSource = lstMonHoc;
            cbb_MonThi.DisplayMember = "tenMonHoc";
            cbb_MonThi.ValueMember = "maMonHoc";
            cbb_MonThi.SelectedIndex = -1;

        }
    }
}
