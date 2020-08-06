using MySql.Data.MySqlClient;
using Project.Models.DBConnection;
using Project.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.DAO
{
    public class ProductDAO
    {
        project_dotnetEntities db = new project_dotnetEntities();
        public List<sanpham> getAllSanPhams()
        {
            var sanphamList = db.sanphams.SqlQuery("Select * from SanPham").ToList();
            return sanphamList;
         
        }

        public IQueryable<sanpham> GetSanPhamsByCost()
        {
            var sanphamList = db.sanphams.SqlQuery()
        }
    }
}