namespace QLNS
{
    partial class frmQuanLyNhanSu
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
            lbl_manv = new Label();
            lbl_hoten = new Label();
            lbl_gioitinh = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_luong = new Label();
            lbl_phucap = new Label();
            lbl_masothue = new Label();
            lbl_maphongban = new Label();
            txtb_manv = new TextBox();
            txtb_hoten = new TextBox();
            txtb_sdt = new TextBox();
            txtb_luong = new TextBox();
            txtb_phucap = new TextBox();
            txtb_masothue = new TextBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            lst_ds = new ListView();
            manv = new ColumnHeader();
            hoten = new ColumnHeader();
            gioitinh = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            sdt = new ColumnHeader();
            luong = new ColumnHeader();
            phucap = new ColumnHeader();
            masothue = new ColumnHeader();
            mapb = new ColumnHeader();
            dt_ngaysinh = new DateTimePicker();
            txtb_matkhau = new TextBox();
            lbl_mk = new Label();
            label1 = new Label();
            cbB_phongban = new ComboBox();
            btn_clear = new Button();
            cbB_gioitinh = new ComboBox();
            btn_log = new Button();
            SuspendLayout();
            // 
            // lbl_manv
            // 
            lbl_manv.AutoSize = true;
            lbl_manv.Location = new Point(54, 51);
            lbl_manv.Name = "lbl_manv";
            lbl_manv.Size = new Size(79, 15);
            lbl_manv.TabIndex = 0;
            lbl_manv.Text = "Mã nhân viên";
            // 
            // lbl_hoten
            // 
            lbl_hoten.AutoSize = true;
            lbl_hoten.Location = new Point(54, 88);
            lbl_hoten.Name = "lbl_hoten";
            lbl_hoten.Size = new Size(43, 15);
            lbl_hoten.TabIndex = 1;
            lbl_hoten.Text = "Họ tên";
            // 
            // lbl_gioitinh
            // 
            lbl_gioitinh.AutoSize = true;
            lbl_gioitinh.Location = new Point(54, 124);
            lbl_gioitinh.Name = "lbl_gioitinh";
            lbl_gioitinh.Size = new Size(52, 15);
            lbl_gioitinh.TabIndex = 2;
            lbl_gioitinh.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 160);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 202);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // lbl_luong
            // 
            lbl_luong.AutoSize = true;
            lbl_luong.Location = new Point(462, 51);
            lbl_luong.Name = "lbl_luong";
            lbl_luong.Size = new Size(41, 15);
            lbl_luong.TabIndex = 5;
            lbl_luong.Text = "Lương";
            // 
            // lbl_phucap
            // 
            lbl_phucap.AutoSize = true;
            lbl_phucap.Location = new Point(462, 88);
            lbl_phucap.Name = "lbl_phucap";
            lbl_phucap.Size = new Size(50, 15);
            lbl_phucap.TabIndex = 6;
            lbl_phucap.Text = "Phụ cấp";
            // 
            // lbl_masothue
            // 
            lbl_masothue.AutoSize = true;
            lbl_masothue.Location = new Point(462, 124);
            lbl_masothue.Name = "lbl_masothue";
            lbl_masothue.Size = new Size(66, 15);
            lbl_masothue.TabIndex = 7;
            lbl_masothue.Text = "Mã số thuế";
            // 
            // lbl_maphongban
            // 
            lbl_maphongban.AutoSize = true;
            lbl_maphongban.Location = new Point(462, 196);
            lbl_maphongban.Name = "lbl_maphongban";
            lbl_maphongban.Size = new Size(85, 15);
            lbl_maphongban.TabIndex = 9;
            lbl_maphongban.Text = "Mã phòng ban";
            // 
            // txtb_manv
            // 
            txtb_manv.Location = new Point(151, 48);
            txtb_manv.Name = "txtb_manv";
            txtb_manv.Size = new Size(269, 23);
            txtb_manv.TabIndex = 10;
            // 
            // txtb_hoten
            // 
            txtb_hoten.Location = new Point(151, 80);
            txtb_hoten.Name = "txtb_hoten";
            txtb_hoten.Size = new Size(269, 23);
            txtb_hoten.TabIndex = 11;
            // 
            // txtb_sdt
            // 
            txtb_sdt.Location = new Point(151, 194);
            txtb_sdt.Name = "txtb_sdt";
            txtb_sdt.Size = new Size(269, 23);
            txtb_sdt.TabIndex = 14;
            // 
            // txtb_luong
            // 
            txtb_luong.Location = new Point(555, 51);
            txtb_luong.Name = "txtb_luong";
            txtb_luong.Size = new Size(266, 23);
            txtb_luong.TabIndex = 15;
            // 
            // txtb_phucap
            // 
            txtb_phucap.Location = new Point(555, 80);
            txtb_phucap.Name = "txtb_phucap";
            txtb_phucap.Size = new Size(266, 23);
            txtb_phucap.TabIndex = 16;
            // 
            // txtb_masothue
            // 
            txtb_masothue.Location = new Point(555, 117);
            txtb_masothue.Name = "txtb_masothue";
            txtb_masothue.Size = new Size(266, 23);
            txtb_masothue.TabIndex = 17;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(555, 244);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(75, 22);
            btn_them.TabIndex = 20;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(653, 244);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(75, 22);
            btn_xoa.TabIndex = 21;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(746, 244);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(75, 22);
            btn_sua.TabIndex = 22;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // lst_ds
            // 
            lst_ds.Columns.AddRange(new ColumnHeader[] { manv, hoten, gioitinh, ngaysinh, sdt, luong, phucap, masothue, mapb });
            lst_ds.FullRowSelect = true;
            lst_ds.GridLines = true;
            lst_ds.Location = new Point(54, 286);
            lst_ds.Name = "lst_ds";
            lst_ds.Size = new Size(767, 240);
            lst_ds.TabIndex = 23;
            lst_ds.UseCompatibleStateImageBehavior = false;
            lst_ds.View = View.Details;
            lst_ds.SelectedIndexChanged += lst_ds_SelectedIndexChanged;
            // 
            // manv
            // 
            manv.Text = "Mã nhân viên";
            manv.Width = 100;
            // 
            // hoten
            // 
            hoten.Text = "Họ tên";
            hoten.Width = 150;
            // 
            // gioitinh
            // 
            gioitinh.Text = "Giới tính";
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.Width = 100;
            // 
            // sdt
            // 
            sdt.Text = "Số điện thoại";
            sdt.Width = 100;
            // 
            // luong
            // 
            luong.Text = "Lương";
            luong.Width = 100;
            // 
            // phucap
            // 
            phucap.Text = "Phụ cấp";
            phucap.Width = 100;
            // 
            // masothue
            // 
            masothue.Text = "Mã số thuế";
            masothue.Width = 100;
            // 
            // mapb
            // 
            mapb.Text = "Mã phòng ban";
            // 
            // dt_ngaysinh
            // 
            dt_ngaysinh.Location = new Point(151, 156);
            dt_ngaysinh.Name = "dt_ngaysinh";
            dt_ngaysinh.Size = new Size(269, 23);
            dt_ngaysinh.TabIndex = 24;
            // 
            // txtb_matkhau
            // 
            txtb_matkhau.Location = new Point(555, 153);
            txtb_matkhau.Name = "txtb_matkhau";
            txtb_matkhau.Size = new Size(266, 23);
            txtb_matkhau.TabIndex = 26;
            // 
            // lbl_mk
            // 
            lbl_mk.AutoSize = true;
            lbl_mk.Location = new Point(462, 159);
            lbl_mk.Name = "lbl_mk";
            lbl_mk.Size = new Size(57, 15);
            lbl_mk.TabIndex = 25;
            lbl_mk.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 28;
            label1.Text = "Lương";
            // 
            // cbB_phongban
            // 
            cbB_phongban.FormattingEnabled = true;
            cbB_phongban.Location = new Point(559, 190);
            cbB_phongban.Margin = new Padding(2);
            cbB_phongban.Name = "cbB_phongban";
            cbB_phongban.Size = new Size(261, 23);
            cbB_phongban.TabIndex = 29;
            cbB_phongban.SelectedIndexChanged += cbB_phongban_SelectedIndexChanged;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(462, 244);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 22);
            btn_clear.TabIndex = 30;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // cbB_gioitinh
            // 
            cbB_gioitinh.FormattingEnabled = true;
            cbB_gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbB_gioitinh.Location = new Point(151, 118);
            cbB_gioitinh.Margin = new Padding(2);
            cbB_gioitinh.Name = "cbB_gioitinh";
            cbB_gioitinh.Size = new Size(269, 23);
            cbB_gioitinh.TabIndex = 31;
            // 
            // btn_log
            // 
            btn_log.Location = new Point(367, 244);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(75, 22);
            btn_log.TabIndex = 32;
            btn_log.Text = "Log";
            btn_log.UseVisualStyleBackColor = true;
            btn_log.Click += btn_log_Click;
            // 
            // frmQuanLyNhanSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(871, 538);
            Controls.Add(btn_log);
            Controls.Add(cbB_gioitinh);
            Controls.Add(btn_clear);
            Controls.Add(cbB_phongban);
            Controls.Add(label1);
            Controls.Add(txtb_matkhau);
            Controls.Add(lbl_mk);
            Controls.Add(dt_ngaysinh);
            Controls.Add(lst_ds);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(txtb_masothue);
            Controls.Add(txtb_phucap);
            Controls.Add(txtb_luong);
            Controls.Add(txtb_sdt);
            Controls.Add(txtb_hoten);
            Controls.Add(txtb_manv);
            Controls.Add(lbl_maphongban);
            Controls.Add(lbl_masothue);
            Controls.Add(lbl_phucap);
            Controls.Add(lbl_luong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_gioitinh);
            Controls.Add(lbl_hoten);
            Controls.Add(lbl_manv);
            Name = "frmQuanLyNhanSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyNhanSu";
            FormClosing += frmQuanLyNhanSu_FormClosing;
            Load += frmQuanLyNhanSu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_manv;
        private Label lbl_hoten;
        private Label lbl_gioitinh;
        private Label label4;
        private Label label5;
        private Label lbl_luong;
        private Label lbl_phucap;
        private Label lbl_masothue;
        private Label lbl_maphongban;
        private TextBox txtb_manv;
        private TextBox txtb_hoten;
        private TextBox txtb_sdt;
        private TextBox txtb_luong;
        private TextBox txtb_phucap;
        private TextBox txtb_masothue;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private ListView lst_ds;
        private ColumnHeader manv;
        private ColumnHeader hoten;
        private ColumnHeader gioitinh;
        private ColumnHeader ngaysinh;
        private ColumnHeader sdt;
        private ColumnHeader luong;
        private ColumnHeader phucap;
        private ColumnHeader masothue;
        private ColumnHeader mapb;
        private DateTimePicker dt_ngaysinh;
        private TextBox txtb_matkhau;
        private Label lbl_mk;
        private Label label1;
        private ComboBox cbB_phongban;
        private Button btn_clear;
        private ComboBox cbB_gioitinh;
        private Button btn_log;
    }
}