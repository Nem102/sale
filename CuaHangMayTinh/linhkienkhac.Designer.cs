namespace CuaHangMayTinh
{
    partial class linhkienkhac
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            txtSoLuong = new TextBox();
            lblGhiChu = new Label();
            txtGiaBan = new TextBox();
            lblGiaBan = new Label();
            txtGhiChu = new TextBox();
            lblSoLuong = new Label();
            btthem = new Button();
            lblTenHang = new Label();
            btsua = new Button();
            dataGridView1 = new DataGridView();
            btxoa = new Button();
            lblMaHang = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            panel2 = new Panel();
            txtHinhAnh = new Label();
            linkChonAnh = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(114, 128);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(200, 23);
            txtTenHang.TabIndex = 21;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(114, 88);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(200, 23);
            txtMaHang.TabIndex = 20;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(114, 168);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 23);
            txtSoLuong.TabIndex = 22;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGhiChu.Location = new Point(27, 248);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(81, 23);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(114, 208);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 23);
            txtGiaBan.TabIndex = 23;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiaBan.Location = new Point(27, 208);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(81, 23);
            lblGiaBan.TabIndex = 18;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(114, 248);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 23);
            txtGhiChu.TabIndex = 24;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSoLuong.Location = new Point(27, 168);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(81, 23);
            lblSoLuong.TabIndex = 17;
            lblSoLuong.Text = "Số lượng:";
            // 
            // btthem
            // 
            btthem.BackColor = Color.SkyBlue;
            btthem.Location = new Point(866, 89);
            btthem.Name = "btthem";
            btthem.Size = new Size(100, 40);
            btthem.TabIndex = 32;
            btthem.Text = "➕ Thêm";
            btthem.UseVisualStyleBackColor = false;
            btthem.Click += btthem_Click;
            // 
            // lblTenHang
            // 
            lblTenHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTenHang.Location = new Point(27, 128);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(81, 23);
            lblTenHang.TabIndex = 16;
            lblTenHang.Text = "Tên hàng:";
            // 
            // btsua
            // 
            btsua.BackColor = Color.SkyBlue;
            btsua.Location = new Point(866, 139);
            btsua.Name = "btsua";
            btsua.Size = new Size(100, 40);
            btsua.TabIndex = 33;
            btsua.Text = "✏️ Sửa";
            btsua.UseVisualStyleBackColor = false;
            btsua.Click += btsua_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.Location = new Point(29, 304);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(937, 461);
            dataGridView1.TabIndex = 14;
            // 
            // btxoa
            // 
            btxoa.BackColor = Color.SkyBlue;
            btxoa.Location = new Point(866, 189);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(100, 40);
            btxoa.TabIndex = 34;
            btxoa.Text = "🗑️ Xóa";
            btxoa.UseVisualStyleBackColor = false;
            btxoa.Click += btxoa_Click;
            // 
            // lblMaHang
            // 
            lblMaHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMaHang.Location = new Point(27, 88);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(81, 23);
            lblMaHang.TabIndex = 15;
            lblMaHang.Text = "Mã hàng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Location = new Point(866, 256);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 35;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(660, 270);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkChonAnh);
            panel2.Controls.Add(txtHinhAnh);
            panel2.Location = new Point(405, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 162);
            panel2.TabIndex = 42;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(47, 151);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(10, 10);
            txtHinhAnh.TabIndex = 40;
            // 
            // linkChonAnh
            // 
            linkChonAnh.AutoSize = true;
            linkChonAnh.Location = new Point(47, 146);
            linkChonAnh.Name = "linkChonAnh";
            linkChonAnh.Size = new Size(90, 15);
            linkChonAnh.TabIndex = 39;
            linkChonAnh.TabStop = true;
            linkChonAnh.Text = "LẤY HÌNH ẢNH";
            linkChonAnh.LinkClicked += linkChonAnh_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 143);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
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
            lblTitle.TabIndex = 48;
            lblTitle.Text = "QUẢN LÝ LINH KIỆN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 85);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 49;
            label2.Text = "HÌNH ẢNH SẢN PHẨM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(lblTenHang);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblGiaBan);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtMaHang);
            panel1.Controls.Add(txtTenHang);
            panel1.Location = new Point(174, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 768);
            panel1.TabIndex = 29;
            // 
            // linhkienkhac
            // 
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "linhkienkhac";
            Size = new Size(1350, 693);
            Load += linhkienkhac_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        private BindingSource bindingSource1;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private TextBox txtSoLuong;
        private Label lblGhiChu;
        private TextBox txtGiaBan;
        private Label lblGiaBan;
        private TextBox txtGhiChu;
        private Label lblSoLuong;
        private Button btthem;
        private Label lblTenHang;
        private Button btsua;
        private DataGridView dataGridView1;
        private Button btxoa;
        private Label lblMaHang;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panel2;
        private PictureBox pictureBox1;
        private LinkLabel linkChonAnh;
        private Label txtHinhAnh;
        private Label lblTitle;
        private Label label2;
        private Panel panel1;
    }
}
