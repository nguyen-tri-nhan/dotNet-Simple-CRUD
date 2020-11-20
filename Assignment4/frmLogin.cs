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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String ID = txtEmpID.Text;
            String Password = txtPassword.Text;
            EmployeeDTO dto = FrmLoginBUS.Instance.CheckLogin(ID, Password);
            if (dto != null)
            {
                if (dto.Role)
                {
                    this.Hide();
                    frmMaintainBooks frm = new frmMaintainBooks();
                    frm.Show();
                }
                else
                {
                    this.Hide();
                    frmChange frm = new frmChange();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid ID or Password\nPlease Try Again");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
