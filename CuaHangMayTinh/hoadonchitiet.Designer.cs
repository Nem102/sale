namespace CuaHangMayTinh
{
    partial class hoadonchitiet
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btn_excel;
        private Label lblMaHD;
        private Label lblMaHang;
        private TextBox txtMaHD;
        private TextBox txtMaHang;
        private BindingSource bindingSource1;

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
            lblTitle = new Label();
            lblMaHD = new Label();
            txtMaHD = new TextBox();
            lblMaHang = new Label();
            txtMaHang = new TextBox();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btn_excel = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblMaHD);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(txtMaHang);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btn_excel);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(195, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 768);
            panel1.TabIndex = 0;
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
            lblTitle.TabIndex = 9;
            lblTitle.Text = "QUẢN LÝ HÓA ĐƠN CHI TIẾT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMaHD.Location = new Point(150, 70);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(66, 19);
            lblMaHD.TabIndex = 1;
            lblMaHD.Text = "Mã HĐ:";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(250, 70);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(200, 23);
            txtMaHD.TabIndex = 2;
            // 
            // lblMaHang
            // 
            lblMaHang.AutoSize = true;
            lblMaHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMaHang.Location = new Point(150, 110);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(74, 19);
            lblMaHang.TabIndex = 3;
            lblMaHang.Text = "Mã hàng:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(250, 110);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(200, 23);
            txtMaHang.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Location = new Point(150, 150);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 35);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(271, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 35);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btn_excel
            // 
            btn_excel.BackColor = Color.SkyBlue;
            btn_excel.Location = new Point(399, 150);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(106, 35);
            btn_excel.TabIndex = 7;
            btn_excel.Text = "📑Xuất file excel";
            btn_excel.UseVisualStyleBackColor = false;
            btn_excel.Click += btn_excel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(50, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(910, 450);
            dataGridView1.TabIndex = 8;
            // 
            // hoadonchitiet
            // 
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "hoadonchitiet";
            Size = new Size(1366, 768);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }
        private Label lblTitle;
    }
}
