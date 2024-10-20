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
    public partial class taohoadonmuahang : Form
    {
        public taohoadonmuahang()
        {
            InitializeComponent();
        }
        product product=new product();
        private void taohoadonmuahang_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = product.layTatCaSanPham();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            if(dataGridView2.ColumnCount <= 0 ) {
                button1.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoadonmua hoadonmua2=new hoadonmua();
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for(int i=0; i<row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                hoadonmua2.dataGridView2.Rows.Add(newRow);
            }
            hoadonmua2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tensp = textBox1.Text;
            dataGridView1.DataSource = product.LaySanPhamTheoTen(tensp);
        }
        public int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string gia= dataGridView1.Rows[row].Cells[2].Value.ToString();
            string sl=numericUpDown1.Value.ToString();
            string masp = dataGridView1.Rows[row].Cells[0].Value.ToString();
            dataGridView2.Rows.Add(masp,name, gia, sl);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
        }
        int row2;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView2.CurrentRow.Index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(row2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string phanloai = comboBox1.Text;
            dataGridView1.DataSource = product.LaySanPhamTheoPhanLoai(phanloai);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phanloai = comboBox1.Text;
            dataGridView1.DataSource = product.LaySanPhamTheoPhanLoai(phanloai);
        }
    }
}
