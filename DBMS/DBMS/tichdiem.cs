using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    internal class tichdiem
    {
        mydb mydb = new mydb();

        public DataTable layTaiKhoanTichDiem()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaTaiKhoanTichDiem()", mydb.getConnection);



            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;

        }
        public bool themTk(string name,string sdt)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("TaoTaiKhoanTichDiem", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", name);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@tongDiemTich", 0);
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
