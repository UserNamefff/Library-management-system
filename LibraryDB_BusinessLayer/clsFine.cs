using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsFine
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int FineID { set; get; }
        public int MemberID { set; get; }
        public int BorrowingRecordID { set; get; }
        public short NumberOfLateDays { set; get; }
        public float FineAmount { set; get; }
        public bool PaymentStatus { set; get; }
        public int CreatedByID { set; get; }

        public clsBorrowingRecord BorrowingData {  get { return _BorrowingData; } }
        
         clsBorrowingRecord _BorrowingData;
        public clsFine()
        {
            this.FineID = -1;
            this.MemberID = -1;
            this.BorrowingRecordID = -1;
            this.NumberOfLateDays = -1;
            this.FineAmount = -1;
            this.PaymentStatus = false;
            this.CreatedByID = -1;
            Mode = enMode.AddNew;
        }
        private clsFine(int FineID, int MemberID, int BorrowingRecordID, short NumberOfLateDays, float FineAmount, bool PaymentStatus, int CreatedByID)
        {
            this.FineID = FineID;
            this.MemberID = MemberID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;
            this.CreatedByID = CreatedByID;

            this._BorrowingData = clsBorrowingRecord.FindByBorrowingRecordID(BorrowingRecordID);

            Mode = enMode.Update;
        }
        private bool _AddNewFine()
        {
            this.FineID = (int)clsFineData.AddNewFine(this.MemberID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus, this.CreatedByID);
            return (this.FineID != -1);
        }
        private bool _UpdateFine()
        {
            return clsFineData.UpdateFine(this.FineID, this.MemberID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus, this.CreatedByID);
        }
        public static bool DeleteFine(int FineID)
        {
            return clsFineData.DeleteFine(FineID);
        }
        public static bool IsFineExistByFineID(int FineID)
        {
            return clsFineData.IsFineExistByFineID(FineID);
        }
        public static bool HasMemberUnpaidFine(int MemberID)
        {
            return clsFineData.HasMemberUnpaidFine(MemberID);
        }
        public static clsFine FindByFineID(int FineID)
        {
            int MemberID = -1;
            int BorrowingRecordID = -1;
            short NumberOfLateDays = -1;
            float FineAmount = -1;
            bool PaymentStatus = false;
            int CreatedByID = -1;

            bool IsFound = clsFineData.GetFineByFineID(FineID, ref MemberID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedByID);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByID);
            else
                return null;
        }
        public static clsFine FindByMemberID(int MemberID)
        {
            int FineID = -1;
            int BorrowingRecordID = -1;
            short NumberOfLateDays = -1;
            float FineAmount = -1;
            bool PaymentStatus = false;
            int CreatedByID = -1;

            bool IsFound = clsFineData.GetFineByMemberID(ref FineID, MemberID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedByID);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByID);
            else
                return null;
        }
        public static clsFine FindByMemberIDThatDontPayFine(int MemberID)
        {
            int FineID = -1;
            int BorrowingRecordID = -1;
            short NumberOfLateDays = -1;
            float FineAmount = -1;
            bool PaymentStatus = false;
            int CreatedByID = -1;

            bool IsFound = clsFineData.GetFineByMemberIDThatDontPayFine(ref FineID, MemberID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedByID);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByID);
            else
                return null;
        }
        public static clsFine FindByBorrowingRecordID(int BorrowingRecordID)
        {
            int FineID = -1;
            int MemberID = -1;
            short NumberOfLateDays = -1;
            float FineAmount = -1;
            bool PaymentStatus = false;
            int CreatedByID = -1;

            bool IsFound = clsFineData.GetFineByBorrowingRecordID(ref FineID, ref MemberID, BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedByID);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFine())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateFine();
            }
            return false;
        }
        public static DataTable GetFines()
        {
            return clsFineData.GetAllFines();
        }
    }
}
