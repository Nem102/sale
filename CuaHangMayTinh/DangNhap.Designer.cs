namespace CuaHangMayTinh
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_matkhau = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            txt_taikhoan = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.5F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(75, 117);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập hệ thống";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(56, 186);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(57, 232);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txt_matkhau
            // 
            txt_matkhau.BackColor = SystemColors.InactiveCaption;
            txt_matkhau.Location = new Point(184, 239);
            txt_matkhau.Margin = new Padding(3, 2, 3, 2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(173, 23);
            txt_matkhau.TabIndex = 5;
            txt_matkhau.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 337);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 6;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(267, 337);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(163, 337);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 8;
            button3.Text = "Đăng ký";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(75, 288);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.BackColor = SystemColors.InactiveCaption;
            txt_taikhoan.Location = new Point(184, 195);
            txt_taikhoan.Margin = new Padding(3, 2, 3, 2);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(173, 23);
            txt_taikhoan.TabIndex = 10;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(441, 624);
            Controls.Add(txt_taikhoan);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_matkhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
