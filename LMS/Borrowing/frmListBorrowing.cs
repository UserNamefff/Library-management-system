using LibraryDB_BusinessLayer;
using LMS.Borrowing.Controls;
using LMS.Fines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Borrowing
{
    public partial class frmListBorrowing : Form
    {
        BindingSource bindingSource = new BindingSource();
        DataTable dt;
        public frmListBorrowing()
        {
            InitializeComponent();
        }
        void _Refresh()
        {
            DataTable dt = clsBorrowingRecord.GetBorrowingRecords();
            bindingSource.DataSource = dt;
            dgvListBorrowings.DataSource = bindingSource;
            lblBooksNo.Text = dgvListBorrowings.RowCount.ToString();

            if(dgvListBorrowings.RowCount > 0)
            {
                  

                dgvListBorrowings.Columns[0].HeaderText = "Borrowing ID";
                dgvListBorrowings.Columns[0].Width = 100;

                dgvListBorrowings.Columns[1].HeaderText = "Member ID";
                dgvListBorrowings.Columns[1].Width = 100;


                dgvListBorrowings.Columns[2].HeaderText = "Copy ID";
                dgvListBorrowings.Columns[2].Width = 100;

                dgvListBorrowings.Columns[3].HeaderText = "Book Name";
                dgvListBorrowings.Columns[3].Width = 190;


                dgvListBorrowings.Columns[4].HeaderText = "Member Name";
                dgvListBorrowings.Columns[4].Width = 270;

                dgvListBorrowings.Columns[5].HeaderText = "Brw Date";
                dgvListBorrowings.Columns[5].Width = 100;

                dgvListBorrowings.Columns[6].HeaderText = "Due Date";
                dgvListBorrowings.Columns[6].Width = 100;

                dgvListBorrowings.Columns[7].HeaderText = "Actual Return Date";
                dgvListBorrowings.Columns[7].Width = 160;

                dgvListBorrowings.Columns[8].HeaderText = "User Name";
                dgvListBorrowings.Columns[8].Width = 120;

            }

        }
        private void frmListBorrowing_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBorrowingBook book = new frmBorrowingBook();
            book.ShowDialog();
            _Refresh();
        }

        private void cmbGenreBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbGenreBook.Text.Trim()) 
            {
                case "Borrowed":
                    bindingSource.Filter = "ActualReturnDate IS NULL";
                    break;
                case "returned":
                    bindingSource.Filter = "ActualReturnDate IS NOT NULL";
                break;
                    default:
                        bindingSource.RemoveFilter();
                    break;
            }
        }

        private void ShowBorrowingDetails_Click(object sender, EventArgs e)
        {
            int borrowingID = (int)dgvListBorrowings.CurrentRow.Cells[0].Value ;
            frmBorrowingDetails frm = new frmBorrowingDetails(borrowingID);
            frm.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int borrowingID = (int)dgvListBorrowings.CurrentRow.Cells[0].Value ;

            if (clsBorrowingRecord.IsReturnedBook(borrowingID))
            {
                MessageBox.Show("Book is already returned ...","Warring",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            clsBorrowingRecord _Borrowing = clsBorrowingRecord.FindByBorrowingRecordID(borrowingID);

            //Compare DueDate and Date now , to check if member Late to return book or no , ...
            // if Late --> we calculate Fines 
            int LateDays = DateTime.Compare(_Borrowing.DueDate, DateTime.Now);

            //change ActualReturnDate when members return the books
            _Borrowing.ActualReturnDate = DateTime.Now;

            if (_Borrowing.Save())
            {
                // Update copy status to avalible 
                _Borrowing.CopyBookInfo.UpdateBookCopyStatus();

                //refresh List 
                _Refresh();
                MessageBox.Show("Return borrowed bookcopy successfully ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            
            if (LateDays < 0)
            {
                if(MessageBox.Show("You have to pay a fine , because you were Late in returning the book ,\n Do you want Pay it now ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                        frmPayFine frm = new frmPayFine(_Borrowing);

                            frm.ShowDialog();
                }
                
            }

            //_Refresh();

        }

        private void BorrowingBook_Click(object sender, EventArgs e)
        {
            frmBorrowingBook book = new frmBorrowingBook();
            book.ShowDialog();
            _Refresh();
        }



    }
}
