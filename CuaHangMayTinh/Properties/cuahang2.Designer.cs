using System.Drawing;
using System.Windows.Forms;

namespace CuaHangMayTinh
{
    public partial class cuahang2 : UserControl
    {
        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(352, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐÂY LÀ MÀN HÌNH CỬA HÀNG 2";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(254, 269);
            button1.Name = "button1";
            button1.Size = new Size(228, 95);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // cuahang2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "cuahang2";
            Size = new Size(978, 632);
            Load += cuahang2_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
    }
}
