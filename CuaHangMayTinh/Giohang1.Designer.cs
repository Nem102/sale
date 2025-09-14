namespace CuaHangMayTinh
{
    partial class Giohang1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView DataGridViewdgvSanPham;
        private System.Windows.Forms.DataGridView DataGridViewdgvGioHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblTongTien;

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
            DataGridViewdgvSanPham = new DataGridView();
            DataGridViewdgvGioHang = new DataGridView();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnXoaSP = new Button();
            btnThanhToan = new Button();
            btnXuatExcel = new Button();
            lblTongTien = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewdgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewdgvGioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewdgvSanPham
            // 
            DataGridViewdgvSanPham.Location = new Point(20, 60);
            DataGridViewdgvSanPham.Name = "DataGridViewdgvSanPham";
            DataGridViewdgvSanPham.Size = new Size(655, 254);
            DataGridViewdgvSanPham.TabIndex = 0;
            DataGridViewdgvSanPham.CellContentClick += DataGridViewdgvSanPham_CellContentClick;
            DataGridViewdgvSanPham.CellDoubleClick += DataGridViewdgvSanPham_CellDoubleClick;
            // 
            // DataGridViewdgvGioHang
            // 
            DataGridViewdgvGioHang.Location = new Point(20, 340);
            DataGridViewdgvGioHang.Name = "DataGridViewdgvGioHang";
            DataGridViewdgvGioHang.Size = new Size(655, 240);
            DataGridViewdgvGioHang.TabIndex = 1;
            DataGridViewdgvGioHang.CellContentClick += DataGridViewdgvGioHang_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(706, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(394, 23);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(420, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(706, 279);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(100, 30);
            btnXoaSP.TabIndex = 5;
            btnXoaSP.Text = "Xóa SP";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(706, 319);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(100, 30);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(706, 359);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(100, 30);
            btnXuatExcel.TabIndex = 7;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(766, 436);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(200, 23);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "0";
            lblTongTien.Click += lblTongTien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(707, 433);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 9;
            label1.Text = "TỔNG:";
            // 
            // Giohang1
            // 
            Controls.Add(label1);
            Controls.Add(DataGridViewdgvSanPham);
            Controls.Add(DataGridViewdgvGioHang);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoaSP);
            Controls.Add(btnThanhToan);
            Controls.Add(btnXuatExcel);
            Controls.Add(lblTongTien);
            Name = "Giohang1";
            Size = new Size(1016, 610);
            Load += Giohang1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewdgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewdgvGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
