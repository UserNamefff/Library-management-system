using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsBook
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BookID { set; get; }
        public string Title { set; get; }
        public string ISBN { set; get; }
        public DateTime PublicationDate { set; get; }
        public int GenreID { set; get; }
        public string AdditionalDetails { set; get; }
        public int AuthorID { set; get; }
        public int LanguageID { set; get; }

        public clsCopy AvalaibleCopy { get { return clsCopy.GetAvaliableBookCopy(this.BookID); } }
        public clsBook()
        {
            this.BookID = -1;
            this.Title = "";
            this.ISBN = "";
            this.PublicationDate = DateTime.MinValue;
            this.GenreID = -1;
            this.AdditionalDetails = "";
            this.AuthorID = -1;
            this.LanguageID = -1;
            Mode = enMode.AddNew;
        }
        private clsBook(int BookID, string Title, string ISBN, DateTime PublicationDate, int GenreID, string AdditionalDetails, int AuthorID, int LanguageID)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.GenreID = GenreID;
            this.AdditionalDetails = AdditionalDetails;
            this.AuthorID = AuthorID;
            this.LanguageID = LanguageID;
            Mode = enMode.Update;
        }
        private bool _AddNewBook()
        {
            this.BookID = (int)clsBookData.AddNewBook(this.Title, this.ISBN, this.PublicationDate, this.GenreID, this.AdditionalDetails, this.AuthorID, this.LanguageID);
            return (this.BookID != -1);
        }
        private bool _UpdateBook()
        {
            return clsBookData.UpdateBook(this.BookID, this.Title, this.ISBN, this.PublicationDate, this.GenreID, this.AdditionalDetails, this.AuthorID, this.LanguageID);
        }
        public static bool DeleteBook(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }
        public static bool IsBookExistByBookID(int BookID)
        {
            return clsBookData.IsBookExistByBookID(BookID);
        }
        public static bool IsBookExistByTitle(string Title)
        {
            return clsBookData.IsBookExistByTitle(Title);
        }
        public static bool IsBookExistByISBN(string ISBN)
        {
            return clsBookData.IsBookExistByISBN(ISBN);
        }
        public static bool IsBookExistByPublicationDate(DateTime PublicationDate)
        {
            return clsBookData.IsBookExistByPublicationDate(PublicationDate);
        }
        public static bool IsBookExistByGenreID(int GenreID)
        {
            return clsBookData.IsBookExistByGenreID(GenreID);
        }
        public static bool IsBookExistByAdditionalDetails(string AdditionalDetails)
        {
            return clsBookData.IsBookExistByAdditionalDetails(AdditionalDetails);
        }
        public static bool IsBookExistByAuthorID(int AuthorID)
        {
            return clsBookData.IsBookExistByAuthorID(AuthorID);
        }
        public static bool IsBookExistByLanguageID(int LanguageID)
        {
            return clsBookData.IsBookExistByLanguageID(LanguageID);
        }
        public static clsBook FindByBookID(int BookID)
        {
            string Title = "";
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            string AdditionalDetails = "";
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByBookID(BookID, ref Title, ref ISBN, ref PublicationDate, ref GenreID, ref AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByTitle(string Title)
        {
            int BookID = -1;
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            string AdditionalDetails = "";
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByTitle(ref BookID, Title, ref ISBN, ref PublicationDate, ref GenreID, ref AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByISBN(string ISBN)
        {
            int BookID = -1;
            string Title = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            string AdditionalDetails = "";
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByISBN(ref BookID, ref Title, ISBN, ref PublicationDate, ref GenreID, ref AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByPublicationDate(DateTime PublicationDate)
        {
            int BookID = -1;
            string Title = "";
            string ISBN = "";
            int GenreID = -1;
            string AdditionalDetails = "";
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByPublicationDate(ref BookID, ref Title, ref ISBN, PublicationDate, ref GenreID, ref AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByGenreID(int GenreID)
        {
            int BookID = -1;
            string Title = "";
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            string AdditionalDetails = "";
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByGenreID(ref BookID, ref Title, ref ISBN, ref PublicationDate, GenreID, ref AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByAdditionalDetails(string AdditionalDetails)
        {
            int BookID = -1;
            string Title = "";
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            int AuthorID = -1;
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByAdditionalDetails(ref BookID, ref Title, ref ISBN, ref PublicationDate, ref GenreID, AdditionalDetails, ref AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByAuthorID(int AuthorID)
        {
            int BookID = -1;
            string Title = "";
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            string AdditionalDetails = "";
            int LanguageID = -1;

            bool IsFound = clsBookData.GetBookByAuthorID(ref BookID, ref Title, ref ISBN, ref PublicationDate, ref GenreID, ref AdditionalDetails, AuthorID, ref LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public static clsBook FindByLanguageID(int LanguageID)
        {
            int BookID = -1;
            string Title = "";
            string ISBN = "";
            DateTime PublicationDate = DateTime.MinValue;
            int GenreID = -1;
            string AdditionalDetails = "";
            int AuthorID = -1;

            bool IsFound = clsBookData.GetBookByLanguageID(ref BookID, ref Title, ref ISBN, ref PublicationDate, ref GenreID, ref AdditionalDetails, ref AuthorID, LanguageID);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBook();
            }
            return false;
        }
        public static DataTable GetBooks()
        {
            return clsBookData.GetAllBooks();
        }
        public  DataTable GetBookCopies()
        {
            return clsCopy.GetAllBookCopiesByBookID(this.BookID);
        }
    }
}

