using MySql.Data.MySqlClient;
using Project.Models.DBConnection;
using Project.Models.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.DAO
{
    public class ProductDAO
    {
        public List<SanPham> getAllProduct()
        {
            List<SanPham> result = new List<SanPham>();
            MySqlConnection con = DBUtils.GetDBConnection();
            con.Open();
            string query = "select * from SanPham";
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                SanPham sp = new SanPham();
                sp.TenSanPham = rd["TenSanPham"].ToString();
                sp.id = Convert.ToInt32(rd["id"]);
                sp.mauSac = rd["MauSac"].ToString();
                sp.Gia = Convert.ToDouble(rd["Gia"]);
                sp.HinhAnhSanPham = rd["HinhAnhSanPham"].ToString();
                result.Add(sp);
            }
            return result;
        }
    }
}