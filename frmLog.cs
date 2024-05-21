using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmLog : Form
    {
        public string conString = "";
        SqlConnection sqlCon = null;
        public frmLog(string conectionString)
        {
            InitializeComponent();
            conString = conectionString;
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(conString);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter cmd_log = new SqlDataAdapter("select * from Employeelog", sqlCon);
            DataTable dt = new DataTable();
            cmd_log.Fill(dt);
            dgv_log.DataSource = dt;
        }

        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
