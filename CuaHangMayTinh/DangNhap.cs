using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class DangNhap : Form
    {
        SqlConnection conn = DbHelper.GetConnection();


        public DangNhap()
        {
            InitializeComponent();
            txt_matkhau.UseSystemPasswordChar = true; // mặc định ẩn mật khẩu
        }

        // Hiện / ẩn mật khẩu theo checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Nút đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection()) // ✅ dùng DbHelper
                {
                    conn.Open();
                    string query = "SELECT matkhau FROM TaiKhoan WHERE taikhoan = @username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string dbPassword = result.ToString();

                            if (password == dbPassword)
                            {
                                MessageBox.Show("Đăng nhập thành công!");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không đúng.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }

        // Nút hủy / đóng form
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Nút mở form đăng ký
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangky dk = new Dangky();
            dk.ShowDialog(); // mở đăng ký chặn đăng nhập
            this.Show();      // trở lại đăng nhập sau khi đóng đăng ký
        }

        // Các event không dùng, chỉ để tránh lỗi designer
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
