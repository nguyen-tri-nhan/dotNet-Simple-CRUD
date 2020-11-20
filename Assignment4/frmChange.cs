using DTO_Ass4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
            EmployeeDTO dto = FrmLoginBUS.Instance.Forwarding;
            txtUsername.Text = dto.Id;
            txtPassword.Text = dto.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtUsername.Text;
            string password = txtPassword.Text;
            string newpass = txtNewPass.Text;
            string renew = txtReNewPass.Text;
            if (!newpass.Equals(renew))
            {
                MessageBox.Show("New password and renew password is not match");
            }
            else
            {
                bool check = FrmChangeBUS.Instance.ChangePass(id, newpass);
                if (check)
                {
                    MessageBox.Show("Update successfully, you now have permission to login");
                } else
                {
                    MessageBox.Show("Something went wrong, please contact your admin");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNewPass.Text = "";
            txtReNewPass.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
