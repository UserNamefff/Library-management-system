using LibraryDB_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Members
{
    public partial class frmListMembers : Form
    {
        BindingSource bindingSource = new BindingSource();
        public frmListMembers()
        {
            InitializeComponent();
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        void _Refresh()
        {
            DataTable dt = clsMember.GetMembers();
            bindingSource.DataSource = dt;
            dgvListMembers.DataSource = bindingSource;
        }
        private void btnAddReservations_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frmAdd = new frmAddUpdateMember();   
            frmAdd.ShowDialog();
            _Refresh();
        }

        private void ShowFineDetails_Click(object sender, EventArgs e)
        {
            int memberID = (int)dgvListMembers.CurrentRow.Cells[0].Value;

           frmShowMemberDetails frm = new frmShowMemberDetails(memberID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
