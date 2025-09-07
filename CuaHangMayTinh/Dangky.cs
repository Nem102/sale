using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class Dangky : Form
    {
        private readonly string connectionString =
@"Data Source=DESKTOP-9BSLFIO;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public Dangky()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true; // mặc định ẩn mật khẩu
        }

        // CheckBox hiện/ẩn mật khẩu
        private void checkBoxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Nút đăng ký
        private void btnDangky_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string cccd = txtCCCD.Text.Trim();

            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản, Mật khẩu và CCCD!");
                return;
            }

            // Loại bỏ tất cả ký tự không phải số để kiểm tra độ dài
            string cccdOnlyDigits = new string(cccd.Where(char.IsDigit).ToArray());

            if (cccdOnlyDigits.Length != 12)
            {
                MessageBox.Show("CCCD phải gồm 12 chữ số!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    // Kiểm tra tài khoản tồn tại
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE taikhoan=@taikhoan";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!");
                            return;
                        }
                    }

                    // Thêm tài khoản mới
                    string insertQuery = "INSERT INTO TaiKhoan (taikhoan, matkhau, cccd) VALUES (@taikhoan, @matkhau, @cccd)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                        cmd.Parameters.AddWithValue("@matkhau", matkhau);
                        cmd.Parameters.AddWithValue("@cccd", cccdOnlyDigits); // lưu đúng 12 số
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.");

                    // Chuyển sang form đăng nhập
                    this.Hide();
                    DangNhap dn = new DangNhap();
                    dn.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối database: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
