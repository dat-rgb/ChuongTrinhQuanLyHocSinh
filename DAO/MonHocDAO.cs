using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHocDAO
    {
        public List<MonHocDTO> LayDSMonHoc()
        {
            List<MonHocDTO> lst = new List<MonHocDTO>();
            string sCauTruyVan = "SELECT maMonHoc, tenMonHoc, moTa FROM MonHoc";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
               MonHocDTO monHocDTO = new MonHocDTO();
                if (!dr.IsDBNull(0))
                    monHocDTO.maMonHoc = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    monHocDTO.tenMonHoc = dr.GetString(1);
                if (!dr.IsDBNull(2))
                    monHocDTO.moTa = dr.GetString(2);
               
                lst.Add(monHocDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
       
            // Trả về đối tượng MonHocDTO (có thể là null nếu không tìm thấy dữ liệu)
           

    }
}
