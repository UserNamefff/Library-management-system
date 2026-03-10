using LibraryDB_BusinessLayer;
using LMS.Book;
using LMS.Borrowing;
using LMS.Fines;
using LMS.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Reservation
{
    public partial class frmReservationBook : Form
    {
        clsReservation reservation ;

        
        public frmReservationBook()
        {
            InitializeComponent();
        }

        private void ctrlMemberInfoWithFillter1_dlGetMemberID(int obj)
        {
            if (obj <= 0)
            {
                return;
            }

            if (clsFine.HasMemberUnpaidFine(ctrlMemberInfoWithFillter1.SelectedMember.MemberID))
            {
                MessageBox.Show("this member cann't reserving books ,\n because He has an unpaid fine.\n  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (MessageBox.Show("Do you want pay fine ?  ", "question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    clsFine Fine = clsFine.FindByMemberIDThatDontPayFine(ctrlMemberInfoWithFillter1.SelectedMember.MemberID);
                    Fine.PaymentStatus = true;

                    frmPayFine frm = new frmPayFine(Fine);
                    frm.ShowDialog();

                    if (!clsFine.HasMemberUnpaidFine(ctrlMemberInfoWithFillter1.SelectedMember.MemberID))
                    {
                        btnNext.Enabled = true;
                    }

                    return;
                }


                return;
            }
            
            btnNext.Enabled = true;


        }

        private void ctrlBookCardWithFillter1_OnBookSelected(int obj)
        {
            if (obj <= 0)
            {
                return;
            }

            if (ctrlBookCardWithFillter1.SelectedBookInfo.AvalaibleCopy != null)
            {
                if(MessageBox.Show("Cann't reservation , because there are bookcopies .","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmBorrowingBook frm = new frmBorrowingBook();
                                    frm .ShowDialog();

                    this.Close();
                }
                

                return;
            }

            if (clsReservation.IsBookReservated(ctrlBookCardWithFillter1.SelectedBookInfo.BookID, ctrlMemberInfoWithFillter1.SelectedMember.MemberID))
            {
                MessageBox.Show("Cann't reservation this book  , because you are already reserved ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                 btnReservation.Enabled = true;
                reservation = new clsReservation();

                //if (MessageBox.Show("Cannt reservation this book , because it's avalible \n,Do you want borrowing this book ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    clsBorrowingRecord borrowing = new clsBorrowingRecord();
                //    borrowing.CopyID = ctrlBookCardWithFillter1.SelectedBookInfo.AvalaibleCopy.CopyID;
                //    borrowing.DueDate = DateTime.Now.AddDays(clsSetting.FindBySettingID(clsGlobal.SettingID).DefualtBorrrowDays);
                //    borrowing.BorrowingDate = DateTime.Now;
                //    borrowing.CreatedByID = clsGlobal.UserID;
                //    borrowing.MemberID = ctrlMemberInfoWithFillter1.SelectedMember.MemberID;

                //    if (borrowing.Save())
                //    {
                //        MessageBox.Show(" Borrowing book successfully ... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        return;
                //    }

                //}
            }

            //if(clsReservation.IsCopyReservated())

            
            
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            

            reservation.ReservationDate = DateTime.Now;
            reservation.CreatedBy = clsGlobal.UserID;
            reservation.BookID = ctrlBookCardWithFillter1.SelectedBookInfo.BookID;
            reservation.MemberID = ctrlMemberInfoWithFillter1.SelectedMember.MemberID;
            reservation.Status = (short)clsReservation.enStatus.Reserved;

            if (reservation.Save())
            {
                MessageBox.Show(" Reserved book successfully ... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Faild reservation this book ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnReservation.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ddd.SelectTab(1);
        }

        private void frmReservationBook_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnReservation.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
