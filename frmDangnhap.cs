using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNS
{
    public partial class frmDangnhap : Form
    {
        SqlConnection sqlcon = null;
        string serverNameCon = "";
        public frmDangnhap(string serverName)
        {
            InitializeComponent();
            serverNameCon = serverName;
        }
        // Xác minh đăng nhập và lấy vai trò của người dùng từ cơ sở dữ liệu
        private int GetUserRole(string username, string password)
        {
            int department = 0;
            int userRole = 0;
            string connectString = @"Data Source=" + serverNameCon + ";Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";
            using (SqlConnection sqlcon = new SqlConnection(connectString))
            {
                sqlcon.Open();

                using (SqlCommand command = new SqlCommand("ValidateUser", sqlcon))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        department = Int32.Parse(reader[0].ToString());
                        userRole = department;
                    }
                    else
                    {
                        return -1;
                    }
                    return userRole;
                    sqlcon.Close();
                }
            }

        }

        // Thay đổi connection string dựa trên vai trò của người dùng
        private string GetConnectionString(int userRole)
        {

            switch (userRole)
            {
                case 1:
                    return @"Server=" + serverNameCon + ";Database=QLNS;User Id=Lnhanvien_NS;Password=123456;MultipleActiveResultSets=True";
                case 3:
                    return @"Server=" + serverNameCon + ";Database=QLNS;User Id=Lnhanvien;Password=123456;MultipleActiveResultSets=True";
                case 2:
                    return @"Server=" + serverNameCon + ";Database=QLNS;User Id=Lnhanvien_TV;Password=123456;MultipleActiveResultSets=True";
                    //return @"Data Source=" + serverNameCon + ";Initial Catalog=QLNS;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True";
                case 0:
                    return @"Server=" + serverNameCon + ";Database=QLNS;User Id=Lgiamdoc;Password=123456;MultipleActiveResultSets=True";
                    //return @"Data Source=" + serverNameCon + ";Initial Catalog=QLNS;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True";
                case -1:
                    return "Error";
                default: return "Error";
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtb_tk.Text == "")
                {
                    MessageBox.Show("Tài khoản không được để trống!");
                    return;
                }
                else if (txtb_mk.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                }
                string username = txtb_tk.Text;
                string password = txtb_mk.Text;

                int userRole = GetUserRole(username, password);

                string connectionString = GetConnectionString(userRole);
                string loggedInUsername = "";
                if (connectionString == "Error")
                {
                    MessageBox.Show("Đã xảy ra lỗi: Tài khoản hoặc mật khẩu không hợp lệ");
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Thực hiện truy vấn để lấy thông tin người dùng hiện đang đăng nhập từ SQL Server
                        string query = "SELECT SESSION_USER";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            loggedInUsername = (string)command.ExecuteScalar();
                        }
                        connection.Close();

                    }

                    if (!string.IsNullOrEmpty(loggedInUsername))
                    {

                        MessageBox.Show("Đăng nhập thành công. Tên người dùng: " + loggedInUsername);
                        this.Hide();

                        frmQuanLyNhanSu frm = new frmQuanLyNhanSu(connectionString, username);
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin người dùng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: Tài khoản hoặc mật khẩu không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi server name!");
                this.Hide();
                frmServerName frm = new frmServerName();
                frm.ShowDialog();
            }
        }


        private void lbl_tk_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
