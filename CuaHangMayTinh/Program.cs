using System;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mở form đăng nhập đầu tiên
            DangNhap dn = new DangNhap();

            // Kiểm tra kết quả đăng nhập
            if (dn.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, mở Formmenu
                Application.Run(new Formmenu());
            }
            else
            {
                // Nếu hủy hoặc đăng nhập thất bại, thoát ứng dụng
                return;
            }
        }
    }
}
