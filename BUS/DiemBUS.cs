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
    public class DiemBUS
    {
        //Lấy Danh sách Điểm: Tất cả điểm của Học sinh(form Quản lý)
        public List<DiemDTO> LayDSDiem()
        {
            DiemDAO diemDAO = new DiemDAO();

            List<DiemDTO> lst = diemDAO.LayDSDiem();
            return lst;
        }
        //Lấy Thông tin từ DataGridView đổ lên Các TextBox(form Quản lý)
        public DiemDTO LayDuLieuTuDataGridView(string hocSinh, string monHoc, string hocKy, float diemTX, float diemKT1, float diemKT2, float diemThi, float diemTB)
        {
            DiemDAO diemDAO = new DiemDAO();
            
            // Gọi phương thức từ đối tượng DiemDAO và trả về đối tượng DiemDTO
            return diemDAO.LayDuLieuTuDataGridView(hocSinh, monHoc, hocKy, diemTX, diemKT1, diemKT2, diemThi, diemTB);
        }
        // Tìm kiếm điểm theo mã học sinh và học kỳ
        public List<DiemDTO> LayDSDiemTheoMaHSVaHocKy(string hocSinh, string hocKy)
        {
            DiemDAO diemDAO = new DiemDAO();
           
            List<DiemDTO> lst = diemDAO.LayDSDiemTheoMaHSVaHocKy(hocSinh, hocKy);
            
            return lst;
        }
        // Tìm kiếm điểm theo mã học sinh, môn học, học kỳ
        public List<DiemDTO> LayDSDiemTheoMaHSMonHocVaHocKy(string hocSinh, string monHoc, string hocKy)
        {
            DiemDAO DiemDAO = new DiemDAO();
            List<DiemDTO> lst = DiemDAO.LayDSDiemTheoMaHSMonHocVaHocKy(hocSinh , monHoc, hocKy);
           
            return lst;
        }
        //Tính điểm trung bình theo học kỳ
        public List<DiemTrungBinhDTO> TinhDiemTrungBinhHocKy1(string hocKy)
        {
            DiemDAO diemDAO = new DiemDAO();
            return diemDAO.TinhDiemTrungBinhHocKy(hocKy);
        }
        public List<DiemDTO> LayDSDiemLopHocVaHocKy(string lopHoc, string hocKy) 
        {
            DiemDAO diemDAO = new DiemDAO();
            List<DiemDTO> lst = diemDAO.LayDSDiemLopHocVaHocKy(lopHoc, hocKy);

            return lst;
            
        }
        public List<DiemDTO> LayDSDiemTheoLopMonHocVaHocKy(string lopHoc, string monHoc, string hocKy)
        {
            DiemDAO DiemDAO = new DiemDAO();
            List<DiemDTO> lst = DiemDAO.LayDSDiemTheoLopMonHocVaHocKy(lopHoc, monHoc, hocKy);

            return lst;
        }
        public void XoaDiem(string hocSinh, string monHoc)
        {
            try
            {
                DiemDAO diemDAO = new DiemDAO();
                diemDAO.XoaDiemHS(hocSinh, monHoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
