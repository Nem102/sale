using System;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class cuahang2 : UserControl
    {
        public cuahang2()
        {
            InitializeComponent();
        }

        private void cuahang2_Load(object sender, EventArgs e)
        {
            // Code khi load control
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã bấm vào label!");
        }
    }
}
