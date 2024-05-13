using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiPhieuDAO
    {
        public List<LoaiPhieuDTO> LayDSLoaiPhieu()
        {
            List<LoaiPhieuDTO> lst = new List<LoaiPhieuDTO>();

            string sCautruyVan = "SELECT maLoaiPhieu, tenPhieu FROM LoaiPhieu";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCautruyVan, conn);

            while (dr.Read())
            {
                LoaiPhieuDTO loaiPhieuDTO = new LoaiPhieuDTO();
                if (!dr.IsDBNull(0))
                    loaiPhieuDTO.maLoaiPhieu = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    loaiPhieuDTO.tenPhieu = dr.GetString(1);

                lst.Add(loaiPhieuDTO);

            }
            dr.Close();
            conn.Close();

            return lst;
        }
    }
}
