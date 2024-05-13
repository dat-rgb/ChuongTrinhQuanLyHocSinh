using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChucVuDAO
    {
        public List<ChucVuDTO> LayDSChucVu()
        {
            List<ChucVuDTO>lst = new List<ChucVuDTO>();
            string sCauTruyVan = "SELECT maChucVu, tenChucVu FROM ChucVu";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                ChucVuDTO chucVuDTO = new ChucVuDTO();
                if(!dr.IsDBNull(0))
                    chucVuDTO.maChucVu = dr.GetString(0);
                if(!dr.IsDBNull(1))
                    chucVuDTO.tenChucVu = dr.GetString(1);
                lst.Add(chucVuDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
    }
}
