using System.Drawing;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    partial class cuahang1
    {

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            lblMaHang = new Label();
            lblTenHang = new Label();
            lblSoLuong = new Label();
            lblGiaBan = new Label();
            lblGhiChu = new Label();
            txtMaHang = new TextBox();
            txtTenHang = new TextBox();
            txtSoLuong = new TextBox();
            txtGiaBan = new TextBox();
            txtGhiChu = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            lblTitle = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            linkChonAnh = new LinkLabel();
            txtHinhAnh = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.Location = new Point(30, 306);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(935, 462);
            dataGridView1.TabIndex = 14;
            // 
            // lblMaHang
            // 
            lblMaHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMaHang.Location = new Point(28, 89);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(78, 23);
            lblMaHang.TabIndex = 15;
            lblMaHang.Text = "Mã hàng:";
            // 
            // lblTenHang
            // 
            lblTenHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTenHang.Location = new Point(28, 129);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(78, 23);
            lblTenHang.TabIndex = 16;
            lblTenHang.Text = "Tên hàng:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSoLuong.Location = new Point(28, 172);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(78, 23);
            lblSoLuong.TabIndex = 17;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGiaBan.Location = new Point(28, 209);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(78, 23);
            lblGiaBan.TabIndex = 18;
            lblGiaBan.Text = "Giá bán:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblGhiChu.Location = new Point(28, 249);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(78, 23);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(112, 88);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(200, 23);
            txtMaHang.TabIndex = 20;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(112, 128);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(200, 23);
            txtTenHang.TabIndex = 21;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(112, 168);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 23);
            txtSoLuong.TabIndex = 22;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(112, 208);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 23);
            txtGiaBan.TabIndex = 23;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(112, 248);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 23);
            txtGhiChu.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(865, 91);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 25;
            button1.Text = "➕ Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(865, 141);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 26;
            button2.Text = "✏️ Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Location = new Point(865, 191);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 27;
            button3.Text = "🗑️ Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblTenHang);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblGiaBan);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(lblGhiChu);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtMaHang);
            panel1.Controls.Add(txtTenHang);
            panel1.Location = new Point(172, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 765);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(996, 50);
            lblTitle.TabIndex = 47;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(407, 86);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 46;
            label2.Text = "HÌNH ẢNH SẢN PHẨM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkChonAnh);
            panel2.Controls.Add(txtHinhAnh);
            panel2.Location = new Point(404, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 164);
            panel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 143);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // linkChonAnh
            // 
            linkChonAnh.AutoSize = true;
            linkChonAnh.Location = new Point(22, 149);
            linkChonAnh.Name = "linkChonAnh";
            linkChonAnh.Size = new Size(86, 15);
            linkChonAnh.TabIndex = 42;
            linkChonAnh.TabStop = true;
            linkChonAnh.Text = "TẢI HÌNH ẢNH";
            linkChonAnh.LinkClicked += linkChonAnh_LinkClicked;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(98, 153);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(10, 10);
            txtHinhAnh.TabIndex = 43;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(641, 258);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(218, 23);
            txtTimKiem.TabIndex = 31;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Location = new Point(865, 244);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 30;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // cuahang1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel1);
            Name = "cuahang1";
            Size = new Size(1350, 693);
            Load += cuahang1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }
        private System.ComponentModel.IContainer components;
        private DataGridView dataGridView1;
        private Label lblMaHang;
        private Label lblTenHang;
        private Label lblSoLuong;
        private Label lblGiaBan;
        private Label lblGhiChu;
        private TextBox txtMaHang;
        private TextBox txtTenHang;
        private TextBox txtSoLuong;
        private TextBox txtGiaBan;
        private TextBox txtGhiChu;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private BindingSource bindingSource1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private LinkLabel linkChonAnh;
        private Label txtHinhAnh;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label lblTitle;
    }
}
