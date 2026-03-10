using System;
using System.Data;
using LibraryDB_Business;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsBorrowingRecord
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BorrowingRecordID { set; get; }
        public int MemberID { set; get; }
        public int CopyID { set; get; }
        public DateTime BorrowingDate { set; get; }
        public DateTime DueDate { set; get; }
        public DateTime ActualReturnDate  { set; get; }
        public int CreatedByID { set; get; }
        public clsMember _MemberInfo;
        public clsMember MemberInfo {  get { return _MemberInfo; } }

         clsCopy _CopyBookInfo;

        public clsCopy CopyBookInfo { get { return _CopyBookInfo; } }
        public clsUser UserInfo { get { return clsUser.FindByUserID(CreatedByID); } }

        public clsBorrowingRecord()
        {
            this.BorrowingRecordID = -1;
            this.MemberID = -1;
            this.CopyID = -1;
            this.BorrowingDate = DateTime.MinValue;
            this.DueDate = DateTime.MinValue;
            this.ActualReturnDate = DateTime.MinValue;;
            this.CreatedByID = -1;
            Mode = enMode.AddNew;
        }



        private clsBorrowingRecord(int BorrowingRecordID, int MemberID, int CopyID, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate , int CreatedByID)
        {
            this.BorrowingRecordID = BorrowingRecordID;
            this.MemberID = MemberID;
            this.CopyID = CopyID;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            this.CreatedByID = CreatedByID;
            Mode = enMode.Update;

            _CopyBookInfo = clsCopy.FindByCopyID(CopyID);
            _MemberInfo = clsMember.FindByMemberID(MemberID);
            

        }
        private bool _AddNewBorrowingRecord()
        {
            this.BorrowingRecordID = (int)clsBorrowingRecordData.AddNewBorrowingRecord(this.MemberID, this.CopyID, this.BorrowingDate, this.DueDate, this.ActualReturnDate, this.CreatedByID);
            return (this.BorrowingRecordID != -1);
        }
        private bool _UpdateBorrowingRecord()
        {
            return clsBorrowingRecordData.UpdateBorrowingRecord(this.BorrowingRecordID, this.MemberID, this.CopyID, this.BorrowingDate, this.DueDate, this.ActualReturnDate, this.CreatedByID);
        }
        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.DeleteBorrowingRecord(BorrowingRecordID);
        }
        public static clsBorrowingRecord FindByBorrowingRecordID(int BorrowingRecordID)
        {
            int MemberID = -1;
            int CopyID = -1;
            DateTime BorrowingDate = DateTime.MinValue;
            DateTime DueDate = DateTime.MinValue;
            DateTime ActualReturnDate  = DateTime.MinValue; ;
            int CreatedByID = -1;

            bool IsFound = clsBorrowingRecordData.GetBorrowingRecordByBorrowingRecordID(BorrowingRecordID, ref MemberID, ref CopyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate, ref CreatedByID);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, MemberID, CopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByID);
            else
                return null;
        }
        public static clsBorrowingRecord FindByMemberID(int MemberID)
        {
            int BorrowingRecordID = -1;
            int CopyID = -1;
            DateTime BorrowingDate = DateTime.MinValue;
            DateTime DueDate = DateTime.MinValue;
            DateTime ActualReturnDate  = DateTime.MinValue;
            int CreatedByID = -1;

            bool IsFound = clsBorrowingRecordData.GetBorrowingRecordByMemberID(ref BorrowingRecordID, MemberID, ref CopyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate, ref CreatedByID);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, MemberID, CopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingRecord())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBorrowingRecord();
            }
            return false;
        }
        public static bool HasMemberActiveBorrowingForBook(int BookID,int MemberID)
        {
            return clsBorrowingRecordData.IsBookAlreadyBorrowedByMemberAndDoesNotReturned(BookID,MemberID);
        }
        public static DataTable GetBorrowingRecords()
        {
            return clsBorrowingRecordData.GetAllBorrowingRecords();
        }

        public bool PayFine(bool PaymentStatus, string Notes,float FineAmount,int UserID)
        {

            clsFine Fine = new clsFine();
            Fine.MemberID = this.MemberID;
            Fine.BorrowingRecordID = this.BorrowingRecordID;
            Fine.PaymentStatus = PaymentStatus;
            TimeSpan DifferentDate = DateTime.Now-this.DueDate;
            Fine.NumberOfLateDays = (short)DifferentDate.Days;
            Fine.CreatedByID = UserID;
            Fine.FineAmount = FineAmount;
            
            if (!Fine.Save())
            {
                return false;
            }
            this.ActualReturnDate = DateTime.Now;

            return this.Save() && this.CopyBookInfo.UpdateBookCopyStatus();
        }

         
        public static  bool IsReturnedBook(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.IsReturnedBook(BorrowingRecordID);
        }
            
    }
}
