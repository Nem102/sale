using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class DangNhap : Form
    {

        string connectionString =
 @"Data Source=DESKTOP-9BSLFIO;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";




        public DangNhap()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) {
            txt_matkhau.UseSystemPasswordChar = true;

        }
        private void button3_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM TaiKhoan ";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbUsername = reader["taikhoan"].ToString();
                        string dbPassword = reader["matkhau"].ToString();

                        if (password == dbPassword && username == dbUsername)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            // Mở form chính
                            Formmenu home = new Formmenu();
                            this.Hide();
                            home.ShowDialog();
                            this.Show();
                        }
                        else if (password != dbPassword && username != dbUsername)
                        {
                            MessageBox.Show("Tên đăng nhập và mật khẩu không đúng.");
                        }
                        else if (username != dbUsername)
                        {
                            MessageBox.Show("Tên đăng nhập không đúng.");
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng.");
                        }
                    }
                }
            }
        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false; // Hiện mật khẩu
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }
    }
}
