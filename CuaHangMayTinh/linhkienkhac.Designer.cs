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
            panel1 = new Panel();
            linkChonAnh = new LinkLabel();
            txtHinhAnh = new Label();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            label1 = new Label();
            btnTimKiem = new Button();
            lblMaHang = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            lblTenHang = new Label();
            button1 = new Button();
            lblSoLuong = new Label();
            txtGhiChu = new TextBox();
            lblGiaBan = new Label();
            txtGiaBan = new TextBox();
            lblGhiChu = new Label();
            txtSoLuong = new TextBox();
            txtMaHang = new TextBox();
            txtTenHang = new TextBox();
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblTenHang);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblGiaBan);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtMaHang);
            panel1.Controls.Add(txtTenHang);
            panel1.Location = new Point(156, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 612);
            panel1.TabIndex = 29;
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
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(47, 151);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(10, 10);
            txtHinhAnh.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 143);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(482, 253);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 11);
            label1.Name = "label1";
            label1.Size = new Size(260, 27);
            label1.TabIndex = 28;
            label1.Text = "CÁC LINH KIỆN KHÁC";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 192);
            btnTimKiem.Location = new Point(688, 239);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 35;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblMaHang
            // 
            lblMaHang.Location = new Point(68, 72);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(100, 23);
            lblMaHang.TabIndex = 15;
            lblMaHang.Text = "Mã hàng:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(688, 172);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 34;
            button3.Text = "🗑️ Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.Location = new Point(68, 285);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 300);
            dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(688, 122);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 33;
            button2.Text = "✏️ Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblTenHang
            // 
            lblTenHang.Location = new Point(68, 112);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(100, 23);
            lblTenHang.TabIndex = 16;
            lblTenHang.Text = "Tên hàng:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(688, 72);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 32;
            button1.Text = "➕ Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(68, 152);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 23);
            lblSoLuong.TabIndex = 17;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(174, 232);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 23);
            txtGhiChu.TabIndex = 24;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Location = new Point(68, 192);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(100, 23);
            lblGiaBan.TabIndex = 18;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(174, 192);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 23);
            txtGiaBan.TabIndex = 23;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(68, 232);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(174, 152);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 23);
            txtSoLuong.TabIndex = 22;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(174, 72);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(200, 23);
            txtMaHang.TabIndex = 20;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(174, 112);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(200, 23);
            txtTenHang.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkChonAnh);
            panel2.Controls.Add(txtHinhAnh);
            panel2.Location = new Point(482, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 162);
            panel2.TabIndex = 42;
            // 
            // linhkienkhac
            // 
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "linhkienkhac";
            Size = new Size(1184, 618);
            Load += linhkienkhac_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblMaHang;
        private DataGridView dataGridView1;
        private Label lblTenHang;
        private Label lblSoLuong;
        private TextBox txtGhiChu;
        private Label lblGiaBan;
        private TextBox txtGiaBan;
        private Label lblGhiChu;
        private TextBox txtSoLuong;
        private TextBox txtMaHang;
        private TextBox txtTenHang;
        private Label label1;
        private BindingSource bindingSource1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label txtHinhAnh;
        private LinkLabel linkChonAnh;
        private Panel panel2;
    }
}
