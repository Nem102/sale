using System;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()   // <-- entry point phải như này
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form đăng nhập đầu tiên
            Application.Run(new DangNhap());
        }
    }
}
