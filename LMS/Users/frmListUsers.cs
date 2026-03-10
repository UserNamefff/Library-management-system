using LibraryDB_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Users
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            dgvUsers.DataSource = clsUser.GetUsers();

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _Refresh();

        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        int GetUserID()
        {

            if(dgvUsers.Rows.Count == 0) 
                return 0;
            else
               return (int)dgvUsers.CurrentRow.Cells[0].Value;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddUpdateUser frm = new frmAddUpdateUser(GetUserID());
            frm.ShowDialog();
            _Refresh();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _Refresh();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser(GetUserID()))
            {
                MessageBox.Show("Deleted User successfully .","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("You can not Delete User ,because he's an active .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(GetUserID());

            frm.ShowDialog();
        }
    }
}
