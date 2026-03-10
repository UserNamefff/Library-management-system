
    using LibraryDB_DataAccess;
   
    using System;
    using System.Data;

namespace LibraryDB_BusinessLayer
{
        public class clsLanguage
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enMode Mode = enMode.AddNew;
            public int LanguageID { set; get; }
            public string LanguageName { set; get; }

            public clsLanguage()
            {
                this.LanguageID = -1;
                this.LanguageName = "";
                Mode = enMode.AddNew;
            }
            private clsLanguage(int LanguageID, string LanguageName)
            {
                this.LanguageID = LanguageID;
                this.LanguageName = LanguageName;
                Mode = enMode.Update;
            }
            private bool _AddNewLanguage()
            {
                this.LanguageID = (int)clsLanguageData.AddNewLanguage(this.LanguageName);
                return (this.LanguageID != -1);
            }
            private bool _UpdateLanguage()
            {
                return clsLanguageData.UpdateLanguage(this.LanguageID, this.LanguageName);
            }
            public static bool DeleteLanguage(int LanguageID)
            {
                return clsLanguageData.DeleteLanguage(LanguageID);
            }
            public static bool IsLanguageExistByLanguageID(int LanguageID)
            {
                return clsLanguageData.IsLanguageExistByLanguageID(LanguageID);
            }
            public static bool IsLanguageExistByLanguageName(string LanguageName)
            {
                return clsLanguageData.IsLanguageExistByLanguageName(LanguageName);
            }
            public static clsLanguage FindByLanguageID(int LanguageID)
            {
                string LanguageName = "";

                bool IsFound = clsLanguageData.GetLanguageByLanguageID(LanguageID, ref LanguageName);

                if (IsFound)
                    return new clsLanguage(LanguageID, LanguageName);
                else
                    return null;
            }
            public static clsLanguage FindByLanguageName(string LanguageName)
            {
                int LanguageID = -1;

                bool IsFound = clsLanguageData.GetLanguageByLanguageName(ref LanguageID, LanguageName);

                if (IsFound)
                    return new clsLanguage(LanguageID, LanguageName);
                else
                    return null;
            }
            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewLanguage())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdateLanguage();
                }
                return false;
            }
            public static DataTable GetLanguages()
            {
                return clsLanguageData.GetAllLanguages();
            }
        }
    }

