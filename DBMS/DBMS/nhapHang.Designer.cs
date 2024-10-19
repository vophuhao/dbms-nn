namespace DBMS
{
    partial class nhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_danhSachSanPham = new System.Windows.Forms.DataGridView();
            this.panel_timKiem = new System.Windows.Forms.Panel();
            this.panel_Chon = new System.Windows.Forms.Panel();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_danhSachChon = new System.Windows.Forms.DataGridView();
            this.btn_nhapHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.panel_timKiem.SuspendLayout();
            this.panel_Chon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_danhSachSanPham
            // 
            this.dataGridView_danhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(68, 118);
            this.dataGridView_danhSachSanPham.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.RowHeadersWidth = 62;
            this.dataGridView_danhSachSanPham.RowTemplate.Height = 28;
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(741, 621);
            this.dataGridView_danhSachSanPham.TabIndex = 0;
            this.dataGridView_danhSachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel_timKiem
            // 
            this.panel_timKiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_timKiem.Controls.Add(this.button1);
            this.panel_timKiem.Controls.Add(this.numericUpDown1);
            this.panel_timKiem.Controls.Add(this.label1);
            this.panel_timKiem.Controls.Add(this.btn_Tim);
            this.panel_timKiem.Controls.Add(this.textBox_timKiem);
            this.panel_timKiem.Controls.Add(this.dataGridView_danhSachSanPham);
            this.panel_timKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_timKiem.Location = new System.Drawing.Point(0, 0);
            this.panel_timKiem.Name = "panel_timKiem";
            this.panel_timKiem.Size = new System.Drawing.Size(884, 934);
            this.panel_timKiem.TabIndex = 1;
            // 
            // panel_Chon
            // 
            this.panel_Chon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Chon.Controls.Add(this.label3);
            this.panel_Chon.Controls.Add(this.label2);
            this.panel_Chon.Controls.Add(this.btn_nhapHang);
            this.panel_Chon.Controls.Add(this.dataGridView_danhSachChon);
            this.panel_Chon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Chon.Location = new System.Drawing.Point(890, 0);
            this.panel_Chon.Name = "panel_Chon";
            this.panel_Chon.Size = new System.Drawing.Size(894, 934);
            this.panel_Chon.TabIndex = 2;
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(236, 35);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(364, 37);
            this.textBox_timKiem.TabIndex = 1;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(642, 32);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(125, 40);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dataGridView_danhSachChon
            // 
            this.dataGridView_danhSachChon.AllowUserToAddRows = false;
            this.dataGridView_danhSachChon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_danhSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_danhSachChon.Location = new System.Drawing.Point(37, 118);
            this.dataGridView_danhSachChon.Name = "dataGridView_danhSachChon";
            this.dataGridView_danhSachChon.RowHeadersWidth = 62;
            this.dataGridView_danhSachChon.RowTemplate.Height = 28;
            this.dataGridView_danhSachChon.Size = new System.Drawing.Size(824, 576);
            this.dataGridView_danhSachChon.TabIndex = 0;
            this.dataGridView_danhSachChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhSachChon_CellContentClick);
            // 
            // btn_nhapHang
            // 
            this.btn_nhapHang.Location = new System.Drawing.Point(363, 853);
            this.btn_nhapHang.Name = "btn_nhapHang";
            this.btn_nhapHang.Size = new System.Drawing.Size(204, 40);
            this.btn_nhapHang.TabIndex = 3;
            this.btn_nhapHang.Text = "Nhập hàng ";
            this.btn_nhapHang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 771);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền : ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(296, 789);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 778);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 934);
            this.Controls.Add(this.panel_Chon);
            this.Controls.Add(this.panel_timKiem);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "nhapHang";
            this.Text = "nhapHang";
            this.Load += new System.EventHandler(this.nhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).EndInit();
            this.panel_timKiem.ResumeLayout(false);
            this.panel_timKiem.PerformLayout();
            this.panel_Chon.ResumeLayout(false);
            this.panel_Chon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_danhSachSanPham;
        private System.Windows.Forms.Panel panel_timKiem;
        private System.Windows.Forms.Panel panel_Chon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.Button btn_nhapHang;
        private System.Windows.Forms.DataGridView dataGridView_danhSachChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}