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
            mydb.closeConnection();
            return dt;
        }
        public bool taoHoaDonNhap(int maHD, int maSP, DateTime ngayIn, int thanhTien, int soLuong, int donGia)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("TaoHoaDonNhap", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số vào thủ tục lưu trữ
            cmd.Parameters.AddWithValue("@maHD", maHD);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.Parameters.AddWithValue("@ngayIn", ngayIn);
            cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.Parameters.AddWithValue("@donGia", donGia);

            if (cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public int layMaHoaDonNhap()
        {
            mydb.openConnection();
            SqlCommand cmd1 = new SqlCommand("Select dbo.LayMaHoaDonNhap()", mydb.getConnection);
            if (cmd1.ExecuteScalar() != null)
            {
                int maHD = (int)cmd1.ExecuteScalar() + 1;
                mydb.closeConnection();
                return maHD;
            }
            else
            {
                mydb.closeConnection();
                return 1;
            }
            
        }
    }
}
