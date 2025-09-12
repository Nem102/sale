namespace CuaHangMayTinh
{
    partial class Formmenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmenu));
            menuStrip1 = new MenuStrip();
            cửaToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem1 = new ToolStripMenuItem();
            chuộtbànPhímvvToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            chiTiếtHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            khuyếnMãiToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.ImageScalingSize = new Size(30, 35);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                cửaToolStripMenuItem,
                sảnPhẩmToolStripMenuItem,
                hóaĐơnToolStripMenuItem,
                chiTiếtHóaĐơnToolStripMenuItem,
                kháchHàngToolStripMenuItem,
                nhânViênToolStripMenuItem,
                khuyếnMãiToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            // 
            // cửaToolStripMenuItem
            // 
            cửaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem });
            cửaToolStripMenuItem.Text = "Cửa Hàng";
            cửaToolStripMenuItem.Click += cửaToolStripMenuItem_Click;

            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Text = "Thoát";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;

            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmToolStripMenuItem1, chuộtbànPhímvvToolStripMenuItem });
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";

            // 
            // sảnPhẩmToolStripMenuItem1
            // 
            sảnPhẩmToolStripMenuItem1.Text = "Sản Phẩm Chính";
            sảnPhẩmToolStripMenuItem1.Click += sảnPhẩmToolStripMenuItem1_Click;

            // 
            // chuộtbànPhímvvToolStripMenuItem
            // 
            chuộtbànPhímvvToolStripMenuItem.Text = "Các thiết bị khác";
            chuộtbànPhímvvToolStripMenuItem.Click += chuộtbànPhímvvToolStripMenuItem_Click;

            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;

            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn";
            chiTiếtHóaĐơnToolStripMenuItem.Click += chiTiếtHóaĐơnToolStripMenuItem_Click;

            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;

            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;

            // 
            // khuyếnMãiToolStripMenuItem
            // 
            khuyếnMãiToolStripMenuItem.Text = "Khuyến Mãi";

            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Silver;
            panelMain.Dock = DockStyle.Fill; // ⚡ cực kỳ quan trọng
            panelMain.Location = new Point(0, 43); // phía dưới menuStrip
            panelMain.Name = "panelMain";
            panelMain.TabIndex = 1;

            // 
            // Formmenu
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 661);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Formmenu";
            Text = "Quản lý cửa hàng";
            Load += Formmenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cửaToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem1;
        private ToolStripMenuItem chuộtbànPhímvvToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private Panel panelMain;
    }
}
