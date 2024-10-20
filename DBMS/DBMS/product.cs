using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    internal class product
    {

        mydb mydb=new mydb();

        public DataTable layTatCaSanPham()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaSanPham()", mydb.getConnection);
           
          

            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public DataTable LaySanPhamTheoPhanLoai(string phanloai)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("select * from dbo.LaySanPhamTheoPhamLoai(@phanLoai)", mydb.getConnection);
            sqlCommand.Parameters.AddWithValue("@phanLoai", phanloai);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public DataTable LaySanPhamTheoTen(string tensp)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("select * from dbo.LaySanPhamTheoTen(@tenSP)", mydb.getConnection);
            sqlCommand.Parameters.AddWithValue("@tenSP", tensp);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
    }
}
