using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class khachhang : UserControl
    {
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet = new DataSet();
        private BindingSource bindingSource1 = new BindingSource();

        public khachhang()
        {
            InitializeComponent();
            this.Load += khachhang_Load;
            this.Click += KhachHang_Click;
            panel1.Click += KhachHang_Click;

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            LoadKhachHangData();
        }

        // 🔹 Load tất cả khách hàng
        private void LoadKhachHangData()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"SELECT ma_kh AS [Mã KH], ho + ' ' + ten AS [Tên khách hàng], 
                                          sdt AS [SĐT], diachi AS [Địa chỉ], ghichu AS [Ghi chú] 
                                   FROM KhachHang";
                    dataAdapter = new SqlDataAdapter(sql, conn);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "KhachHang");

                    bindingSource1.DataSource = dataSet.Tables["KhachHang"];
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
        }

        // 🔹 Thêm khách hàng
        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmakh.Text))
            {
                MessageBox.Show("Mã khách hàng không được để trống!");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra mã đã tồn tại chưa
                    string checkSql = "SELECT COUNT(*) FROM KhachHang WHERE ma_kh = @ma";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@ma", txtmakh.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng nhập mã khác.");
                        return;
                    }

                    string sql = @"INSERT INTO KhachHang(ma_kh, ho, ten, sdt, diachi, ghichu)
                                   VALUES(@ma, @ho, @ten, @sdt, @dc, @gc)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmakh.Text);
                    cmd.Parameters.AddWithValue("@ho", txtho.Text);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@gc", txtghichu.Text);

                    cmd.ExecuteNonQuery();
                    LoadKhachHangData();
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // 🔹 Sửa khách hàng
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE KhachHang 
                                   SET ho=@ho, ten=@ten, sdt=@sdt, diachi=@dc, ghichu=@gc 
                                   WHERE ma_kh=@ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmakh.Text);
                    cmd.Parameters.AddWithValue("@ho", txtho.Text);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@gc", txtghichu.Text);

                    cmd.ExecuteNonQuery();
                    LoadKhachHangData();
                    MessageBox.Show("Sửa khách hàng thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // 🔹 Xóa khách hàng
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM KhachHang WHERE ma_kh = @ma";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", txtmakh.Text);
                        cmd.ExecuteNonQuery();

                        LoadKhachHangData();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        // 🔹 Tìm kiếm khách hàng
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"SELECT ma_kh AS [Mã KH], ho + ' ' + ten AS [Tên khách hàng], 
                                          sdt AS [SĐT], diachi AS [Địa chỉ], ghichu AS [Ghi chú]
                                   FROM KhachHang
                                   WHERE ma_kh LIKE @kw OR ho LIKE @kw OR ten LIKE @kw";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    searchAdapter.Fill(dt);

                    bindingSource1.DataSource = dt;
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // 🔹 Cập nhật textbox khi chọn dòng
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxes(e.RowIndex);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                UpdateTextBoxes(dataGridView1.CurrentRow.Index);
        }

        private void UpdateTextBoxes(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count)
            {
                ClearTextBoxes();
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtmakh.Text = row.Cells["Mã KH"].Value?.ToString();

            string fullName = row.Cells["Tên khách hàng"].Value?.ToString();
            if (!string.IsNullOrEmpty(fullName))
            {
                string[] parts = fullName.Split(' ');
                if (parts.Length >= 2)
                {
                    txtho.Text = string.Join(" ", parts, 0, parts.Length - 1);
                    txtten.Text = parts[parts.Length - 1];
                }
                else
                {
                    txtho.Text = fullName;
                    txtten.Text = "";
                }
            }
            else
            {
                txtho.Text = "";
                txtten.Text = "";
            }

            txtsdt.Text = row.Cells["SĐT"].Value?.ToString();
            txtdiachi.Text = row.Cells["Địa chỉ"].Value?.ToString();
            txtghichu.Text = row.Cells["Ghi chú"].Value?.ToString();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ví dụ: vẽ nền, border, hay custom graphics
            // Nếu không cần, để trống cũng được
        }

        private void ClearTextBoxes()
        {
            txtmakh.Clear();
            txtho.Clear();
            txtten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtghichu.Clear();
        }
    }
}
