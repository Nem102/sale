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
    public partial class linhkien : UserControl
    {
        public linhkien()
        {
            InitializeComponent();
        }

        private void linhkien_Load(object sender, EventArgs e)
        {

            label1.Text = "UserControl linh kien đã load!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}