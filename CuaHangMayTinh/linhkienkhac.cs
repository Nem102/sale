using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CuaHangMayTinh
{
    public partial class linhkienkhac : UserControl
    {
        Microsoft.Data.SqlClient.SqlConnection kn = new Microsoft.Data.SqlClient.SqlConnection(
            @"Data Source=.;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
        );

        Microsoft.Data.SqlClient.SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public linhkienkhac()
        {
            InitializeComponent();

            this.Click += linhkienkhac_Click;
            panel1.Click += linhkienkhac_Click;
        }

        private void linhkienkhac_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        // ====================== Load dữ liệu ======================
        private void LoadData()
        {
            try
            {
                if (kn.State == ConnectionState.Closed) kn.Open();
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú], HinhAnh AS [Hình ảnh] " +
                             "FROM HangBan WHERE ma_hang LIKE 'LK%'";
                adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, kn);
                ds = new DataSet();
                adapter.Fill(ds, "HangBan");

                bindingSource1.DataSource = ds.Tables["HangBan"];
                dataGridView1.DataSource = bindingSource1;

                if (dataGridView1.Rows.Count > 0)
                    DisplayRow(dataGridView1.Rows[0]);
                else
                    ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
            finally
            {
                if (kn.State == ConnectionState.Open) kn.Close();
            }
        }

        // ====================== Load ảnh an toàn ======================
        private Image LoadImageSafe(string path)
        {
            if (!File.Exists(path)) return null;
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(fs);
            }
        }

        // ====================== Hiển thị dữ liệu ======================
        private void DisplayRow(DataGridViewRow row)
        {
            txtMaHang.Text = row.Cells["Mã hàng"].Value?.ToString();
            txtTenHang.Text = row.Cells["Tên hàng"].Value?.ToString();
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString();
            txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();
            txtHinhAnh.Text = row.Cells["Hình ảnh"].Value?.ToString();

            pictureBox1.Image = LoadImageSafe(txtHinhAnh.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (string.IsNullOrWhiteSpace(txtHinhAnh.Text))
                linkChonAnh.Text = "Thêm hình ảnh";
            else
                linkChonAnh.Text = "Thay đổi hình ảnh";
        }

        // ====================== Clear ======================
        private void ClearTextBoxes()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
            txtHinhAnh.Text = "";
            pictureBox1.Image = null;

            linkChonAnh.Text = "Thêm hình ảnh";
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

                    kn.Open();
                    string sql = "UPDATE HangBan SET HinhAnh=@anh WHERE ma_hang=@ma";
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, kn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                    cmd.Parameters.AddWithValue("@anh", originalPath);
                    cmd.ExecuteNonQuery();
                    kn.Close();

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chọn ảnh: " + ex.Message);
                }
            }
        }

        // ====================== Thêm ======================
        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã hàng không được để trống!");
                return;
            }

            try
            {
                kn.Open();
                string checkSql = "SELECT COUNT(*) FROM HangBan WHERE ma_hang = @ma";
                var checkCmd = new Microsoft.Data.SqlClient.SqlCommand(checkSql, kn);
                checkCmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã hàng đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }

                string sql = "INSERT INTO HangBan(ma_hang, tenhang, soluong, giaban, ghichu, HinhAnh) " +
                             "VALUES(@ma, @ten, @sl, @gia, @gc, @anh)";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@anh", txtHinhAnh.Text);

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

        // ====================== Sửa ======================
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE HangBan SET tenhang=@ten, soluong=@sl, giaban=@gia, ghichu=@gc, HinhAnh=@anh WHERE ma_hang=@ma";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gia", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@gc", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@anh", txtHinhAnh.Text);

                kn.Open();
                cmd.ExecuteNonQuery();
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

        // ====================== Xóa ======================
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM HangBan WHERE ma_hang=@ma";
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, kn);
                    cmd.Parameters.AddWithValue("@ma", txtMaHang.Text);

                    kn.Open();
                    cmd.ExecuteNonQuery();
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

        // ====================== DataGridView event ======================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                ClearTextBoxes();
                return;
            }
            DisplayRow(dataGridView1.Rows[e.RowIndex]);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.CurrentRow == null)
            {
                ClearTextBoxes();
                return;
            }
            DisplayRow(dataGridView1.CurrentRow);
        }

        private void linhkienkhac_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        // ====================== Tìm kiếm ======================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            try
            {
                kn.Open();
                string sql = "SELECT ma_hang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng], giaban AS [Giá bán], ghichu AS [Ghi chú], HinhAnh AS [Hình ảnh] " +
                             "FROM HangBan WHERE ma_hang LIKE @kw OR tenhang LIKE @kw";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                var searchAdapter = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                searchAdapter.Fill(dt);

                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;

                if (dataGridView1.Rows.Count > 0)
                    DisplayRow(dataGridView1.Rows[0]);
                else
                    ClearTextBoxes();
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
