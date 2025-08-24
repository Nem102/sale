using System.Drawing;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    partial class cuahang1
    {
        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(333, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐÂY LÀ MÀN HÌNH CỬA HÀNG";
            label1.Click += label1_Click;
            // 
            // cuahang1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            Controls.Add(label1);
            Name = "cuahang1";
            Size = new Size(978, 632);
            Load += cuahang1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
