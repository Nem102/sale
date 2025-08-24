using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class hoadon : UserControl
    {
        public hoadon()
        {
            InitializeComponent();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {

            label1.Text = "UserControl Hóa đơn đã load!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}