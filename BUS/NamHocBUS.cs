using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class NamHocBUS
    {

        public List<NamHocDTO> LayDSNamHoc()
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            List<NamHocDTO> lst = namHocDAO.LayDSNamHoc();
            return lst; ;
        }
        public List<NamHocDTO> LayTatCaNamHoc()
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            List<NamHocDTO> lst = namHocDAO.LayTatCaNamHoc();
            return lst; ;
        }
        public void ThemNamHoc(string tenNamHoc, string trangThai)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            if (string.IsNullOrEmpty(tenNamHoc) || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (namHocDAO.KiemTraNamHocTrung(tenNamHoc))
            {
                MessageBox.Show($"Đã có năm học: {tenNamHoc} ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!namHocDAO.KiemTraNamHocTrung(tenNamHoc))
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn muốn thêm năm học: {tenNamHoc} - Trạng thái: {trangThai} ", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    namHocDAO.ThemNamHoc(tenNamHoc, trangThai);
                    MessageBox.Show("Đã thêm năm học mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }
        public void XoaNamHoc(string tenNamHoc)
        { 
            NamHocDAO namHocDAO = new NamHocDAO();
            DialogResult dialogResult = MessageBox.Show($"Bạn muốn Xóa năm học: {tenNamHoc} ", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool xoa = namHocDAO.XoaNamHoc(tenNamHoc);
                if (xoa)
                {
                    MessageBox.Show("Đã Xóa năm học thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không thể xóa năm học: {tenNamHoc}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }
        public void HoanThanhNamHoc(string tenNamHoc)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            DialogResult dialogResult = MessageBox.Show("Xác nhận hoàn thành năm học", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                namHocDAO.HoanThanhNamHoc(tenNamHoc);
                MessageBox.Show("Hoàn thành năm học thành công","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        public void SuaNamHoc(string tenNamHoc, string trangThai)
        {
            NamHocDAO namHocDAO = new NamHocDAO();
            DialogResult dialogResult = MessageBox.Show($"Bạn muốn chỉnh sửa thông tin năm học?\n:   THÔNG TIN\n Năm học: {tenNamHoc}\n Trạng thái: {trangThai}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                namHocDAO.SuaNamHoc(tenNamHoc, trangThai);
                MessageBox.Show("Đã chỉnh sửa thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
       
    }
}
