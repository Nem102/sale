using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CuaHangMayTinh
{
    public partial class hoadon : UserControl
    {
        public hoadon()
        {
            InitializeComponent();

            this.Load += hoadon1_Load;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;

            btnLamMoi.Click += btnLamMoi_Click;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // 📌 Load dữ liệu
        private void hoadon1_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"
                        SELECT hd.ma_hd AS MãHD , hd.ngaylap AS NgàyLập , 
                               nv.ho + ' ' + nv.ten AS NhânViên,
                               kh.ho + ' ' + kh.ten AS KháchHàng,
                               hd.tongtien AS TổngTiền, hd.ghichu AS GhiChú
                        FROM HoaDonBan hd
                        JOIN NhanVien nv ON hd.id_nv = nv.id_nv
                        JOIN KhachHang kh ON hd.id_kh = kh.id_kh";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewHoaDon.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        // 📌 Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtMaHD.Clear();
            txtNhanVien.Clear();
            txtKhachHang.Clear();
            txtTongTien.Clear();
            txtGhiChu.Clear();
            dtpNgayLap.Value = DateTime.Now;
        }

        // 📌 Đổ dữ liệu khi click dòng
        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MãHD"].Value?.ToString();
                txtNhanVien.Text = row.Cells["NhânViên"].Value?.ToString();
                txtKhachHang.Text = row.Cells["KháchHàng"].Value?.ToString();
                txtTongTien.Text = row.Cells["TổngTiền"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChú"].Value?.ToString();

                if (row.Cells["NgàyLập"].Value != null && row.Cells["NgàyLập"].Value != DBNull.Value)
                {
                    dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgàyLập"].Value);
                }

                else
                {
                    dtpNgayLap.Value = DateTime.Now;
                }
            }
        }


        // 📌 Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            DateTime ngayLap = dtpNgayLap.Value;
            decimal tongTien;

            if (!decimal.TryParse(txtTongTien.Text, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO HoaDonBan (ma_hd, ngaylap, id_nv, id_kh, tongtien, ghichu)
                        VALUES (@MaHD, @NgayLap, @IdNV, @IdKH, @TongTien, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@IdNV", 1); // ⚠️ cần thay bằng combobox chọn NV
                    cmd.Parameters.AddWithValue("@IdKH", 1); // ⚠️ cần thay bằng combobox chọn KH
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        LoadHoaDon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hóa đơn: " + ex.Message);
            }
        }

        // 📌 Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.");
                return;
            }

            string maHD = txtMaHD.Text;
            DateTime ngayLap = dtpNgayLap.Value;
            decimal tongTien;

            if (!decimal.TryParse(txtTongTien.Text, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE HoaDonBan
                        SET ngaylap = @NgayLap, tongtien = @TongTien, ghichu = @GhiChu
                        WHERE ma_hd = @MaHD";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadHoaDon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa hóa đơn: " + ex.Message);
            }
        }

        // 📌 Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
                return;
            }

            string maHD = txtMaHD.Text;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn {maHD}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM HoaDonBan WHERE ma_hd = @MaHD";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaHD", maHD);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadHoaDon();
                            ClearTextBoxes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa hóa đơn: " + ex.Message);
                }
            }
        }

        private void flInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
