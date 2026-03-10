using System;
using System.Data;
using LibraryDB_DataAccess;
using LMSLibrary_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsReservation
    {
        public enum enStatus { Reserved = 1 , Canceled = 2 ,Expired = 3 , Completed = 4 };

        public enStatus eStatus = enStatus.Reserved;
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ReservationID { set; get; }
        public int MemberID { set; get; }
        public int BookID { set; get; }
        public DateTime ReservationDate { set; get; }
        public short Status { set; get; }
        public int CreatedBy { set; get; }

        public clsReservation()
        {
            this.ReservationID = -1;
            this.MemberID = -1;
            this.BookID = -1;
            this.ReservationDate = DateTime.MinValue;
            this.Status = (short)enStatus.Reserved;
            this.CreatedBy = -1;
            Mode = enMode.AddNew;
        }
        private clsReservation(int ReservationID, int MemberID, int BookID, DateTime ReservationDate, short Status, int CreatedBy)
        {
            this.ReservationID = ReservationID;
            this.MemberID = MemberID;
            this.BookID = BookID;
            this.ReservationDate = ReservationDate;
            this.Status = Status;
            this.CreatedBy = CreatedBy;
            Mode = enMode.Update;
        }
        private bool _AddNewReservation()
        {
            this.ReservationID = (int)clsReservationData.AddNewReservation(this.MemberID, this.BookID, this.ReservationDate, this.Status, this.CreatedBy);
            return (this.ReservationID != -1);
        }
        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(this.ReservationID, this.MemberID, this.BookID, this.ReservationDate, this.Status, this.CreatedBy);
        }
        public static bool DeleteReservation(int ReservationID)
        {
            return clsReservationData.DeleteReservation(ReservationID);
        }
        public static bool IsReservationExistByReservationID(int ReservationID)
        {
            return clsReservationData.IsReservationExistByReservationID(ReservationID);
        }
        public static bool IsReservationExistByMemberID(int MemberID)
        {
            return clsReservationData.IsReservationExistByMemberID(MemberID);
        }
        public static bool IsReservationExistByBookID(int BookID)
        {
            return clsReservationData.IsReservationExistByBookID(BookID);
        }
       
        public static bool IsBookReservated(int BookID)
        {
            return clsReservationData.IsCopyReservated(BookID);
        }
        public static bool IsBookReservated(int BookID,int MemberID)
        {
            return clsReservationData.IsBookReservated(BookID, MemberID);
        }

        public static bool IsReservationExistByReservationDate(DateTime ReservationDate)
        {
            return clsReservationData.IsReservationExistByReservationDate(ReservationDate);
        }
        public static bool IsReservationExistByStatus(short Status)
        {
            return clsReservationData.IsReservationExistByStatus(Status);
        }
        public static bool IsReservationExistByCreatedBy(int CreatedBy)
        {
            return clsReservationData.IsReservationExistByCreatedBy(CreatedBy);
        }
        public static clsReservation FindByReservationID(int ReservationID)
        {
            int MemberID = -1;
            int BookID = -1;
            DateTime ReservationDate = DateTime.MinValue;
            short Status = 0;
            int CreatedBy = -1;

            bool IsFound = clsReservationData.GetReservationByReservationID(ReservationID, ref MemberID, ref BookID, ref ReservationDate, ref Status, ref CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public static clsReservation FindByMemberID(int MemberID)
        {
            int ReservationID = -1;
            int BookID = -1;
            DateTime ReservationDate = DateTime.MinValue;
            short Status = 0;
            int CreatedBy = -1;

            bool IsFound = clsReservationData.GetReservationByMemberID(ref ReservationID, MemberID, ref BookID, ref ReservationDate, ref Status, ref CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public static clsReservation FindByBookID(int BookID)
        {
            int ReservationID = -1;
            int MemberID = -1;
            DateTime ReservationDate = DateTime.MinValue;
            short Status = 0;
            int CreatedBy = -1;

            bool IsFound = clsReservationData.GetReservationByBookID(ref ReservationID, ref MemberID, BookID, ref ReservationDate, ref Status, ref CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public static clsReservation FindByReservationDate(DateTime ReservationDate)
        {
            int ReservationID = -1;
            int MemberID = -1;
            int BookID = -1;
            short Status = 0;
            int CreatedBy = -1;

            bool IsFound = clsReservationData.GetReservationByReservationDate(ref ReservationID, ref MemberID, ref BookID, ReservationDate, ref Status, ref CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public static clsReservation FindByStatus(short Status)
        {
            int ReservationID = -1;
            int MemberID = -1;
            int BookID = -1;
            DateTime ReservationDate = DateTime.MinValue;
            int CreatedBy = -1;

            bool IsFound = clsReservationData.GetReservationByStatus(ref ReservationID, ref MemberID, ref BookID, ref ReservationDate, Status, ref CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public static clsReservation FindByCreatedBy(int CreatedBy)
        {
            int ReservationID = -1;
            int MemberID = -1;
            int BookID = -1;
            DateTime ReservationDate = DateTime.MinValue;
            short Status = 0;

            bool IsFound = clsReservationData.GetReservationByCreatedBy(ref ReservationID, ref MemberID, ref BookID, ref ReservationDate, ref Status, CreatedBy);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookID, ReservationDate, Status, CreatedBy);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateReservation();
            }
            return false;
        }
        public static DataTable GetReservations()
        {
            return clsReservationData.GetAllReservations();
        }
    }
}

