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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void chuộtbànPhímvvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new linhkienkhac());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void cửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new cuahang1());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCBuildSẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new cuahang2());
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new hoadon());
        }

        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new laptop());
        }

        private void linhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new linhkien());
        }
    }
}
