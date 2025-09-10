using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class cuahang1 : UserControl
    {
        SqlConnection kn = new SqlConnection(
            @"Data Source=.;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
        );

        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public cuahang1()
        {
            InitializeComponent();

            this.Click += cuahang1_Click;
            panel1.Click += cuahang1_Click;
        }

        private void cuahang1_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadData()
        {
            try
            {
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú], HinhAnh AS [Hình ảnh] " +
                             "FROM HangBan WHERE ma_hang LIKE 'MH%'";
                adapter = new SqlDataAdapter(sql, kn);
                ds = new DataSet();
                adapter.Fill(ds, "HangBan");

                bindingSource1.DataSource = ds.Tables["HangBan"];
                dataGridView1.DataSource = bindingSource1;

                if (dataGridView1.Rows.Count > 0)
                    DisplayRow(dataGridView1.Rows[0]);
                else
                    ResetTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
        }

        // ====================== Load ảnh an toàn ======================
        private Image LoadImageSafe(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (Image)Image.FromStream(fs).Clone(); // clone để tránh lock file
            }
        }

        // ====================== Hiển thị dữ liệu + ảnh ======================
        private void DisplayRow(DataGridViewRow row)
        {
            txtMaHang.Text = row.Cells["Mã hàng"].Value?.ToString();
            txtTenHang.Text = row.Cells["Tên hàng"].Value?.ToString();
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString();
            txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();

            object imgCell = row.Cells["Hình ảnh"].Value;
            txtHinhAnh.Text = (imgCell == null || imgCell == DBNull.Value) ? "" : imgCell.ToString();

            pictureBox1.Image = LoadImageSafe(txtHinhAnh.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Đổi label theo trạng thái
            linkChonAnh.Text = string.IsNullOrWhiteSpace(txtHinhAnh.Text)
                ? "Thêm hình ảnh sản phẩm"
                : "Thay đổi hình ảnh sản phẩm";
        }

        private void ResetTextBoxes()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
            txtHinhAnh.Text = "";
            pictureBox1.Image = null;
            linkChonAnh.Text = "Thêm hình ảnh sản phẩm";
        }

        // ====================== Chọn ảnh ======================
        private void linkChonAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaHang.Text))
                    {
                        MessageBox.Show("Vui lòng nhập Mã hàng trước khi chọn ảnh!");
                        return;
                    }

                    string originalPath = ofd.FileName;
                    pictureBox1.Image = LoadImageSafe(originalPath);
                    txtHinhAnh.Text = originalPath;

                    if (kn.State == ConnectionState.Closed) kn.Open();
                    string sql = "UPDATE HangBan SET HinhAnh=@anh WHERE ma_hang=@ma";
                    SqlCommand cmd = new SqlCommand(sql, kn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                    cmd.Parameters.AddWithValue("@anh", originalPath);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật ảnh thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chọn ảnh: " + ex.Message);
                }
                finally
                {
                    if (kn.State == ConnectionState.Open) kn.Close();
                }
            }
        }

        // ====================== Thêm ======================
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã hàng không được để trống!");
                return;
            }

            try
            {
                if (kn.State == ConnectionState.Closed) kn.Open();

                string checkSql = "SELECT COUNT(*) FROM HangBan WHERE ma_hang = @ma";
                SqlCommand checkCmd = new SqlCommand(checkSql, kn);
                checkCmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã hàng đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }

                string sql = "INSERT INTO HangBan(ma_hang, tenhang, soluong, giaban, ghichu, HinhAnh) " +
                             "VALUES(@ma, @ten, @sl, @gia, @gc, @anh)";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@anh", txtHinhAnh.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");

                LoadData();
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

        // ====================== Sửa ======================
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kn.State == ConnectionState.Closed) kn.Open();

                string sql = "UPDATE HangBan SET tenhang=@ten, soluong=@sl, giaban=@gia, ghichu=@gc, HinhAnh=@anh WHERE ma_hang=@ma";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@anh", txtHinhAnh.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
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

        // ====================== Xóa ======================
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (kn.State == ConnectionState.Closed) kn.Open();

                    string sql = "DELETE FROM HangBan WHERE ma_hang=@ma";
                    SqlCommand cmd = new SqlCommand(sql, kn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
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

        // ====================== Hiển thị dữ liệu khi click DataGridView ======================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                ResetTextBoxes();
                return;
            }
            DisplayRow(dataGridView1.Rows[e.RowIndex]);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.CurrentRow == null)
            {
                ResetTextBoxes();
                return;
            }
            DisplayRow(dataGridView1.CurrentRow);
        }

        // ====================== Clear khi click ngoài ======================
        private void cuahang1_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }

        // ====================== Tìm kiếm ======================
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            try
            {
                if (kn.State == ConnectionState.Closed) kn.Open();
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú], HinhAnh AS [Hình ảnh] " +
                             "FROM HangBan WHERE ma_hang LIKE @kw OR tenhang LIKE @kw";
                SqlCommand cmd = new SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                searchAdapter.Fill(dt);

                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;

                if (dataGridView1.Rows.Count > 0)
                    DisplayRow(dataGridView1.Rows[0]);
                else
                    ResetTextBoxes();
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
