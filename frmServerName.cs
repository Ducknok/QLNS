using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmServerName : Form
    {
        public frmServerName()
        {
            InitializeComponent();
        }

        private void btn_truyenserver_Click(object sender, EventArgs e)
        {
            if(txtbtb_servername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Server Name");
            }
            else
            {
                this.Hide();
                frmDangnhap frm = new frmDangnhap(txtbtb_servername.Text);
                frm.ShowDialog();
                this.Close();
            }
            
        }
    }
}
