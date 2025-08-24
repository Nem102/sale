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
    public partial class linhkienkhac : UserControl
    {
        public linhkienkhac()
        {
            InitializeComponent();
        }

        private void linhkienkhac_Load(object sender, EventArgs e)
        {

            label1.Text = "UserControl linhkienkhac đã load!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}