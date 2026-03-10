using LMS.Book;
using LMS.Borrowing;
using LMS.Fines;
using LMS.Members;
using LMS.Reservation;
using LMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BorrowingBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm .ShowDialog();
        }

        private void manageFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListManageFines frm = new frmListManageFines();
            frm .ShowDialog();

        }

        private void MembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMembers frm = new frmListMembers();  
            frm .ShowDialog();
        }

        private void borrowingBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListBorrowing frm = new frmListBorrowing();
            frm.ShowDialog();
        }

        private void reservationBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReservations frm = new frmListReservations();
            frm.ShowDialog();
        }
    }
}
