using LibraryDB_BusinessLayer;
using LMS.Copies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmListCopies : Form
    {
        public frmListCopies()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBookCopies frm = new frmAddBookCopies();
            frm.ShowDialog();
            
            _Refresh();


        }

        private void frmListCopies_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        int CopyID()
        {
            
            return (int)dgvListBooks.CurrentRow.Cells[0].Value; ;
        }

        void _Refresh()
        {
            dgvListBooks.DataSource = clsCopy.GetBookCopies();

            lblBooksNo.Text = dgvListBooks.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListBooks.RowCount < 0)
                return;

            frmShowBookCopyDetails frm = new frmShowBookCopyDetails(CopyID());
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddBookCopies frm = new frmAddBookCopies();
            frm.ShowDialog();
            _Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrowing screen will be here ...");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Return book screen will be here ...");
        }
    }
}
