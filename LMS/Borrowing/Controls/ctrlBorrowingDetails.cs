using LibraryDB_BusinessLayer;
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

namespace LMS.Borrowing.Controls
{
    public partial class ctrlBorrowingDetails : UserControl
    {
        clsBorrowingRecord borrowingRecord;
        public clsBorrowingRecord SelectedBorrowingInfo { get { return borrowingRecord; } }
        public ctrlBorrowingDetails()
        {
            InitializeComponent();
        }

        public void LoadBorrowingData(int BorrowingID)
        {
             borrowingRecord = clsBorrowingRecord.FindByBorrowingRecordID(BorrowingID);

            if (borrowingRecord != null)
            {
                lblActualReturnDate.Text = clsFormat.DateToShort(borrowingRecord.ActualReturnDate);
                lblBookID.Text = borrowingRecord.CopyBookInfo.BookID.ToString();
                lblBookName.Text = borrowingRecord.CopyBookInfo.BookInfo.Title;
                lblBorrowingDate.Text = clsFormat.DateToShort(borrowingRecord.BorrowingDate);
                lblDueDate.Text =       clsFormat.DateToShort(borrowingRecord.DueDate);
                lblFineAmount.Text = "0";
                lblUserName.Text = borrowingRecord.UserInfo.UserName;
                lblMemberName.Text = borrowingRecord.MemberInfo.PersonInfo.FullName;
                lblBorrowingID.Text = borrowingRecord.BorrowingRecordID.ToString();
            }


        }
        public void LoadBorrowingData(clsBorrowingRecord BorrowingData)
        {
             borrowingRecord = BorrowingData;

            if (borrowingRecord != null)
            {
                lblActualReturnDate.Text = clsFormat.DateToShort(borrowingRecord.ActualReturnDate);
                lblBookID.Text = borrowingRecord.CopyBookInfo.BookID.ToString();
                lblBookName.Text = borrowingRecord.CopyBookInfo.BookInfo.Title;
                lblBorrowingDate.Text = clsFormat.DateToShort(borrowingRecord.BorrowingDate);
                lblDueDate.Text =       clsFormat.DateToShort(borrowingRecord.DueDate);
                lblFineAmount.Text = "0";
                lblUserName.Text = borrowingRecord.UserInfo.UserName;
                lblMemberName.Text = borrowingRecord.MemberInfo.PersonInfo.FullName;
                lblBorrowingID.Text = borrowingRecord.BorrowingRecordID.ToString();
            }


        }


    }

}
