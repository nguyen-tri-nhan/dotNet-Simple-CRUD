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
    public partial class frmMaintainBooks : Form
    {
        DataTable dt;
        int currentRow;
        public frmMaintainBooks()
        {
            InitializeComponent();
            GetAll();
        }

        private void GetCurrentData(int currentRow)
        {
            txtID.Text = dgvBooks.Rows[currentRow].Cells[0].Value.ToString();
            txtName.Text = dgvBooks.Rows[currentRow].Cells[1].Value.ToString();
            txtPrice.Text = dgvBooks.Rows[currentRow].Cells[2].Value.ToString();
        }

        private void GetAll()
        {
            dt = FrmMainTainBookBUS.Instance.GetBook();
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dt, "BookID");
            txtName.DataBindings.Add("Text", dt, "BookName");
            txtPrice.DataBindings.Add("Text", dt, "BookPrice");
            dgvBooks.DataSource = dt;
            txtCount.Text =  "Sum: " + dt.Compute("COUNT(BookID)", string.Empty);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }


        private void frmMaintainBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string bookname = txtName.Text;
            float price = float.Parse(txtPrice.Text);
            bool check = FrmMainTainBookBUS.Instance.AddBook(bookname, price);
            if (check)
            {
                MessageBox.Show("Added Successfully");
            } else
            {
                MessageBox.Show("Added Failed");
            }
            GetAll();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filter = "BookName like '%" + txtFilter.Text + "%'";
            dv.RowFilter = filter;
            txtCount.Text = "Sum: " + dt.Compute("COUNT(BookName)", string.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string bookname = txtName.Text;
            float price = float.Parse(txtPrice.Text);
            bool check = FrmMainTainBookBUS.Instance.UpdateBook(id, bookname, price);
            if (check)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Updated Failed");
            }
            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            bool check = FrmMainTainBookBUS.Instance.DeleteBook(id);
            if (check)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Deleted Failed");
            }
            GetAll();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }

        private void btnFirstRow_Click(object sender, EventArgs e)
        {
            dgvBooks.ClearSelection();
            currentRow = 0;
            dgvBooks.Rows[currentRow].Selected = true;
            GetCurrentData(currentRow);

        }

        private void btnPreviousRow_Click(object sender, EventArgs e)
        {
            dgvBooks.ClearSelection();
            if (currentRow > 0)
            {
                currentRow--;
                dgvBooks.Rows[currentRow].Selected = true;
            }
            else
            {
                dgvBooks.Rows[0].Selected = true;
            }
            GetCurrentData(currentRow);

        }

        private void btnNextRow_Click(object sender, EventArgs e)
        {
            dgvBooks.ClearSelection();
            if (currentRow < dgvBooks.Rows.Count-2)
            {
                currentRow++;
                dgvBooks.Rows[currentRow].Selected = true;
            }
            else
            {
                currentRow = dgvBooks.Rows.Count-2;
                dgvBooks.Rows[currentRow].Selected = true;
            }
            GetCurrentData(currentRow);

        }

        private void btnLastRow_Click(object sender, EventArgs e)
        {
            dgvBooks.ClearSelection();
            currentRow = dgvBooks.Rows.Count-2;
            dgvBooks.Rows[currentRow].Selected = true;
            GetCurrentData(currentRow);

        }
    }
}
