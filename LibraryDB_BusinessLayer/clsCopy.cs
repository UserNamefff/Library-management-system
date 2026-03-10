using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsCopy
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        
        //private clsBook _BookInfo;
        public clsBook BookInfo { get { return  clsBook.FindByBookID(BookID); } }
            
        public int CopyID { set; get; }
        public int BookID { set; get; }
        public bool AvailabilityStatus { set; get; }
        public string IndexCopy { set; get; }
        public int NumberOfCopies { set; get; }
        public DateTime AddDate { set; get; }
        public clsCopy()
        {
            this.CopyID = -1;
            this.BookID = -1;
            this.AvailabilityStatus = false;
            this.IndexCopy = "";
            this.AddDate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private clsCopy(int CopyID, int BookID, bool AvailabilityStatus, string IndexCopy, DateTime AddDate)
        {
            this.CopyID = CopyID;
            this.BookID = BookID;
            this.AvailabilityStatus = AvailabilityStatus;
            this.IndexCopy = IndexCopy;
            this.AddDate = AddDate;
            Mode = enMode.Update;
            
           ;

        }
        private bool _AddNewCopy()
        {
            this.CopyID = (int)clsCopyData.AddNewCopy(this.BookID, this.AvailabilityStatus, this.IndexCopy, this.AddDate,this.NumberOfCopies);
            return (this.CopyID != -1);
        }
        private bool _UpdateCopy()
        {
            return clsCopyData.UpdateCopy(this.CopyID, this.BookID, this.AvailabilityStatus, this.IndexCopy, this.AddDate);
        }
       
        public static bool DeleteCopy(int CopyID)
        {
            return clsCopyData.DeleteCopy(CopyID);
        }
        
        public static bool IsCopyExistByBookID(int BookID)
        {
            return clsCopyData.IsCopyExistByBookID(BookID);
        }

        public static bool IsCopyReserved(int CopyID)
        {
            return clsCopyData.IsCopyReserved(CopyID);
        }
        public static bool IsCopyAvaliable(int CopyID)
        {
            return clsCopyData.IsCopyAvaliable(CopyID);
        }
        public bool IsCopyReserved()
        {
            return clsCopy.IsCopyReserved(this.CopyID);
        }
        public bool IsCopyAvaliable()
        {
            return clsCopy.IsCopyAvaliable(this.CopyID);
        }


        public static clsCopy FindByCopyID(int CopyID)
        {
            int BookID = -1;
            bool AvailabilityStatus = false;
            string IndexCopy = "";
            DateTime AddDate = DateTime.MinValue;

            bool IsFound = clsCopyData.GetCopyByCopyID(CopyID, ref BookID, ref AvailabilityStatus, ref IndexCopy, ref AddDate);

            if (IsFound)
                return new clsCopy(CopyID, BookID, AvailabilityStatus, IndexCopy, AddDate);
            else
                return null;
        }
        public static clsCopy FindByBookID(int BookID)
        {
            int CopyID = -1;
            bool AvailabilityStatus = false;
            string IndexCopy = "";
            DateTime AddDate = DateTime.MinValue;

            bool IsFound = clsCopyData.GetCopyByBookID(ref CopyID, BookID, ref AvailabilityStatus, ref IndexCopy, ref AddDate);

            if (IsFound)
                return new clsCopy(CopyID, BookID, AvailabilityStatus, IndexCopy, AddDate);
            else
                return null;
        }

        public static clsCopy GetAvaliableBookCopy(int BookID)
        {
            int CopyID = -1;
            bool AvailabilityStatus = false;
            string IndexCopy = "";
            DateTime AddDate = DateTime.MinValue;

            bool IsFound = clsCopyData.GetAvailabileBookCopyByBookID(ref CopyID, BookID, ref AvailabilityStatus, ref IndexCopy, ref AddDate);

            if (IsFound)
                return new clsCopy(CopyID, BookID, AvailabilityStatus, IndexCopy, AddDate);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCopy())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCopy();
            }
            return false;
        }
        public static DataTable GetBookCopies()
        {
            return clsCopyData.GetAllBookCopies();
        }
        public static DataTable GetAllBookCopiesByBookID(int BookID)
        {
            return clsCopyData.GetAllBookCopiesByBookID(BookID);
        }


        public static bool UpdateBookCopy(int CopyID)
        {
            return clsCopyData.UpdateCopy(CopyID,false);

        } 
        public  bool UpdateBookCopyStatus()
        {
            return clsCopyData.UpdateCopy(this.CopyID,true);

        } 



        }
    }

