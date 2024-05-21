namespace QLNS
{
    partial class frmServerName
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
            txtbtb_servername = new TextBox();
            lbl_servername = new Label();
            btn_truyenserver = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtbtb_servername
            // 
            txtbtb_servername.Location = new Point(95, 70);
            txtbtb_servername.Name = "txtbtb_servername";
            txtbtb_servername.Size = new Size(198, 23);
            txtbtb_servername.TabIndex = 0;
            // 
            // lbl_servername
            // 
            lbl_servername.AutoSize = true;
            lbl_servername.Location = new Point(12, 78);
            lbl_servername.Name = "lbl_servername";
            lbl_servername.Size = new Size(77, 15);
            lbl_servername.TabIndex = 1;
            lbl_servername.Text = "Server Name:";
            // 
            // btn_truyenserver
            // 
            btn_truyenserver.Location = new Point(125, 116);
            btn_truyenserver.Name = "btn_truyenserver";
            btn_truyenserver.Size = new Size(134, 23);
            btn_truyenserver.TabIndex = 2;
            btn_truyenserver.Text = "Truyền dữ liệu";
            btn_truyenserver.UseVisualStyleBackColor = true;
            btn_truyenserver.Click += btn_truyenserver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(95, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 3;
            label1.Text = "Server Name";
            // 
            // frmServerName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(305, 181);
            Controls.Add(label1);
            Controls.Add(btn_truyenserver);
            Controls.Add(lbl_servername);
            Controls.Add(txtbtb_servername);
            Name = "frmServerName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmServerName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbtb_servername;
        private Label lbl_servername;
        private Button btn_truyenserver;
        private Label label1;
    }
}