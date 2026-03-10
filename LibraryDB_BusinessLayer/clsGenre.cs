using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{

        public class clsGenre
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enMode Mode = enMode.AddNew;
            public int GenreID { set; get; }
            public string GenreName { set; get; }
            public string Description { set; get; }

            public clsGenre()
            {
                this.GenreID = -1;
                this.GenreName = "";
                this.Description = "";
                Mode = enMode.AddNew;
            }
            private clsGenre(int GenreID, string GenreName, string Description)
            {
                this.GenreID = GenreID;
                this.GenreName = GenreName;
                this.Description = Description;
                Mode = enMode.Update;
            }
            private bool _AddNewGenre()
            {
                this.GenreID = (int)clsGenreData.AddNewGenre(this.GenreName, this.Description);
                return (this.GenreID != -1);
            }
            private bool _UpdateGenre()
            {
                return clsGenreData.UpdateGenre(this.GenreID, this.GenreName, this.Description);
            }
            public static bool DeleteGenre(int GenreID)
            {
                return clsGenreData.DeleteGenre(GenreID);
            }
            public static bool IsGenreExistByGenreID(int GenreID)
            {
                return clsGenreData.IsGenreExistByGenreID(GenreID);
            }
            public static bool IsGenreExistByGenreName(string GenreName)
            {
                return clsGenreData.IsGenreExistByGenreName(GenreName);
            }
            public static bool IsGenreExistByDescription(string Description)
            {
                return clsGenreData.IsGenreExistByDescription(Description);
            }
            public static clsGenre FindByGenreID(int GenreID)
            {
                string GenreName = "";
                string Description = "";

                bool IsFound = clsGenreData.GetGenreByGenreID(GenreID, ref GenreName, ref Description);

                if (IsFound)
                    return new clsGenre(GenreID, GenreName, Description);
                else
                    return null;
            }
            public static clsGenre FindByGenreName(string GenreName)
            {
                int GenreID = -1;
                string Description = "";

                bool IsFound = clsGenreData.GetGenreByGenreName(ref GenreID, GenreName, ref Description);

                if (IsFound)
                    return new clsGenre(GenreID, GenreName, Description);
                else
                    return null;
            }
            public static clsGenre FindByDescription(string Description)
            {
                int GenreID = -1;
                string GenreName = "";

                bool IsFound = clsGenreData.GetGenreByDescription(ref GenreID, ref GenreName, Description);

                if (IsFound)
                    return new clsGenre(GenreID, GenreName, Description);
                else
                    return null;
            }
            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewGenre())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdateGenre();
                }
                return false;
            }
            public static DataTable GetGenres()
            {
                return clsGenreData.GetAllGenres();
            }
        }
    }
