using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            Mode = enMode.AddNew;
        }
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }
        private bool _AddNewCountry()
        {
            this.CountryID = (int)clsCountryData.AddNewCountry(this.CountryName);
            return (this.CountryID != -1);
        }
        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.CountryID, this.CountryName);
        }
        public static bool DeleteCountry(int CountryID)
        {
            return clsCountryData.DeleteCountry(CountryID);
        }
        public static bool IsCountryExistByCountryID(int CountryID)
        {
            return clsCountryData.IsCountryExistByCountryID(CountryID);
        }
        public static bool IsCountryExistByCountryName(string CountryName)
        {
            return clsCountryData.IsCountryExistByCountryName(CountryName);
        }
        public static clsCountry FindByCountryID(int CountryID)
        {
            string CountryName = "";

            bool IsFound = clsCountryData.GetCountryByCountryID(CountryID, ref CountryName);

            if (IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
        public static clsCountry FindByCountryName(string CountryName)
        {
            int CountryID = -1;

            bool IsFound = clsCountryData.GetCountryByCountryName(ref CountryID, CountryName);

            if (IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }
        public static DataTable GetCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
