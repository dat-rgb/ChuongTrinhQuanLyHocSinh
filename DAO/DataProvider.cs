using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection KetNoiCSDL()
        {
            try
            {
                string sChuoiKetNoi = "Data Source=.; Initial Catalog=QuanLyHocSinh; Integrated Security=True";
                SqlConnection conn = new SqlConnection(sChuoiKetNoi);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlDataReader LayDuLieu(string sSQL, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                // Đóng kết nối trước khi ném ngoại lệ
                conn.Close();
                // Ném ngoại lệ mới với thông điệp lỗi gốc
                throw ex;
            }
        }
        public static int ThucThiTruyVan(string sSQL, SqlConnection conn)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Không cần ném ngoại lệ mới, chỉ cần ném lại ngoại lệ gốc
                throw ex;
            }
            return result;
        }

    }
}
