namespace QLNS
{
    partial class frmDangnhap
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
            lbl_tk = new Label();
            lbl_mk = new Label();
            txtb_tk = new TextBox();
            txtb_mk = new TextBox();
            btn_dangnhap = new Button();
            btn_thoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_tk
            // 
            lbl_tk.AutoSize = true;
            lbl_tk.Location = new Point(90, 89);
            lbl_tk.Name = "lbl_tk";
            lbl_tk.Size = new Size(57, 15);
            lbl_tk.TabIndex = 0;
            lbl_tk.Text = "Tài khoản";
            lbl_tk.Click += lbl_tk_Click;
            // 
            // lbl_mk
            // 
            lbl_mk.AutoSize = true;
            lbl_mk.Location = new Point(90, 162);
            lbl_mk.Name = "lbl_mk";
            lbl_mk.Size = new Size(57, 15);
            lbl_mk.TabIndex = 1;
            lbl_mk.Text = "Mật khẩu";
            // 
            // txtb_tk
            // 
            txtb_tk.Location = new Point(179, 81);
            txtb_tk.Name = "txtb_tk";
            txtb_tk.Size = new Size(259, 23);
            txtb_tk.TabIndex = 2;
            // 
            // txtb_mk
            // 
            txtb_mk.Location = new Point(179, 154);
            txtb_mk.Name = "txtb_mk";
            txtb_mk.PasswordChar = '*';
            txtb_mk.Size = new Size(259, 23);
            txtb_mk.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(179, 214);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(105, 23);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(346, 214);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(93, 23);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(129, 15);
            label1.Name = "label1";
            label1.Size = new Size(247, 54);
            label1.TabIndex = 6;
            label1.Text = "Đăng nhập";
            // 
            // frmDangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(552, 338);
            Controls.Add(label1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_dangnhap);
            Controls.Add(txtb_mk);
            Controls.Add(txtb_tk);
            Controls.Add(lbl_mk);
            Controls.Add(lbl_tk);
            Name = "frmDangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangnhap";
            FormClosing += frmDangnhap_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tk;
        private Label lbl_mk;
        private TextBox txtb_tk;
        private TextBox txtb_mk;
        private Button btn_dangnhap;
        private Button btn_thoat;
        private Label label1;
    }
}