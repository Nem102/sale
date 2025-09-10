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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            linkChonAnh = new LinkLabel();
            txtTimKiem = new TextBox();
            txtHinhAnh = new Label();
            btnTimKiem = new Button();
            label1 = new Label();
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
            dataGridView1.Location = new Point(68, 285);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 300);
            dataGridView1.TabIndex = 14;
            // 
            // lblMaHang
            // 
            lblMaHang.Location = new Point(68, 72);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(100, 23);
            lblMaHang.TabIndex = 15;
            lblMaHang.Text = "Mã hàng:";
            // 
            // lblTenHang
            // 
            lblTenHang.Location = new Point(68, 112);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(100, 23);
            lblTenHang.TabIndex = 16;
            lblTenHang.Text = "Tên hàng:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(68, 155);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 23);
            lblSoLuong.TabIndex = 17;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.Location = new Point(68, 192);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(100, 23);
            lblGiaBan.TabIndex = 18;
            lblGiaBan.Text = "Giá bán:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(68, 232);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
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
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(174, 152);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 23);
            txtSoLuong.TabIndex = 22;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(174, 192);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 23);
            txtGiaBan.TabIndex = 23;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(174, 232);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 23);
            txtGhiChu.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(688, 72);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 25;
            button1.Text = "➕ Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(688, 122);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 26;
            button2.Text = "✏️ Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(688, 172);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 27;
            button3.Text = "🗑️ Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(txtHinhAnh);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button3);
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
            panel1.Location = new Point(157, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 618);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkChonAnh);
            panel2.Location = new Point(482, 72);
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
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(482, 253);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 31;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(649, 72);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(10, 10);
            txtHinhAnh.TabIndex = 43;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 192);
            btnTimKiem.Location = new Point(688, 239);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 30;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 21);
            label1.Name = "label1";
            label1.Size = new Size(301, 27);
            label1.TabIndex = 29;
            label1.Text = "CÁC MẶT HÀNG HIỆN TẠI";
            // 
            // cuahang1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel1);
            Name = "cuahang1";
            Size = new Size(1184, 618);
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
        private Label label1;
        private BindingSource bindingSource1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private LinkLabel linkChonAnh;
        private Label txtHinhAnh;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
