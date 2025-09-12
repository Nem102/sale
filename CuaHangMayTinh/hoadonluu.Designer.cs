namespace CuaHangMayTinh
{
    partial class hoadonluu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Panel();
            this.dataGridView1 = new DataGridView();
            this.bindingSource1 = new BindingSource(this.components);
            this.btnTimKiem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.label1 = new Label();
            this.lblMaHD = new Label();
            this.lblMaHang = new Label();
            this.txtMaHD = new TextBox();
            this.txtMaHang = new TextBox();

            // Panel
            this.panel1.BackColor = Color.FromArgb(227, 242, 253);
            this.panel1.Location = new Point(10, 10);
            this.panel1.Size = new Size(900, 700);

            // Label title
            this.label1.Text = "Chi Tiết Hóa Đơn";
            this.label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            this.label1.Location = new Point(350, 20);
            this.label1.AutoSize = true;

            // Label & TextBox Mã HĐ
            this.lblMaHD.Text = "Mã HĐ:";
            this.lblMaHD.Location = new Point(150, 70);
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

            this.txtMaHD.Location = new Point(250, 70);
            this.txtMaHD.Size = new Size(200, 25);

            // Label & TextBox Mã hàng
            this.lblMaHang.Text = "Mã hàng:";
            this.lblMaHang.Location = new Point(150, 110);
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

            this.txtMaHang.Location = new Point(250, 110);
            this.txtMaHang.Size = new Size(200, 25);

            // Buttons
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.BackColor = Color.LightSkyBlue;
            this.btnTimKiem.Location = new Point(150, 150);
            this.btnTimKiem.Size = new Size(100, 35);

            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.BackColor = Color.Khaki;
            this.btnSua.Location = new Point(300, 150);
            this.btnSua.Size = new Size(100, 35);

            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.BackColor = Color.LightCoral;
            this.btnXoa.Location = new Point(450, 150);
            this.btnXoa.Size = new Size(100, 35);

            // DataGridView
            this.dataGridView1.Location = new Point(50, 200);
            this.dataGridView1.Size = new Size(800, 450);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add controls to panel
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblMaHang);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.dataGridView1);

            // Add panel to UserControl
            this.Controls.Add(this.panel1);

            this.Size = new Size(950, 720);
        }
    }
}
