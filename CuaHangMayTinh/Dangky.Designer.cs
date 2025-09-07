namespace CuaHangMayTinh
{
    partial class Dangky
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMatKhau = new TextBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtCCCD = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTaiKhoan = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.InactiveCaption;
            txtMatKhau.Location = new Point(198, 265);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(173, 23);
            txtMatKhau.TabIndex = 19;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(89, 358);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(177, 407);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 17;
            button3.Text = "Đăng ký";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(281, 407);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 16;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(70, 407);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 15;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = SystemColors.InactiveCaption;
            txtCCCD.Location = new Point(198, 309);
            txtCCCD.Margin = new Padding(3, 2, 3, 2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(173, 23);
            txtCCCD.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(72, 258);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(70, 214);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 12;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.5F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(111, 145);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 11;
            label1.Text = "Đăng ký hệ thống";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = SystemColors.InactiveCaption;
            txtTaiKhoan.Location = new Point(199, 221);
            txtTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(173, 23);
            txtTaiKhoan.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(49, 302);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 20;
            label4.Text = "Nhập CCCD";
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(441, 624);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label4);
            Controls.Add(txtMatKhau);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCCCD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dangky";
            Text = "Dangky";
            Load += Dangky_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatKhau;
        private CheckBox checkBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtCCCD;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTaiKhoan;
        private Label label4;
    }
}