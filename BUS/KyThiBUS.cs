using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class KyThiBUS
    {
        public List<KyThiDTO> LayDSKyThi()
        {
          
            KyThiDAO kyThiDAO = new KyThiDAO();
            List<KyThiDTO> lst = kyThiDAO.LayDSKyThi();
            return lst;
          
        }
        public List<KyThiDTO> LayDSTatCaKyThi()
        {
            KyThiDAO kyThiDAO = new KyThiDAO();
            List<KyThiDTO> lst = kyThiDAO.LayDSTatCaKyThi();
            return lst;
        }
        public void ThemKyThi(string makyThi, string tenKyThi, string namHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                KyThiDAO kyThiDAO = new KyThiDAO();
                if (string.IsNullOrEmpty(makyThi) || string.IsNullOrEmpty(tenKyThi))
                {
                    MessageBox.Show("Vui lòng nhập đây đủ thông tin","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (kyThiDAO.KiemTraKyThiTrung(makyThi))
                {
                    MessageBox.Show($"Đã có kỳ thi!\n\n Mã: {makyThi}\n\n Kỳ thi: {tenKyThi}\n\n Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(!kyThiDAO.KiemTraKyThiTrung(makyThi))
                {
                    DialogResult dialogResult = MessageBox.Show($"Bạn muốn thêm kỳ thi mới:\n\n    Thông tin\n Mã kỳ thi: {makyThi}\n Tên kỳ thi: {tenKyThi}\n Ngày bắt đầu: {ngayBatDau}\n Ngày kết thúc: {ngayKetThuc}","Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        kyThiDAO.ThemKyThi(makyThi, tenKyThi, namHoc, ngayBatDau, ngayKetThuc);
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi.." + ex.Message);
            }
        }
        public void XoaKyThi(string maKyThi)
        {
            try
            {
                if(string.IsNullOrEmpty(maKyThi))
                {
                    MessageBox.Show("Vui lòng nhập mã kỳ thi để xóa", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    KyThiDAO kyThiDAO = new KyThiDAO();
                    DialogResult dialogResult = MessageBox.Show($"Bạn muốn xóa kỳ thi có Mã: {maKyThi}", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool xoa = kyThiDAO.XoaKyThi(maKyThi);
                        if (xoa)
                        {
                            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void HoanThanhKyThi(string maKyThi)
        {
            KyThiDAO kyThiDAO = new KyThiDAO();
            DialogResult dialogResult = MessageBox.Show($"Xác nhận hoàn thành kỳ thi có mã: {maKyThi} ", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                kyThiDAO.HoanThanhKyThi(maKyThi);
                MessageBox.Show("Hoàn thành kỳ thi thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        public void SuaKyThi(string maKyThi, string tenKyThi, string namHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            KyThiDAO kyThiDAO= new KyThiDAO();
            string xacNhan = $"Bạn muốn cập nhật thông tin kỳ thi?\n";
            xacNhan += $"\n   THÔNG TIN\n";
            xacNhan += $"\n Kỳ thi: {tenKyThi}\n\n Năm học: {namHoc}\n\n Ngày Bắt đầu: {ngayBatDau}\n\n Ngày Kết thúc: {ngayKetThuc}";
            DialogResult dialogResult = MessageBox.Show(xacNhan,"Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                kyThiDAO.SuaKyThi(maKyThi, tenKyThi, namHoc, ngayBatDau,ngayKetThuc);
                MessageBox.Show("Cập nhật kỳ thi thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
