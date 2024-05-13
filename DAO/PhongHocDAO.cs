using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongHocDAO
    {
        public List<PhongHocDTO> LayDSPhongHoc()
        {
            List<PhongHocDTO> phongHocDTOs = new List<PhongHocDTO>();

            string sCautruyVan = "SELECT maPhong, tenPhong FROM PhongHoc";

            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlDataReader dr = DataProvider.LayDuLieu(sCautruyVan, conn);

            while (dr.Read())
            {
                PhongHocDTO phongHocDTO = new PhongHocDTO();
                if(!dr.IsDBNull(0))
                    phongHocDTO.maPhong = dr.GetString(0);
                if(!dr.IsDBNull(1))
                    phongHocDTO.tenPhong = dr.GetString(1);

                phongHocDTOs.Add(phongHocDTO);
            }
            dr.Close();
            conn.Close();

            return phongHocDTOs;
        }
        public List<PhongHocDTO> LayDSPhongHocChuaCoLop(string namHoc)
        {
            List<PhongHocDTO> phongHocDTOs = new List<PhongHocDTO>();

            string sCauTruyVan = "SELECT ph.maPhong, ph.tenPhong";
            sCauTruyVan += " FROM PhongHoc ph ";
            sCauTruyVan += " LEFT JOIN LopHoc lh ON ph.maPhong = lh.phongHoc AND lh.namHoc = @namHoc";
            sCauTruyVan += " WHERE lh.maLop IS NULL";


            SqlConnection conn = DataProvider.KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sCauTruyVan, conn);
            cmd.Parameters.AddWithValue("@namHoc", namHoc);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PhongHocDTO phongHocDTO = new PhongHocDTO();
                if (!dr.IsDBNull(0))
                    phongHocDTO.maPhong = dr.GetString(0);
                if (!dr.IsDBNull(1))
                    phongHocDTO.tenPhong = dr.GetString(1);

                phongHocDTOs.Add(phongHocDTO);
            }

            dr.Close();
            conn.Close();

            return phongHocDTOs;
        }

    }
}
