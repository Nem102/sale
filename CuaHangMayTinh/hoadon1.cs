using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CuaHangMayTinh
{
    public partial class hoadon1 : UserControl
    {
        public hoadon1()
        {
            InitializeComponent();

            // Gán event
            this.Load += hoadon1_Load;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThem.Click += btnThem_Click;
        }

        // 📌 Khi UserControl load
        private void hoadon1_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        // 📌 Hàm load dữ liệu hóa đơn
        private void LoadHoaDon()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"
                        SELECT hd.ma_hd, hd.ngaylap, 
                               nv.ho + ' ' + nv.ten AS NhanVien,
                               kh.ho + ' ' + kh.ten AS KhachHang,
                               hd.tongtien
                        FROM HoaDonBan hd
                        JOIN NhanVien nv ON hd.id_nv = nv.id_nv
                        JOIN KhachHang kh ON hd.id_kh = kh.id_kh";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewHoaDon.DataSource = dt;   // ✅ hiển thị danh sách
                } // Connection tự động đóng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        // 📌 Nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        // 📌 Khi click vào dòng trong DataGridView
        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh header
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];
                MessageBox.Show("Bạn chọn Hóa đơn: " + row.Cells["ma_hd"].Value.ToString());
            }
        }

        // 📌 Thêm hóa đơn mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các controls
            string maHD = txtMaHD.Text;
            DateTime ngayLap = dtpNgayLap.Value;
            string nhanVien = txtNhanVien.Text;
            string khachHang = txtKhachHang.Text;
            decimal tongTien = 0;
            string ghiChu = txtGhiChu.Text;

            if (!decimal.TryParse(txtTongTien.Text, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ. Vui lòng nhập một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sqlInsert = @"
                        INSERT INTO HoaDonBan (ma_hd, ngaylap, id_nv, id_kh, tongtien, ghichu)
                        VALUES (@MaHD, @NgayLap, @IdNV, @IdKH, @TongTien, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@NgayLap", ngayLap);

                    // 🚨 Lưu ý: Cần lấy id_nv và id_kh từ database dựa trên tên
                    // Tạm thời gán giá trị mặc định (bạn nên thay bằng ComboBox)
                    cmd.Parameters.AddWithValue("@IdNV", 1);
                    cmd.Parameters.AddWithValue("@IdKH", 1);

                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        LoadHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
