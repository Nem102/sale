namespace CuaHangMayTinh
{
    partial class khachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txttimkiem = new TextBox();
            txtdiachi = new TextBox();
            txtghichu = new TextBox();
            txtsdt = new TextBox();
            dataGridView1 = new DataGridView();
            bttimkiem = new Button();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            txtten = new TextBox();
            txtho = new TextBox();
            txtmakh = new TextBox();
            lblTitle = new Label();
            lblMaHang = new Label();
            lblTenHang = new Label();
            lblSoLuong = new Label();
            lblGiaBan = new Label();
            lblGhiChu = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(lblTenHang);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(lblGiaBan);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(txttimkiem);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(txtghichu);
            panel1.Controls.Add(txtsdt);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(bttimkiem);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(txtten);
            panel1.Controls.Add(txtho);
            panel1.Controls.Add(txtmakh);
            panel1.Location = new Point(183, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 693);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(632, 270);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(213, 23);
            txttimkiem.TabIndex = 35;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(669, 130);
            txtdiachi.Margin = new Padding(3, 2, 3, 2);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(142, 23);
            txtdiachi.TabIndex = 34;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(669, 179);
            txtghichu.Margin = new Padding(3, 2, 3, 2);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(142, 23);
            txtghichu.TabIndex = 33;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(669, 82);
            txtsdt.Margin = new Padding(3, 2, 3, 2);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(142, 23);
            txtsdt.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 310);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(911, 385);
            dataGridView1.TabIndex = 30;
            // 
            // bttimkiem
            // 
            bttimkiem.BackColor = Color.SkyBlue;
            bttimkiem.Location = new Point(851, 260);
            bttimkiem.Margin = new Padding(3, 2, 3, 2);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(100, 40);
            bttimkiem.TabIndex = 29;
            bttimkiem.Text = "🔍 Tìm kiếm";
            bttimkiem.UseVisualStyleBackColor = false;
            bttimkiem.Click += bttimkiem_Click;
            // 
            // btxoa
            // 
            btxoa.BackColor = Color.SkyBlue;
            btxoa.Location = new Point(434, 260);
            btxoa.Margin = new Padding(3, 2, 3, 2);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(100, 40);
            btxoa.TabIndex = 28;
            btxoa.Text = "🗑️ Xóa";
            btxoa.UseVisualStyleBackColor = false;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.BackColor = Color.SkyBlue;
            btsua.Location = new Point(270, 260);
            btsua.Margin = new Padding(3, 2, 3, 2);
            btsua.Name = "btsua";
            btsua.Size = new Size(100, 40);
            btsua.TabIndex = 27;
            btsua.Text = "✏️ Sửa";
            btsua.UseVisualStyleBackColor = false;
            btsua.Click += btsua_Click;
            // 
            // btthem
            // 
            btthem.BackColor = Color.SkyBlue;
            btthem.Location = new Point(111, 260);
            btthem.Margin = new Padding(3, 2, 3, 2);
            btthem.Name = "btthem";
            btthem.Size = new Size(100, 40);
            btthem.TabIndex = 26;
            btthem.Text = "➕ Thêm";
            btthem.UseVisualStyleBackColor = false;
            btthem.Click += btthem_Click;
            // 
            // txtten
            // 
            txtten.Location = new Point(249, 178);
            txtten.Margin = new Padding(3, 2, 3, 2);
            txtten.Name = "txtten";
            txtten.Size = new Size(158, 23);
            txtten.TabIndex = 25;
            // 
            // txtho
            // 
            txtho.Location = new Point(249, 130);
            txtho.Margin = new Padding(3, 2, 3, 2);
            txtho.Name = "txtho";
            txtho.Size = new Size(158, 23);
            txtho.TabIndex = 24;
            // 
            // txtmakh
            // 
            txtmakh.Location = new Point(249, 82);
            txtmakh.Margin = new Padding(3, 2, 3, 2);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(158, 23);
            txtmakh.TabIndex = 23;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 50);
            lblTitle.TabIndex = 49;
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaHang
            // 
            lblMaHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMaHang.Location = new Point(112, 82);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(118, 23);
            lblMaHang.TabIndex = 50;
            lblMaHang.Text = "Mã khách hàng:";
            // 
            // lblTenHang
            // 
            lblTenHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTenHang.Location = new Point(112, 178);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(81, 23);
            lblTenHang.TabIndex = 51;
            lblTenHang.Text = "Tên :";
            // 
            // lblSoLuong
            // 
            lblSoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSoLuong.Location = new Point(582, 130);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(81, 23);
            lblSoLuong.TabIndex = 52;
            lblSoLuong.Text = "Địa chỉ:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiaBan.Location = new Point(582, 80);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(81, 23);
            lblGiaBan.TabIndex = 53;
            lblGiaBan.Text = "Số điện thoại:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGhiChu.Location = new Point(582, 178);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(81, 23);
            lblGhiChu.TabIndex = 54;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(112, 130);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 55;
            label1.Text = "Họ:";
            // 
            // khachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "khachhang";
            Size = new Size(1350, 693);
            Load += khachhang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txttimkiem;
        private TextBox txtdiachi;
        private TextBox txtghichu;
        private TextBox txtsdt;
        private DataGridView dataGridView1;
        private Button bttimkiem;
        private Button btxoa;
        private Button btsua;
        private Button btthem;
        private TextBox txtten;
        private TextBox txtho;
        private TextBox txtmakh;
        private Label lblTitle;
        private Label label1;
        private Label lblMaHang;
        private Label lblTenHang;
        private Label lblSoLuong;
        private Label lblGiaBan;
        private Label lblGhiChu;
    }
}
