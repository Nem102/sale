namespace CuaHangMayTinh
{
    partial class nhanvien
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
            this.Load += new System.EventHandler(this.nhanvien_Load);

            panel1 = new Panel();
            txtdiachi = new TextBox();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btTimKiem = new Button();
            label1 = new Label();
            lblMaHang = new Label();
            dataGridView1 = new DataGridView();
            btxoa = new Button();
            btsua = new Button();
            lblTenHang = new Label();
            btthem = new Button();
            lblSoLuong = new Label();
            txtghichu = new TextBox();
            lblGiaBan = new Label();
            txtsdt = new TextBox();
            lblGhiChu = new Label();
            txtten = new TextBox();
            txtmanv = new TextBox();
            txtho = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btTimKiem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(lblTenHang);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(txtghichu);
            panel1.Controls.Add(lblGiaBan);
            panel1.Controls.Add(txtsdt);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(txtten);
            panel1.Controls.Add(txtmanv);
            panel1.Controls.Add(txtho);
            panel1.Location = new Point(164, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 660);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(173, 206);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(200, 23);
            txtdiachi.TabIndex = 33;
            // 
            // label2
            // 
            label2.Location = new Point(67, 206);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 32;
            label2.Text = "Địa chỉ:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(482, 232);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 31;
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.FromArgb(192, 255, 192);
            btTimKiem.Location = new Point(688, 218);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(100, 40);
            btTimKiem.TabIndex = 30;
            btTimKiem.Text = "🔍 Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = false;
            btTimKiem.Click += btnTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 27);
            label1.TabIndex = 29;
            label1.Text = "BẢNG NHÂN VIÊN";
            // 
            // lblMaHang
            // 
            lblMaHang.Location = new Point(67, 88);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(100, 23);
            lblMaHang.TabIndex = 15;
            lblMaHang.Text = "Mã nhân viên:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(68, 285);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 300);
            dataGridView1.TabIndex = 14;
            // 
            // btxoa
            // 
            btxoa.BackColor = Color.FromArgb(192, 255, 192);
            btxoa.Location = new Point(688, 172);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(100, 40);
            btxoa.TabIndex = 27;
            btxoa.Text = "🗑️ Xóa";
            btxoa.UseVisualStyleBackColor = false;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.BackColor = Color.FromArgb(192, 255, 192);
            btsua.Location = new Point(688, 122);
            btsua.Name = "btsua";
            btsua.Size = new Size(100, 40);
            btsua.TabIndex = 26;
            btsua.Text = "✏️ Sửa";
            btsua.UseVisualStyleBackColor = false;
            btsua.Click += btsua_Click;
            // 
            // lblTenHang
            // 
            lblTenHang.Location = new Point(67, 117);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(100, 23);
            lblTenHang.TabIndex = 16;
            lblTenHang.Text = "Họ:";
            // 
            // btthem
            // 
            btthem.BackColor = Color.FromArgb(192, 255, 192);
            btthem.Location = new Point(688, 72);
            btthem.Name = "btthem";
            btthem.Size = new Size(100, 40);
            btthem.TabIndex = 25;
            btthem.Text = "➕ Thêm";
            btthem.UseVisualStyleBackColor = false;
            btthem.Click += btthem_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(67, 151);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 23);
            lblSoLuong.TabIndex = 17;
            lblSoLuong.Text = "Tên:";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(173, 235);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(200, 23);
            txtghichu.TabIndex = 24;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Location = new Point(67, 177);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(100, 23);
            lblGiaBan.TabIndex = 18;
            lblGiaBan.Text = "SĐT:";
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(173, 177);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(200, 23);
            txtsdt.TabIndex = 23;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(67, 238);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtten
            // 
            txtten.AccessibleName = "";
            txtten.Location = new Point(173, 148);
            txtten.Name = "txtten";
            txtten.Size = new Size(200, 23);
            txtten.TabIndex = 22;
            // 
            // txtmanv
            // 
            txtmanv.AccessibleName = "txtmanv";
            txtmanv.Location = new Point(173, 88);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(200, 23);
            txtmanv.TabIndex = 20;
            txtmanv.TextChanged += txtmanv_TextChanged;
            // 
            // txtho
            // 
            txtho.AccessibleName = "";
            txtho.Location = new Point(173, 117);
            txtho.Name = "txtho";
            txtho.Size = new Size(200, 23);
            txtho.TabIndex = 21;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panel1);
            Name = "nhanvien";
            Size = new Size(1218, 663);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btTimKiem;
        private Label label1;
        private Label lblMaHang;
        private DataGridView dataGridView1;
        private Button btxoa;
        private Button btsua;
        private Label lblTenHang;
        private Button btthem;
        private Label lblSoLuong;
        private TextBox txtghichu;
        private Label lblGiaBan;
        private TextBox txtsdt;
        private Label lblGhiChu;
        private TextBox txtten;
        private TextBox txtmanv;
        private TextBox txtho;
        private TextBox txtdiachi;
        private Label label2;
    }
}
