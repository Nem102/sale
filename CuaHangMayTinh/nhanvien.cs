using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class nhanvien : UserControl
    {
        private BindingSource bindingSource1 = new BindingSource();

        public nhanvien()
        {
            InitializeComponent();
            this.Click += NhanVien_Click;
            panel1.Click += NhanVien_Click;
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            LoadNhanVienData();

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Nếu không cần làm gì đặc biệt, có thể để trống
            // Ví dụ: vẽ viền, màu nền tùy ý
        }

        private void LoadNhanVienData()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"SELECT ma_nv AS [Mã NV], 
                                          ho + ' ' + ten AS [Tên nhân viên], 
                                          sdt AS [SĐT], 
                                          diachi AS [Địa chỉ], 
                                          ghichu AS [Ghi chú] 
                                   FROM NhanVien";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    bindingSource1.DataSource = dt;
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra trùng mã
                    string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE ma_nv=@ma";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@ma", txtmanv.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                        return;
                    }

                    string sql = @"INSERT INTO NhanVien(ma_nv, ho, ten, sdt, diachi, ghichu)
                                   VALUES(@ma, @ho, @ten, @sdt, @dc, @gc)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmanv.Text);
                    cmd.Parameters.AddWithValue("@ho", txtho.Text);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@gc", txtghichu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVienData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE NhanVien 
                                   SET ho=@ho, ten=@ten, sdt=@sdt, diachi=@dc, ghichu=@gc 
                                   WHERE ma_nv=@ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtmanv.Text);
                    cmd.Parameters.AddWithValue("@ho", txtho.Text);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@dc", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@gc", txtghichu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa nhân viên thành công!");
                    LoadNhanVienData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }
        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            // Nếu chưa cần xử lý gì thì để trống
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM NhanVien WHERE ma_nv=@ma";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", txtmanv.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        LoadNhanVienData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string sql = @"SELECT ma_nv AS [Mã NV], ho + ' ' + ten AS [Tên nhân viên], sdt AS [SĐT], diachi AS [Địa chỉ], ghichu AS [Ghi chú] 
                                   FROM NhanVien 
                                   WHERE ma_nv LIKE @kw OR ho LIKE @kw OR ten LIKE @kw";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    bindingSource1.DataSource = dt;
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                ClearTextBoxes();
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtmanv.Text = row.Cells["Mã NV"].Value?.ToString();

            string fullName = row.Cells["Tên nhân viên"].Value?.ToString();
            if (!string.IsNullOrEmpty(fullName))
            {
                string[] parts = fullName.Split(' ');
                txtho.Text = string.Join(" ", parts, 0, parts.Length - 1);
                txtten.Text = parts[parts.Length - 1];
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(dataGridView1.CurrentRow.Index, 0));
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtmanv.Clear();
            txtho.Clear();
            txtten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtghichu.Clear();
        }


    }
}
