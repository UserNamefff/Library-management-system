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

namespace LMS.Copies
{
    public partial class frmAddBookCopies : Form
    {

        clsCopy Copy;
        public frmAddBookCopies()
        {
            InitializeComponent();

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            Copy.IndexCopy = txtIndexOfCopy.Text.Trim();
            Copy.BookID = ctrlBookCardWithFillter1.SelectedBookInfo.BookID;
            Copy .AddDate = DateTime.Now;

           Copy. NumberOfCopies = Convert.ToInt32(txtNumberOfCopies.Value);
            if (Copy .Save())
            {
                MessageBox.Show("Copy added Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(" Failed to Add Copy .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtIndexOfCopy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIndexOfCopy.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtIndexOfCopy, "This Field is required .");
            }

            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtIndexOfCopy, null);
            }
        }

        private void ctrlBookCardWithFillter1_OnBookSelected(int obj)
        {
            if (obj == 0)
            {
                MessageBox.Show("Book does not exist .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Copy = new clsCopy();

            btnSave.Enabled = true;

        }


    }
}
