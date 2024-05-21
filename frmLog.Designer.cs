namespace QLNS
{
    partial class frmLog
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
            dgv_log = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_log).BeginInit();
            SuspendLayout();
            // 
            // dgv_log
            // 
            dgv_log.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_log.Location = new Point(10, 8);
            dgv_log.Margin = new Padding(2);
            dgv_log.Name = "dgv_log";
            dgv_log.RowHeadersWidth = 62;
            dgv_log.RowTemplate.Height = 33;
            dgv_log.Size = new Size(815, 370);
            dgv_log.TabIndex = 0;
            // 
            // frmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 386);
            Controls.Add(dgv_log);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLog";
            FormClosing += frmLog_FormClosing;
            Load += frmLog_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_log).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_log;
    }
}