using System;
using System.Data;
using LibraryDB_DataAccess;


    namespace LibraryDB_BusinessLayer
    {
        public class clsAuthor
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enMode Mode = enMode.AddNew;
            public int AuthorID { set; get; }
            public string AuthorName { set; get; }
            public int CountryID { set; get; }

            public clsAuthor()
            {
                this.AuthorID = -1;
                this.AuthorName = "";
                this.CountryID = -1;
                Mode = enMode.AddNew;
            }
            private clsAuthor(int AuthorID, string AuthorName, int CountryID)
            {
                this.AuthorID = AuthorID;
                this.AuthorName = AuthorName;
                this.CountryID = CountryID;
                Mode = enMode.Update;
            }
            private bool _AddNewAuthor()
            {
                this.AuthorID = (int)clsAuthorData.AddNewAuthor(this.AuthorName, this.CountryID);
                return (this.AuthorID != -1);
            }
            private bool _UpdateAuthor()
            {
                return clsAuthorData.UpdateAuthor(this.AuthorID, this.AuthorName, this.CountryID);
            }
            public static bool DeleteAuthor(int AuthorID)
            {
                return clsAuthorData.DeleteAuthor(AuthorID);
            }
            public static bool IsAuthorExistByAuthorID(int AuthorID)
            {
                return clsAuthorData.IsAuthorExistByAuthorID(AuthorID);
            }
            public static bool IsAuthorExistByAuthorName(string AuthorName)
            {
                return clsAuthorData.IsAuthorExistByAuthorName(AuthorName);
            }
            public static bool IsAuthorExistByCountryID(int CountryID)
            {
                return clsAuthorData.IsAuthorExistByCountryID(CountryID);
            }
            public static clsAuthor FindByAuthorID(int AuthorID)
            {
                string AuthorName = "";
                int CountryID = -1;

                bool IsFound = clsAuthorData.GetAuthorByAuthorID(AuthorID, ref AuthorName, ref CountryID);

                if (IsFound)
                    return new clsAuthor(AuthorID, AuthorName, CountryID);
                else
                    return null;
            }
            public static clsAuthor FindByAuthorName(string AuthorName)
            {
                int AuthorID = -1;
                int CountryID = -1;

                bool IsFound = clsAuthorData.GetAuthorByAuthorName(ref AuthorID, AuthorName, ref CountryID);

                if (IsFound)
                    return new clsAuthor(AuthorID, AuthorName, CountryID);
                else
                    return null;
            }
            public static clsAuthor FindByCountryID(int CountryID)
            {
                int AuthorID = -1;
                string AuthorName = "";

                bool IsFound = clsAuthorData.GetAuthorByCountryID(ref AuthorID, ref AuthorName, CountryID);

                if (IsFound)
                    return new clsAuthor(AuthorID, AuthorName, CountryID);
                else
                    return null;
            }
            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewAuthor())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdateAuthor();
                }
                return false;
            }
            public static DataTable GetAuthors()
            {
                return clsAuthorData.GetAllAuthors();
            }
        }
    }
