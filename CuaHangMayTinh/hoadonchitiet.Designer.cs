namespace CuaHangMayTinh
{
    partial class hoadonchitiet
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
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
            label1 = new Label();
            lblMaHD = new Label();
            txtMaHD = new TextBox();
            lblMaHang = new Label();
            txtMaHang = new TextBox();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMaHD);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(lblMaHang);
            panel1.Controls.Add(txtMaHang);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(161, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 622);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Hóa Đơn";
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
            btnTimKiem.BackColor = Color.LightSkyBlue;
            btnTimKiem.Location = new Point(150, 150);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 35);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Khaki;
            btnSua.Location = new Point(300, 150);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Location = new Point(450, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Location = new Point(50, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 8;
            // 
            // hoadonluu
            // 
            Controls.Add(panel1);
            Name = "hoadonluu";
            Size = new Size(1200, 625);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }
    }
}
