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
        private Button btnLamMoi;

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
            components = new System.ComponentModel.Container();

            // ===== Label Title =====
            lblTitle = new Label();
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Size = new Size(962, 50);
            lblTitle.Text = "QUẢN LÝ HÓA ĐƠN BÁN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ===== Top Panel =====
            panelTop = new Panel();
            panelTop.Dock = DockStyle.Top;
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(962, 159);

            // ===== FlowLayoutPanel Info =====
            flInfo = new FlowLayoutPanel();
            flInfo.AutoScroll = true;
            flInfo.Dock = DockStyle.Fill;

            dtpNgayLap = new DateTimePicker();
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Size = new Size(200, 27);

            txtNhanVien = new TextBox();
            txtNhanVien.PlaceholderText = "Nhân viên";
            txtNhanVien.Size = new Size(100, 27);

            txtMaHD = new TextBox();
            txtMaHD.PlaceholderText = "Mã Hóa đơn";
            txtMaHD.Size = new Size(100, 27);

            txtTongTien = new TextBox();
            txtTongTien.PlaceholderText = "Tổng tiền";
            txtTongTien.Size = new Size(100, 27);

            txtKhachHang = new TextBox();
            txtKhachHang.PlaceholderText = "Khách hàng";
            txtKhachHang.Size = new Size(100, 27);

            txtGhiChu = new TextBox();
            txtGhiChu.PlaceholderText = "Ghi chú";
            txtGhiChu.Size = new Size(100, 27);

            flInfo.Controls.Add(dtpNgayLap);
            flInfo.Controls.Add(txtNhanVien);
            flInfo.Controls.Add(txtMaHD);
            flInfo.Controls.Add(txtTongTien);
            flInfo.Controls.Add(txtKhachHang);
            flInfo.Controls.Add(txtGhiChu);

            panelTop.Controls.Add(flInfo);

            // ===== Buttons Panel =====
            panelButtons = new Panel();
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(962, 100);

            flBtn = new FlowLayoutPanel();
            flBtn.Dock = DockStyle.Top;

            btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.BackColor = Color.LightGreen;
            btnThem.Size = new Size(75, 59);
            btnThem.Click += btnThem_Click;

            btnLamMoi = new Button();
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Size = new Size(75, 59);
            btnLamMoi.Click += btnLamMoi_Click;

            flBtn.Controls.Add(btnThem);
            flBtn.Controls.Add(btnLamMoi);

            panelButtons.Controls.Add(flBtn);

            // ===== Grid Panel =====
            panelGrid = new Panel();
            panelGrid.Dock = DockStyle.Fill;

            dataGridViewHoaDon = new DataGridView();
            dataGridViewHoaDon.Dock = DockStyle.Fill;
            dataGridViewHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHoaDon.BackgroundColor = Color.WhiteSmoke;
            dataGridViewHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;

            panelGrid.Controls.Add(dataGridViewHoaDon);

            // ===== Add all to UserControl =====
            Controls.Add(panelGrid);
            Controls.Add(panelButtons);
            Controls.Add(panelTop);
            Controls.Add(lblTitle);

            Name = "hoadon1";
            Size = new Size(962, 600);
        }
    }
}
