using LibraryDB_BusinessLayer;
using LMS.Fines;
using LMS.Global_Classes;
using LMS.Reservation;
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
    public partial class frmBorrowingBook : Form
    {
        int DefualtBorrrowDays = clsSetting.FindBySettingID(1).DefualtBorrrowDays;

        BindingSource bindingSource = new BindingSource();
        
        public frmBorrowingBook()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            bindingSource.DataSource = ctrlBookCardWithFillter1.SelectedBookInfo.GetBookCopies();
            dgvBookCopies.DataSource = bindingSource;
        }
        private void ctrlBookCardWithFillter1_OnBookSelected(int obj)
        {
            if (obj <= 0)
            {
               
                return;

            }

            if (ctrlBookCardWithFillter1.SelectedBookInfo.AvalaibleCopy == null )
            {
                if(MessageBox.Show("We donnt have avalible Bookopies for this book , Do you want reservation this book ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmReservationBook frm = new frmReservationBook();
                    frm.ShowDialog();

                    return;
                }
                return;
            }

            if (clsBorrowingRecord.HasMemberActiveBorrowingForBook(ctrlBookCardWithFillter1.SelectedBookInfo.BookID, ctrlMemberInfoWithFillter1.SelectedMember.MemberID))
            {
                MessageBox.Show("Error : This member cann't borrowing this book , \nbecause he has already borrowing to this book and don't returned "
                                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                return;
            }

            //Constrant 1 : Check if Copy was Reservated
            if (clsReservation.IsBookReservated(ctrlBookCardWithFillter1.SelectedBookInfo.BookID))
            {
                MessageBox.Show("This Book is already reserved ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            _Refresh();



            btnSave.Enabled = dgvBookCopies.RowCount > 0;

        }

        private void ctrlMemberInfoWithFillter1_dlGetMemberID(int obj)
        {
            btnNext.Enabled = obj > 0;

            if (obj <= 0)
            {
                
                return ;
            }
            //Later on
            //. Constrant 3 : Check if  Membership of member was Expired
            //if(ctrlMemberInfoWithFillter1.SelectedMember.IsMembershipExpired())
            //{
            //  MessageBox.Show("Subscription member is expired")
            //  return ;
            //}

            if (!ctrlMemberInfoWithFillter1.SelectedMember.IsActive)
            {

                return;
            }

            if (clsFine.HasMemberUnpaidFine(ctrlMemberInfoWithFillter1.SelectedMember.MemberID))
            {
                MessageBox.Show("this member cann't borrowing books ,\n because He has an unpaid fine. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (MessageBox.Show("Do you want pay fine now ? ", "question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    clsFine fine = clsFine.FindByMemberIDThatDontPayFine(ctrlMemberInfoWithFillter1.SelectedMember.MemberID);
                    frmPayFine frm = new frmPayFine(fine);
                    frm.ShowDialog();


                }
                return;
            }

            btnNext.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ddd.SelectTab(1);
            
        }

        private void frmBorrowingBook_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlBookCardWithFillter1.SelectedBookInfo == null || ctrlMemberInfoWithFillter1.SelectedMember == null)
            {
                return; 
            }

            int CopyID = _GetCopyID();


            
            //Constrant 2 : Check if Member Has Unpaid Fine
            
            if (!clsCopy.IsCopyAvaliable(CopyID))
            {
                MessageBox.Show("this Bookcopy is borrowing , choice another Bookcopy... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            clsBorrowingRecord borrowingRecord = new clsBorrowingRecord();

            borrowingRecord.CopyID = ctrlBookCardWithFillter1.SelectedBookInfo.AvalaibleCopy.CopyID;
            borrowingRecord.BorrowingDate = DateTime.Now;
            borrowingRecord.CreatedByID = clsGlobal.UserID;
            borrowingRecord.MemberID = ctrlMemberInfoWithFillter1.SelectedMember.MemberID;
            borrowingRecord.DueDate = DateTime.Now.AddDays(DefualtBorrrowDays);// dkdkd

           
            //this condation checking if you clicks on the borrowing button after save borrowing in database..... 
            //Chech if mode is update , to warning user if he wants update ..
            if(borrowingRecord.Mode == clsBorrowingRecord.enMode.Update)
            {
                if(MessageBox.Show(" do you want update Borrowing ?. ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
               
            }

            if (borrowingRecord.Save())
            {
                if (borrowingRecord.Mode == clsBorrowingRecord.enMode.Update)
                    clsCopy.UpdateBookCopy(CopyID);

                _Refresh();
                MessageBox.Show("Borrowing book successfully -:)- .. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btnSave.Enabled = false;

                return;
            }
            MessageBox.Show("Error : cann't save borrowing..  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;

        }

        int _GetCopyID()
        {
            if (dgvBookCopies.RowCount <= 0)
                return -1;
            else
                return (int)dgvBookCopies.CurrentRow.Cells[0].Value;
        }
        //Tab 
        private void ddd_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(ctrlMemberInfoWithFillter1.SelectedMember == null)
            {
                MessageBox.Show("Select a member ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void cmbLangBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBookID.Visible = false;
            switch (cmbLangBook.Text.Trim())
            {

                case "Avaliable":
                    bindingSource.Filter = "AvailabilityStatus =1 ";
                    break;

                case "Non avaliable":
                    bindingSource.Filter = "AvailabilityStatus = 0";
                    break;

                case "Copy ID":
                    txtBookID.Visible = true;
                    
                    break;

                default :
                    bindingSource.RemoveFilter();
                    break;

                   

            }


            

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookID.Text))
                return;

            if (txtBookID.Visible)
            {
                bindingSource.Filter = string.Format("CopyID = {0}", txtBookID.Text.Trim());
            }

        }



    }
}
