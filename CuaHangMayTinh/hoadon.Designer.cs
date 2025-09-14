using System.Drawing;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    partial class hoadon
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Panel panelTop;
        private FlowLayoutPanel flInfo;
        private DateTimePicker dtpNgayLap;
        private TextBox txtNhanVien;
        private TextBox txtMaHD;
        private TextBox txtTongTien;
        private TextBox txtKhachHang;
        private TextBox txtGhiChu;

        private Panel panelButtons;
        private FlowLayoutPanel flBtn;
        private Button btnThem;
        private Button btnSua;

        private Panel panelGrid;
        private DataGridView dataGridViewHoaDon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            panelTop = new Panel();
            flInfo = new FlowLayoutPanel();
            dtpNgayLap = new DateTimePicker();
            txtNhanVien = new TextBox();
            txtMaHD = new TextBox();
            txtTongTien = new TextBox();
            txtKhachHang = new TextBox();
            txtGhiChu = new TextBox();
            panelButtons = new Panel();
            flBtn = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelGrid = new Panel();
            dataGridViewHoaDon = new DataGridView();
            panelTop.SuspendLayout();
            flInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            flBtn.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1366, 50);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "QUẢN LÝ HÓA ĐƠN BÁN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(flInfo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 50);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1366, 159);
            panelTop.TabIndex = 2;
            // 
            // flInfo
            // 
            flInfo.AutoScroll = true;
            flInfo.Controls.Add(dtpNgayLap);
            flInfo.Controls.Add(txtNhanVien);
            flInfo.Controls.Add(txtMaHD);
            flInfo.Controls.Add(txtTongTien);
            flInfo.Controls.Add(txtKhachHang);
            flInfo.Controls.Add(txtGhiChu);
            flInfo.Dock = DockStyle.Fill;
            flInfo.Location = new Point(10, 10);
            flInfo.Name = "flInfo";
            flInfo.Size = new Size(1346, 139);
            flInfo.TabIndex = 0;
            flInfo.Paint += flInfo_Paint;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(3, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 23);
            dtpNgayLap.TabIndex = 0;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(209, 3);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.PlaceholderText = "Nhân viên";
            txtNhanVien.Size = new Size(100, 23);
            txtNhanVien.TabIndex = 1;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(315, 3);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.PlaceholderText = "Mã Hóa đơn";
            txtMaHD.Size = new Size(100, 23);
            txtMaHD.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(421, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.PlaceholderText = "Tổng tiền";
            txtTongTien.Size = new Size(100, 23);
            txtTongTien.TabIndex = 3;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(527, 3);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.PlaceholderText = "Khách hàng";
            txtKhachHang.Size = new Size(100, 23);
            txtKhachHang.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(633, 3);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú";
            txtGhiChu.Size = new Size(100, 23);
            txtGhiChu.TabIndex = 5;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(flBtn);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 209);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(1366, 100);
            panelButtons.TabIndex = 1;
            // 
            // flBtn
            // 
            flBtn.Controls.Add(btnThem);
            flBtn.Controls.Add(btnSua);
            flBtn.Controls.Add(btnXoa);
            flBtn.Controls.Add(btnLamMoi);
            flBtn.Dock = DockStyle.Top;
            flBtn.Location = new Point(10, 10);
            flBtn.Name = "flBtn";
            flBtn.Size = new Size(1346, 100);
            flBtn.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 59);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Location = new Point(126, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 59);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(249, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 59);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.SkyBlue;
            btnLamMoi.Location = new Point(372, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(117, 59);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "🔁Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridViewHoaDon);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 309);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1366, 459);
            panelGrid.TabIndex = 0;
            // 
            // dataGridViewHoaDon
            // 
            dataGridViewHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHoaDon.BackgroundColor = Color.WhiteSmoke;
            dataGridViewHoaDon.ColumnHeadersHeight = 29;
            dataGridViewHoaDon.Dock = DockStyle.Fill;
            dataGridViewHoaDon.Location = new Point(0, 0);
            dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            dataGridViewHoaDon.RowHeadersWidth = 51;
            dataGridViewHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHoaDon.Size = new Size(1366, 459);
            dataGridViewHoaDon.TabIndex = 0;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;
            // 
            // hoadon
            // 
            Controls.Add(panelGrid);
            Controls.Add(panelButtons);
            Controls.Add(panelTop);
            Controls.Add(lblTitle);
            Name = "hoadon";
            Size = new Size(1350, 693);
            panelTop.ResumeLayout(false);
            flInfo.ResumeLayout(false);
            flInfo.PerformLayout();
            panelButtons.ResumeLayout(false);
            flBtn.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).EndInit();
            ResumeLayout(false);
        }
        private Button btnXoa;
        private Button btnLamMoi;
    }
}
