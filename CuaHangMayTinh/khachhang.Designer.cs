namespace CuaHangMayTinh
{
    partial class khachhang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txttimkiem = new TextBox();
            txtdiachi = new TextBox();
            txtghichu = new TextBox();
            txtsdt = new TextBox();
            button10 = new Button();
            dataGridView1 = new DataGridView();
            bttimkiem = new Button();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            txtten = new TextBox();
            txtho = new TextBox();
            txtmakh = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(txttimkiem);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(txtghichu);
            panel1.Controls.Add(txtsdt);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(bttimkiem);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(txtten);
            panel1.Controls.Add(txtho);
            panel1.Controls.Add(txtmakh);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(110, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 695);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(709, 260);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(142, 23);
            txttimkiem.TabIndex = 35;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(709, 129);
            txtdiachi.Margin = new Padding(3, 2, 3, 2);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(142, 23);
            txtdiachi.TabIndex = 34;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(709, 178);
            txtghichu.Margin = new Padding(3, 2, 3, 2);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(142, 23);
            txtghichu.TabIndex = 33;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(709, 81);
            txtsdt.Margin = new Padding(3, 2, 3, 2);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(142, 23);
            txtsdt.TabIndex = 32;
            // 
            // button10
            // 
            button10.Location = new Point(379, 11);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(222, 41);
            button10.TabIndex = 31;
            button10.Text = "THÔNG TIN KHÁCH HÀNG";
            button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 310);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 385);
            dataGridView1.TabIndex = 30;
            // 
            // bttimkiem
            // 
            bttimkiem.BackColor = Color.Lime;
            bttimkiem.Location = new Point(582, 260);
            bttimkiem.Margin = new Padding(3, 2, 3, 2);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(96, 22);
            bttimkiem.TabIndex = 29;
            bttimkiem.Text = "🔍 Tìm kiếm";
            bttimkiem.UseVisualStyleBackColor = false;
            bttimkiem.Click += bttimkiem_Click;
            // 
            // btxoa
            // 
            btxoa.BackColor = Color.Lime;
            btxoa.Location = new Point(434, 260);
            btxoa.Margin = new Padding(3, 2, 3, 2);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(82, 22);
            btxoa.TabIndex = 28;
            btxoa.Text = "🗑️ Xóa";
            btxoa.UseVisualStyleBackColor = false;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.BackColor = Color.Lime;
            btsua.Location = new Point(270, 260);
            btsua.Margin = new Padding(3, 2, 3, 2);
            btsua.Name = "btsua";
            btsua.Size = new Size(82, 22);
            btsua.TabIndex = 27;
            btsua.Text = "✏️ Sửa";
            btsua.UseVisualStyleBackColor = false;
            btsua.Click += btsua_Click;
            // 
            // btthem
            // 
            btthem.BackColor = Color.Lime;
            btthem.Location = new Point(111, 260);
            btthem.Margin = new Padding(3, 2, 3, 2);
            btthem.Name = "btthem";
            btthem.Size = new Size(82, 22);
            btthem.TabIndex = 26;
            btthem.Text = "➕ Thêm";
            btthem.UseVisualStyleBackColor = false;
            btthem.Click += btthem_Click;
            // 
            // txtten
            // 
            txtten.Location = new Point(270, 178);
            txtten.Margin = new Padding(3, 2, 3, 2);
            txtten.Name = "txtten";
            txtten.Size = new Size(158, 23);
            txtten.TabIndex = 25;
            // 
            // txtho
            // 
            txtho.Location = new Point(270, 130);
            txtho.Margin = new Padding(3, 2, 3, 2);
            txtho.Name = "txtho";
            txtho.Size = new Size(158, 23);
            txtho.TabIndex = 24;
            // 
            // txtmakh
            // 
            txtmakh.Location = new Point(270, 82);
            txtmakh.Margin = new Padding(3, 2, 3, 2);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(158, 23);
            txtmakh.TabIndex = 23;
            // 
            // button6
            // 
            button6.Location = new Point(582, 177);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 22;
            button6.Text = "Ghi Chú";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(582, 128);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 21;
            button5.Text = "Địa Chỉ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(582, 81);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 20;
            button4.Text = "SDT";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(111, 177);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 19;
            button3.Text = "Tên";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(111, 128);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 18;
            button2.Text = "Họ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(111, 82);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(124, 22);
            button1.TabIndex = 17;
            button1.Text = "Mã Khách Hàng";
            button1.UseVisualStyleBackColor = true;
            // 
            // khachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panel1);
            Name = "khachhang";
            Size = new Size(1170, 697);
            Load += khachhang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txttimkiem;
        private TextBox txtdiachi;
        private TextBox txtghichu;
        private TextBox txtsdt;
        private Button button10;
        private DataGridView dataGridView1;
        private Button bttimkiem;
        private Button btxoa;
        private Button btsua;
        private Button btthem;
        private TextBox txtten;
        private TextBox txtho;
        private TextBox txtmakh;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
