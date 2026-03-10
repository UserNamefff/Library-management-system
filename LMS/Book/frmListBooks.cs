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

namespace LMS.Book
{
    public partial class frmListBooks : Form
    {
        public frmListBooks()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            dgvListBooks.DataSource = clsBook.GetBooks();

            if (dgvListBooks.Rows.Count > 0)
            {
                dgvListBooks.Columns[0].Name = "Book ID ";
                dgvListBooks.Columns[0].Width = 100;

            }
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBooks frm = new frmAddBooks();
            frm.ShowDialog();
            _Refresh();
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvListBooks.CurrentRow.Cells[0].Value;

            frmShowBookDetails frm = new frmShowBookDetails(ID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddBooks frm = new frmAddBooks();
            frm.ShowDialog();
            _Refresh();
        }
    }
}
