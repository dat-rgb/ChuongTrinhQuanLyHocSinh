using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BangCapDAO
    {
        public List<BangCapDTO> LayDSBangCap()
        {
            List<BangCapDTO> lst = new List<BangCapDTO>();
            string sCauTruyVan = "SELECT maBangCap, tenBangCap FROM BangCap";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCauTruyVan, conn);

            while (dr.Read())
            {
                BangCapDTO bangCapDTO = new BangCapDTO();
                if (!dr.IsDBNull(0))
                    bangCapDTO.maBangCap = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    bangCapDTO.tenBangCap = dr.GetString(1);
                lst.Add(bangCapDTO);
            }
            dr.Close();
            conn.Close();

            return lst;
        }
    }
}
