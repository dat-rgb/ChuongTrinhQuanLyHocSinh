using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class LopHocBUS
    {     
        public List<LopHocDTO> LayDSLop()
        {
            LopHocDAO lopHocDAO = new LopHocDAO();
            List<LopHocDTO> lst = lopHocDAO.LayDSLop();

            return lst;
        }
        public LopHocDTO LayDuLieuTuDataGridView(string maLop, string tenLop, int soLuongHS, string giaoVienCN, string phongHoc, string namHoc)
        {
            LopHocDAO lopHocDAO=new LopHocDAO();
            return lopHocDAO.LayDuLieuTuDataGridView(maLop, tenLop, soLuongHS, giaoVienCN, phongHoc, namHoc);
        }
        public List<LopHocDTO> LayDSLopTheoNamHoc(string namHoc)
        {
            LopHocDAO lopHocDAO = new LopHocDAO();
            List<LopHocDTO> lst = lopHocDAO.LayDSLopTheoNamHoc(namHoc);
          
            return lst;
        }
        public void XoaLop(string maLop)
        {
            try
            {
                LopHocDAO lopHocDAO = new LopHocDAO();
                // Kiểm tra xem lớp học có tồn tại học sinh không
                if (lopHocDAO.KiemTraTonTaiHocSinhTrongLop(maLop))
                {
                    MessageBox.Show("Không thể xóa lớp học vì có học sinh trong lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật trạng thái của lớp học thành '2'
                lopHocDAO.XoaLop_CapNhatTrangThaiLop(maLop);

                MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void themLop(string maLop, string tenLop, int soLuongHS, string giaoVienCN, string phongHoc, string namHoc)
        {
            try
            {
                LopHocDAO lopHocDAO = new LopHocDAO();

                // Kiểm tra xem lớp đã tồn tại chưa
                if (!lopHocDAO.KiemTraMaLopTrung(maLop))
                {
                    // Kiểm tra xem giáo viên chủ nhiệm đã được phân công cho lớp khác chưa
                    if (!lopHocDAO.KiemTraGVCNTrung(giaoVienCN,namHoc))
                    {
                        // Kiểm tra xem phòng học đã được sử dụng cho lớp khác chưa
                        if (!lopHocDAO.KiemTraPhongHocTrung(phongHoc, namHoc))
                        {
                            // Thêm lớp mới
                            lopHocDAO.ThemLopHoc(maLop, tenLop, soLuongHS, giaoVienCN, phongHoc, namHoc);
                            MessageBox.Show("Thêm lớp học thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Phòng học đã được sử dụng cho lớp khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giáo viên chủ nhiệm đã được phân công cho lớp khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã lớp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
