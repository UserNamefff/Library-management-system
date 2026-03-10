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
    public partial class frmBorrowingDetails : Form
    {
        int BorrowingID;
        public frmBorrowingDetails(int  borrowingID)
        {
            InitializeComponent();
            this.BorrowingID = borrowingID;
        }

        private void frmBorrowingDetails_Load(object sender, EventArgs e)
        {
            ctrlBorrowingDetails1.LoadBorrowingData(BorrowingID);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
