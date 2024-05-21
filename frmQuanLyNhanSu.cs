using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNS
{
    public partial class frmQuanLyNhanSu : Form
    {
        public string conString = "";
        public string MaNv = "";
        public int department = 0;
        SqlConnection sqlCon = null;
        public frmQuanLyNhanSu(string connectionString, string username)
        {

            InitializeComponent();
            conString = connectionString;
            MaNv = username;
            department = Int32.Parse(username.Substring(2, 1));
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn chắc là muốn xóa chứ?", "Xóa nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    string Manv = txtb_manv.Text;

            //    if (sqlCon == null)
            //    {
            //        sqlCon = new SqlConnection(conString);
            //    }
            //    if (sqlCon.State == ConnectionState.Closed)
            //    {
            //        sqlCon.Open();
            //    }
            //    SqlCommand cmd = new SqlCommand("exec proc_deleteNhanSu '" + Manv + "'", sqlCon);
            //    cmd.ExecuteNonQuery();
            //    sqlCon.Close();
            //    MessageBox.Show("Xóa thành công!");
            //    frmQuanLyNhanSu_Load(sender, e);
            //    ClearTextbox();
            //}
            string Manv = txtb_manv.Text;
            label1.Text = MaNv;
            txtb_manv.Enabled = false;
            if (txtb_manv.Text == label1.Text)
            {
                MessageBox.Show("Bạn không thể xóa nhân viên này!");
            }
            else
            {
                try
                {
                    if (sqlCon == null)
                    {
                        sqlCon = new SqlConnection(conString);
                    }
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from Nhanvien where MaNv='" + Manv + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Xóa thành công!");
                    frmQuanLyNhanSu_Load(sender, e);
                    WriteLog();
                    ClearTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                }
            }



        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            txtb_manv.Enabled = false;
            string Manv = txtb_manv.Text;
            string Hoten = txtb_hoten.Text;
            string Gioitinh = cbB_gioitinh.Text;
            DateTime Ngaysinh = DateTime.Parse(dt_ngaysinh.Text);
            string Sdt = txtb_sdt.Text;
            string Masothue = txtb_masothue.Text;
            string Matkhau = txtb_matkhau.Text;
            int Mapb = cbB_phongban.SelectedIndex;

            int department = CheckPhanQuyen(MaNv);
            switch (department)
            {
                case 1: // Nhân viên phòng nhân sự
                    if (sqlCon == null)
                    {
                        sqlCon = new SqlConnection(conString);
                    }
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }

                    SqlCommand cmd = new SqlCommand("update Nhanvien set Hoten =  N'" + Hoten + "', Gioitinh = N'" + Gioitinh + "', Ngaysinh ='" + Ngaysinh + "', Sdt ='" + Sdt + "', Masothue='" + Masothue + "',Maphongban='" + Mapb + "' where MaNv ='" + Manv + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Sửa thành công!");
                    frmQuanLyNhanSu_Load(sender, e);
                    WriteLog();
                    ClearTextbox();

                    break;
                case 3: // Nhân viên
                    try
                    {
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        txtb_luong.Enabled = false;
                        txtb_phucap.Enabled = false;
                        SqlCommand cmd1 = new SqlCommand("update Nhanvien set Hoten =  N'" + Hoten + "', Gioitinh = N'" + Gioitinh + "', Ngaysinh ='" + Ngaysinh + "', Sdt ='" + Sdt + "', Masothue='" + Masothue + "',Maphongban='" + Mapb + "' where MaNv ='" + Manv + "'", sqlCon);
                        cmd1.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Sửa thành công!");
                        frmQuanLyNhanSu_Load(sender, e);
                        ClearTextbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                    }


                    break;
                case 2: //Nhân viên tài vụ
                    try
                    {
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        txtb_luong.Enabled = false;
                        txtb_phucap.Enabled = false;
                        SqlCommand cmd1 = new SqlCommand("update Nhanvien set Hoten =  N'" + Hoten + "', Gioitinh = N'" + Gioitinh + "', Ngaysinh ='" + Ngaysinh + "', Sdt ='" + Sdt + "', Masothue='" + Masothue + "',Maphongban='" + Mapb + "' where MaNv ='" + Manv + "'", sqlCon);
                        cmd1.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Sửa thành công!");
                        frmQuanLyNhanSu_Load(sender, e);
                        ClearTextbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                    }
                    break;
                case 0: //Giám đốc
                    int Luong = Int32.Parse(txtb_luong.Text);
                    int Phucap = Int32.Parse(txtb_phucap.Text);
                    string LuongMaHoa = "";
                    string PhucapMaHoa = "";
                    string MatKhauHash = "";
                    try
                    {
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        using (SqlCommand command = new SqlCommand("proc_MaHoaLuongPhuCap", sqlCon))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Luong", Luong);
                            command.Parameters.AddWithValue("@Phucap", Phucap);
                            command.Parameters.AddWithValue("@MatKhau", Matkhau);
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                LuongMaHoa = reader["Luong"].ToString();
                                PhucapMaHoa = reader["Phucap"].ToString();

                                SqlCommand command1 = new SqlCommand("update Nhanvien set Luong = Convert(varbinary(max), '" + LuongMaHoa + "'), Phucap = Convert(varbinary(max), '" + PhucapMaHoa + "')  where MaNv ='" + Manv + "'", sqlCon);
                                //CAST(  '" + LuongMaHoa + "' AS VARBINARY(MAX))
                                //Convert(varbinary(max), '" + LuongMaHoa + "')
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Sửa thành công!");
                                frmQuanLyNhanSu_Load(sender, e);
                                WriteLog();
                                ClearTextbox();
                            }
                            reader.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                    }


                    break;
                default:
                    cbB_phongban.Visible = true;
                    break;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            txtb_manv.Enabled = false;
            string Manv = txtb_manv.Text;
            string Hoten = txtb_hoten.Text;
            string Gioitinh = cbB_gioitinh.Text;
            DateTime Ngaysinh = DateTime.Parse(dt_ngaysinh.Text);
            string Sdt = txtb_sdt.Text;
            int Luong = Int32.Parse(txtb_luong.Text);
            int Phucap = Int32.Parse(txtb_phucap.Text);
            string Masothue = txtb_masothue.Text;
            string Matkhau = txtb_matkhau.Text;
            int Mapb = cbB_phongban.SelectedIndex;
            string LuongMaHoa = "";
            string PhucapMaHoa = "";
            string MatKhauHash = "";

            int department = CheckPhanQuyen(MaNv);
            switch (department)
            {
                case 1: // Nhân viên phòng nhân sự
                    if (txtb_hoten.Text == "" || txtb_manv.Text == "" || txtb_sdt.Text == "" || txtb_matkhau.Text == "" || txtb_masothue.Text == "" || cbB_gioitinh.Text == "" || dt_ngaysinh.Text == "")
                    {
                        MessageBox.Show("Hãy điền đầy đủ thông tin!");
                    }
                    else
                    {

                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }

                        using (SqlCommand command = new SqlCommand("proc_MaHoaLuongPhuCap", sqlCon))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Luong", Luong);
                            command.Parameters.AddWithValue("@Phucap", Phucap);
                            command.Parameters.AddWithValue("@MatKhau", Matkhau);


                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {

                                // Đọc vai trò của người dùng từ kết quả trả về
                                LuongMaHoa = reader["Luong"].ToString();
                                PhucapMaHoa = reader["Phucap"].ToString();
                                MatKhauHash = reader["MatKhau"].ToString();
                                reader.Close();
                                SqlCommand cmd = new SqlCommand("insert into Nhanvien values('" + Manv + "', N'" + Hoten + "', N'" + Gioitinh + "','" + Ngaysinh + "','" + Sdt + "', Convert(varbinary(max), '" + LuongMaHoa + "'), Convert(varbinary(max),'" + PhucapMaHoa + "'),'" + Masothue + "','" + MatKhauHash + "','" + Mapb + "')", sqlCon);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công nhân viên mới!");
                                frmQuanLyNhanSu_Load(sender, e);
                                WriteLog();
                            }
                            reader.Close();
                        }
                        ClearTextbox();
                    }

                    break;
                case 3: // Nhân viên
                    try
                    {
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        SqlCommand cmd = new SqlCommand("insert into Nhanvien values('" + Manv + "', N'" + Hoten + "', N'" + Gioitinh + "','" + Ngaysinh + "','" + Sdt + "','" + Masothue + "','" + Mapb + "')", sqlCon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công nhân viên mới!");
                        frmQuanLyNhanSu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");

                    }
                    ClearTextbox();


                    break;
                case 2: //Nhân viên tài vụ
                    try
                    {
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        SqlCommand cmd = new SqlCommand("insert into Nhanvien values('" + Manv + "', N'" + Hoten + "', N'" + Gioitinh + "','" + Ngaysinh + "','" + Sdt + "','" + Masothue + "','" + Mapb + "')", sqlCon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công nhân viên mới!");
                        frmQuanLyNhanSu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");

                    }
                    ClearTextbox();
                    break;
                case 0: //Giám đốc
                    if (txtb_luong.Text == "0" || txtb_phucap.Text == "0")
                    {
                        MessageBox.Show("Hãy điền đầy đủ thông tin!");
                    }
                    else
                    {
                        try
                        {

                            if (sqlCon == null)
                            {
                                sqlCon = new SqlConnection(conString);
                            }
                            if (sqlCon.State == ConnectionState.Closed)
                            {
                                sqlCon.Open();
                            }

                            txtb_hoten.Enabled = false;
                            txtb_masothue.Enabled = false;
                            txtb_sdt.Enabled = false;
                            txtb_matkhau.Enabled = false;
                            using (SqlCommand command = new SqlCommand("proc_MaHoaLuongPhuCap", sqlCon))
                            {

                                string LuongMaHoa1 = "";
                                string PhucapMaHoa1 = "";

                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@Luong", Luong);
                                command.Parameters.AddWithValue("@Phucap", Phucap);
                                command.Parameters.AddWithValue("@MatKhau", Matkhau);
                                SqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    LuongMaHoa1 = reader["Luong"].ToString();
                                    PhucapMaHoa1 = reader["Phucap"].ToString();
                                    MatKhauHash = reader["MatKhau"].ToString();
                                    reader.Close();
                                    SqlCommand command1 = new SqlCommand("insert into Nhanvien values('" + Manv + "', N'" + Hoten + "', N'" + Gioitinh + "', '" + Ngaysinh + "', '" + Sdt + "', CAST(  '" + LuongMaHoa + "' AS VARBINARY(MAX)), CAST(  '" + PhucapMaHoa + "' AS VARBINARY(MAX)), '" + Masothue + "', '" + MatKhauHash + "', '" + Mapb + "')", sqlCon);
                                    command1.ExecuteNonQuery();
                                    sqlCon.Close();
                                    MessageBox.Show("Thêm thành công nhân viên mới!");
                                    frmQuanLyNhanSu_Load(sender, e);
                                    WriteLog();
                                    ClearTextbox();
                                }
                                reader.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                        }
                    }



                    break;
                default:
                    cbB_phongban.Visible = true;
                    break;
            }

        }

        void ClearTextbox()
        {
            cbB_gioitinh.Text = "";
            txtb_hoten.Clear();
            txtb_luong.Text = "0";
            txtb_manv.Clear();
            cbB_phongban.Text = "";
            txtb_masothue.Clear();
            txtb_matkhau.Clear();
            txtb_phucap.Text = "0";
            txtb_sdt.Clear();
            txtb_matkhau.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            int department = CheckPhanQuyen(MaNv);
            switch (department)
            {
                case 1:
                    txtb_luong.Enabled = false;
                    txtb_phucap.Enabled = false;
                    break;
                case 0:
                    txtb_hoten.Enabled = true;
                    txtb_manv.Enabled = true;
                    txtb_masothue.Enabled = true;
                    txtb_matkhau.Enabled = true;
                    txtb_sdt.Enabled = true;
                    cbB_gioitinh.Enabled = true;
                    dt_ngaysinh.Enabled = true;
                    break;
            }

        }
        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            label1.Text = MaNv;
            txtb_manv.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
            Combobox_list();
            int role = CheckPhanQuyen(MaNv);
            switch (role)
            {
                case 1: // Nhân viên phòng nhân sự
                    GetListEncr();
                    btn_log.Visible = false;
                    break;
                case 3: // Nhân viên
                    GetListEncr();
                    cbB_phongban.Visible = false;
                    lbl_maphongban.Visible = false;
                    btn_log.Visible = false;
                    break;
                case 2: //Nhân viên tài vụ
                    GetListDecr();
                    btn_log.Visible = false;
                    break;
                case 0: //Giám đốc
                    GetListDecr();
                    txtb_manv.Enabled = false;
                    txtb_hoten.Enabled = false;
                    txtb_masothue.Enabled = false;
                    txtb_matkhau.Enabled = false;
                    txtb_sdt.Enabled = false;
                    cbB_gioitinh.Enabled = false;
                    dt_ngaysinh.Enabled = false;
                    break;
                default:
                    cbB_phongban.Visible = true;
                    break;
            }

        }
        int CheckPhanQuyen(string Manv)
        {
            string department = Manv.Substring(2, 1);
            int Urole = Int32.Parse(department);
            return Urole;
        }

        void GetListEncr()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "proc_SelectEncrAccDepart";
            sqlCmd.Parameters.AddWithValue("@Mapb", department);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lst_ds.Items.Clear();
            while (reader.Read())
            {
                string MaNv = reader.GetString(0);
                string Hoten = reader.GetString(1);
                string Gioitinh = reader.GetString(2);
                DateTime Ngaysinh = reader.GetDateTime(3);
                string Sdt = reader.GetString(4);
                string Masothue = reader.GetString(7);
                int Maphongban = reader.GetInt32(8);

                ListViewItem lvi = new ListViewItem(MaNv);
                lvi.SubItems.Add(Hoten);
                lvi.SubItems.Add(Gioitinh);
                lvi.SubItems.Add(Ngaysinh.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(Sdt);
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add(Masothue);
                lvi.SubItems.Add(Maphongban.ToString());

                lst_ds.Items.Add(lvi);

            }
            reader.Close();
        }

        void GetListDecr()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "proc_SelectAccDepart";
            sqlCmd.Parameters.AddWithValue("@Mapb", department);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lst_ds.Items.Clear();
            while (reader.Read())
            {
                string MaNv = reader.GetString(0);
                string Hoten = reader.GetString(1);
                string Gioitinh = reader.GetString(2);
                DateTime Ngaysinh = reader.GetDateTime(3);
                string Sdt = reader.GetString(4);
                int luong = reader.GetInt32(5);
                int phucap = reader.GetInt32(6);
                string Masothue = reader.GetString(7);
                int Maphongban = reader.GetInt32(8);

                ListViewItem lvi = new ListViewItem(MaNv);
                lvi.SubItems.Add(Hoten);
                lvi.SubItems.Add(Gioitinh);
                lvi.SubItems.Add(Ngaysinh.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(Sdt);
                lvi.SubItems.Add(luong.ToString());
                lvi.SubItems.Add(phucap.ToString());
                lvi.SubItems.Add(Masothue);
                lvi.SubItems.Add(Maphongban.ToString());

                lst_ds.Items.Add(lvi);

            }
            reader.Close();
        }

        private void lst_ds_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            txtb_luong.Enabled = false;
            txtb_phucap.Enabled = false;

            int role = CheckPhanQuyen(MaNv);
            switch (role)
            {
                case 0:
                    {
                        txtb_luong.Enabled = true;
                        txtb_phucap.Enabled = true;
                    }
                    break;
            }
            if (lst_ds.SelectedItems.Count == 0) return;
            else
            {
                ListViewItem lvi = lst_ds.SelectedItems[0];
                txtb_manv.Text = lvi.SubItems[0].Text;
                txtb_hoten.Text = lvi.SubItems[1].Text;
                cbB_gioitinh.Text = lvi.SubItems[2].Text;
                DateTime birthDate;
                if (DateTime.TryParse(lvi.SubItems[3].Text, out birthDate))
                {
                    dt_ngaysinh.Value = birthDate;
                }
                txtb_sdt.Text = lvi.SubItems[4].Text;
                txtb_luong.Text = lvi.SubItems[5].Text;
                txtb_phucap.Text = lvi.SubItems[6].Text;
                txtb_masothue.Text = lvi.SubItems[7].Text;
                cbB_phongban.SelectedValue = lvi.SubItems[8].Text;
            }
            //string MaNv = lvi.SubItems[0].Text.Trim();
            //ShowDetail(MaNv);

        }

        private void ShowDetail(string MaNv)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "proc_detailNhanVien";

            SqlParameter parMaNv = new SqlParameter("@MaNv", SqlDbType.VarChar);
            parMaNv.Value = MaNv;
            sqlCmd.Parameters.Add(parMaNv);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            txtb_manv.Text = txtb_hoten.Text = cbB_gioitinh.Text = dt_ngaysinh.Text = txtb_sdt.Text = txtb_luong.Text = txtb_phucap.Text = txtb_masothue.Text = cbB_phongban.Text = "";
            if (reader.Read())
            {
                string Hoten = reader.GetString(1);
                string Gioitinh = reader.GetString(2);
                DateTime Ngaysinh = reader.GetDateTime(3);
                string Sdt = reader.GetString(4);
                decimal Luong = reader.GetDecimal(5);
                decimal Phucap = reader.GetDecimal(6);
                string MaSt = reader.GetString(7);
                string Mapb = reader.GetString(8);

                txtb_manv.Text = MaNv;
                txtb_hoten.Text = Hoten;
                cbB_gioitinh.Text = Gioitinh;
                dt_ngaysinh.Text = Ngaysinh.ToString();
                txtb_sdt.Text = Sdt;
                txtb_luong.Text = Luong.ToString();
                txtb_phucap.Text = Phucap.ToString();
                txtb_masothue.Text = MaSt;
                cbB_phongban.Text = Mapb.ToString();
            }
            reader.Close();
        }

        private void Combobox_list()
        {
            DataTable dt = new DataTable();
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Phongban", sqlCon);
                da.Fill(dt);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbB_phongban.DataSource = dt;
                cbB_phongban.DisplayMember = "TenPhongBan";
                cbB_phongban.ValueMember = "MaPhongBan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            txtb_manv.Enabled = true;
        }
        void WriteLog()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd_log = new SqlCommand("update EmployeeLog set EmployeeID='" + MaNv + "' where LogID=(SELECT MAX(LogID) FROM EmployeeLog)", sqlCon);
            cmd_log.ExecuteNonQuery();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            frmLog log = new frmLog(conString);
            log.ShowDialog();
            log.Hide();
        }

        private void cbB_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtb_manv.Enabled = false;
            if (txtb_manv.Enabled == false)
            {

                int role = CheckPhanQuyen(MaNv);
                switch (role)
                {
                    case 1: // Nhân viên phòng nhân sự
                        lst_ds.Items.Clear();
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        SqlCommand cmd = new SqlCommand("SELECT MaNv,Hoten, Gioitinh , Ngaysinh, Sdt, Masothue, Maphongban FROM NHANVIEN where Maphongban = " + cbB_phongban.SelectedIndex + "", sqlCon);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string MaNv = reader.GetString(0);
                            string Hoten = reader.GetString(1);
                            string Gioitinh = reader.GetString(2);
                            DateTime Ngaysinh = reader.GetDateTime(3);
                            string Sdt = reader.GetString(4);
                            string Masothue = reader.GetString(5);
                            int Maphongban = reader.GetInt32(6);

                            ListViewItem lvi = new ListViewItem(MaNv);
                            lvi.SubItems.Add(Hoten);
                            lvi.SubItems.Add(Gioitinh);
                            lvi.SubItems.Add(Ngaysinh.ToString("dd/MM/yyyy"));
                            lvi.SubItems.Add(Sdt);
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(Masothue);
                            lvi.SubItems.Add(Maphongban.ToString());

                            lst_ds.Items.Add(lvi);
                        }

                        reader.Close();
                        break;
                    case 2: //Nhân viên tài vụ
                        lst_ds.Items.Clear();
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }

                        if (cbB_phongban.SelectedIndex == 2)
                        {
                            SqlCommand sqlCmd = new SqlCommand();
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.CommandText = "proc_SelectAccDepart";
                            sqlCmd.Parameters.AddWithValue("@Mapb", cbB_phongban.SelectedIndex);
                            sqlCmd.Connection = sqlCon;
                            SqlDataReader reader1 = sqlCmd.ExecuteReader();
                            lst_ds.Items.Clear();
                            while (reader1.Read())
                            {
                                string MaNv = reader1.GetString(0);
                                string Hoten = reader1.GetString(1);
                                string Gioitinh = reader1.GetString(2);
                                DateTime Ngaysinh = reader1.GetDateTime(3);
                                string Sdt = reader1.GetString(4);
                                int luong = reader1.GetInt32(5);
                                int phucap = reader1.GetInt32(6);
                                string Masothue = reader1.GetString(7);
                                int Maphongban = reader1.GetInt32(8);

                                ListViewItem lvi = new ListViewItem(MaNv);
                                lvi.SubItems.Add(MaNv);
                                lvi.SubItems.Add(Hoten);
                                lvi.SubItems.Add(Gioitinh);
                                lvi.SubItems.Add(Sdt);
                                lvi.SubItems.Add(luong.ToString());
                                lvi.SubItems.Add(phucap.ToString());
                                lvi.SubItems.Add(Masothue);
                                lvi.SubItems.Add(Maphongban.ToString());

                                lst_ds.Items.Add(lvi);

                            }
                            reader1.Close();
                        }
                        else
                        {
                            SqlCommand sqlCmd = new SqlCommand();
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.CommandText = "proc_SelectAccDepart";
                            sqlCmd.Parameters.AddWithValue("@Mapb", cbB_phongban.SelectedIndex);
                            sqlCmd.Connection = sqlCon;
                            SqlDataReader reader1 = sqlCmd.ExecuteReader();
                            lst_ds.Items.Clear();
                            while (reader1.Read())
                            {
                                string MaNv = reader1.GetString(0);
                                string Hoten = reader1.GetString(1);
                                string Gioitinh = reader1.GetString(2);
                                DateTime Ngaysinh = reader1.GetDateTime(3);
                                string Sdt = reader1.GetString(4);
                                int luong = reader1.GetInt32(5);
                                int phucap = reader1.GetInt32(6);
                                string Masothue = reader1.GetString(7);
                                int Maphongban = reader1.GetInt32(8);

                                ListViewItem lvi = new ListViewItem(MaNv);
                                lvi.SubItems.Add("");
                                lvi.SubItems.Add("");
                                lvi.SubItems.Add("");
                                lvi.SubItems.Add("");
                                lvi.SubItems.Add(luong.ToString());
                                lvi.SubItems.Add(phucap.ToString());
                                lvi.SubItems.Add(Masothue);
                                lvi.SubItems.Add(Maphongban.ToString());

                                lst_ds.Items.Add(lvi);

                            }
                            reader1.Close();
                        }
                        break;
                    case 3:
                        cbB_phongban.Visible = false;
                        break;
                    case 0: //Giám đốc
                        lst_ds.Items.Clear();
                        if (sqlCon == null)
                        {
                            sqlCon = new SqlConnection(conString);
                        }
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        SqlCommand sqlCmd1 = new SqlCommand();
                        sqlCmd1.CommandType = CommandType.StoredProcedure;
                        sqlCmd1.CommandText = "proc_SelectAccDepart";
                        sqlCmd1.Parameters.AddWithValue("@Mapb", cbB_phongban.SelectedIndex);

                        sqlCmd1.Connection = sqlCon;
                        SqlDataReader reader2 = sqlCmd1.ExecuteReader();
                        lst_ds.Items.Clear();
                        while (reader2.Read())
                        {
                            string MaNv = reader2.GetString(0);
                            string Hoten = reader2.GetString(1);
                            string Gioitinh = reader2.GetString(2);
                            DateTime Ngaysinh = reader2.GetDateTime(3);
                            string Sdt = reader2.GetString(4);
                            int luong = reader2.GetInt32(5);
                            int phucap = reader2.GetInt32(6);
                            string Masothue = reader2.GetString(7);
                            int Maphongban = reader2.GetInt32(8);

                            ListViewItem lvi = new ListViewItem(MaNv);
                            lvi.SubItems.Add(Hoten);
                            lvi.SubItems.Add(Gioitinh);
                            lvi.SubItems.Add(Ngaysinh.ToString("dd/MM/yyyy"));
                            lvi.SubItems.Add(Sdt);
                            lvi.SubItems.Add(luong.ToString());
                            lvi.SubItems.Add(phucap.ToString());
                            lvi.SubItems.Add(Masothue);
                            lvi.SubItems.Add(Maphongban.ToString());

                            lst_ds.Items.Add(lvi);
                        }
                        reader2.Close();
                        break;
                    default:
                        cbB_phongban.Visible = true;
                        break;
                }

            }
        }
        private void frmQuanLyNhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
