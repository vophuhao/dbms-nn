using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class nhapHang : Form
    {
        public nhapHang()
        {
            InitializeComponent();
        }
        product product = new product();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_danhSachChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhapHang_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_danhSachSanPham.AllowUserToAddRows = false;
            dataGridView_danhSachSanPham.RowTemplate.Height = 80;
            DataTable dt = new DataTable();
            dt = product.layTatCaSanPham();
            dt.Columns.RemoveAt(3); // xoa cot phan loai
            dt.Columns.RemoveAt(3); // xoa cot mo ta
            dataGridView_danhSachSanPham.DataSource = dt;
            picCol = (DataGridViewImageColumn)dataGridView_danhSachSanPham.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
