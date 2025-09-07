using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class cuahang1 : UserControl
    {
        SqlConnection kn = new SqlConnection(
            @"Data Source=DESKTOP-9BSLFIO;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
        );

        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public cuahang1()
        {
            InitializeComponent();

            // Click ra ngoài usercontrol -> clear
            this.Click += linhkienkhac_Click;

            // Click vào panel -> clear
            panel1.Click += linhkienkhac_Click;
        }

        private void cuahang1_Load(object sender, EventArgs e)
        {
            LoadData();

            // Gắn sự kiện chọn dòng
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadData()
        {
            try
            {
                kn.Open();
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú] FROM HangBan WHERE ma_hang LIKE 'MH%'";
                adapter = new SqlDataAdapter(sql, kn);
                ds = new DataSet();
                adapter.Fill(ds, "HangBan");

                bindingSource1.DataSource = ds.Tables["HangBan"];
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
            finally
            {
                kn.Close();
            }
        }

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã hàng không được để trống!");
                return;
            }

            try
            {
                // Kiểm tra mã hàng có tồn tại chưa
                kn.Open();
                string checkSql = "SELECT COUNT(*) FROM HangBan WHERE ma_hang = @ma";
                SqlCommand checkCmd = new SqlCommand(checkSql, kn);
                checkCmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã hàng đã tồn tại. Vui lòng nhập mã khác.");
                    return; // Dừng hàm
                }

                // Nếu chưa tồn tại → thêm mới
                string sql = "INSERT INTO HangBan(ma_hang, tenhang, soluong, giaban, ghichu) VALUES(@ma, @ten, @sl, @gia, @gc)";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);

                cmd.ExecuteNonQuery();

                LoadData();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                if (kn.State == ConnectionState.Open) kn.Close();
            }
        }


        // Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE HangBan SET tenhang=@ten, soluong=@sl, giaban=@gia, ghichu=@gc WHERE ma_hang=@ma";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);

                kn.Open();
                cmd.ExecuteNonQuery();
                kn.Close();

                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                if (kn.State == ConnectionState.Open) kn.Close();
            }
        }

        // Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM HangBan WHERE ma_hang=@ma";
                    SqlCommand cmd = new SqlCommand(sql, kn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);

                    kn.Open();
                    cmd.ExecuteNonQuery();
                    kn.Close();

                    LoadData();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
            finally
            {
                if (kn.State == ConnectionState.Open) kn.Close();
            }
        }

        // Khi click vào 1 ô trong DataGridView → hiện dữ liệu lên TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu click ngoài vùng dữ liệu thì xóa TextBox
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                ClearTextBoxes();
                return;
            }

            // Nếu click vào dòng dữ liệu hợp lệ
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtMaHang.Text = row.Cells["Mã hàng"].Value?.ToString();
            txtTenHang.Text = row.Cells["Tên hàng"].Value?.ToString();
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString();
            txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();
        }

        // Khi click ra khoảng trống ngoài DataGridView → xóa dữ liệu trong TextBox
        private void linhkienkhac_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        // Hàm dùng chung để clear dữ liệu TextBox
        private void ClearTextBoxes()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
        }

        // Khi thay đổi lựa chọn trong DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
                dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.Index < 0 ||
                dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count - 1)
            {
                ClearTextBoxes();
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            txtMaHang.Text = row.Cells["Mã hàng"].Value?.ToString();
            txtTenHang.Text = row.Cells["Tên hàng"].Value?.ToString();
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString();
            txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();
        }



        

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            try
            {
                kn.Open();
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú] " +
                             "FROM HangBan WHERE ma_hang LIKE @kw OR tenhang LIKE @kw";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                searchAdapter.Fill(dt);

                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                if (kn.State == ConnectionState.Open) kn.Close();
            }
        }
    }
}
