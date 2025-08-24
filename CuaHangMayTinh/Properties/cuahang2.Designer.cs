using System.Drawing;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class cuahang2 : UserControl
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // cuahang2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Name = "cuahang2";
            Size = new Size(978, 632);
            Load += cuahang2_Load;
            ResumeLayout(false);
        }
    }
}
