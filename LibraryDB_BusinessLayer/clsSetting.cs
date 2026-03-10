using LibraryDB_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB_BusinessLayer
{

    public class clsSetting
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int SettingID { set; get; }
        public byte DefualtBorrrowDays { set; get; }
        public decimal DefaultFinePerDay { set; get; }

        public clsSetting()
        {
            this.SettingID = -1;
            this.DefualtBorrrowDays = 0;
            this.DefaultFinePerDay = -1;
            Mode = enMode.AddNew;
        }
        private clsSetting(int SettingID, byte DefualtBorrrowDays, decimal DefaultFinePerDay)
        {
            this.SettingID = SettingID;
            this.DefualtBorrrowDays = DefualtBorrrowDays;
            this.DefaultFinePerDay = DefaultFinePerDay;
            Mode = enMode.Update;
        }
        private bool _AddNewSetting()
        {
            this.SettingID = (int)clsSettingData.AddNewSetting(this.DefualtBorrrowDays, this.DefaultFinePerDay);
            return (this.SettingID != -1);
        }
        private bool _UpdateSetting()
        {
            return clsSettingData.UpdateSetting(this.SettingID, this.DefualtBorrrowDays, this.DefaultFinePerDay);
        }
        public static bool DeleteSetting(int SettingID)
        {
            return clsSettingData.DeleteSetting(SettingID);
        }
        public static bool IsSettingExistBySettingID(int SettingID)
        {
            return clsSettingData.IsSettingExistBySettingID(SettingID);
        }
        public static bool IsSettingExistByDefualtBorrrowDays(byte DefualtBorrrowDays)
        {
            return clsSettingData.IsSettingExistByDefualtBorrrowDays(DefualtBorrrowDays);
        }
        public static bool IsSettingExistByDefaultFinePerDay(decimal DefaultFinePerDay)
        {
            return clsSettingData.IsSettingExistByDefaultFinePerDay(DefaultFinePerDay);
        }
        public static clsSetting FindBySettingID(int SettingID)
        {
            byte DefualtBorrrowDays = 0;
            decimal DefaultFinePerDay = -1;

            bool IsFound = clsSettingData.GetSettingBySettingID(SettingID, ref DefualtBorrrowDays, ref DefaultFinePerDay);

            if (IsFound)
                return new clsSetting(SettingID, DefualtBorrrowDays, DefaultFinePerDay);
            else
                return null;
        }
        public static clsSetting FindByDefualtBorrrowDays(byte DefualtBorrrowDays)
        {
            int SettingID = -1;
            decimal DefaultFinePerDay = -1;

            bool IsFound = clsSettingData.GetSettingByDefualtBorrrowDays(ref SettingID, DefualtBorrrowDays, ref DefaultFinePerDay);

            if (IsFound)
                return new clsSetting(SettingID, DefualtBorrrowDays, DefaultFinePerDay);
            else
                return null;
        }
        public static clsSetting FindByDefaultFinePerDay(decimal DefaultFinePerDay)
        {
            int SettingID = -1;
            byte DefualtBorrrowDays = 0;

            bool IsFound = clsSettingData.GetSettingByDefaultFinePerDay(ref SettingID, ref DefualtBorrrowDays, DefaultFinePerDay);

            if (IsFound)
                return new clsSetting(SettingID, DefualtBorrrowDays, DefaultFinePerDay);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSetting())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSetting();
            }
            return false;
        }
        public static DataTable GetSettings()
        {
            return clsSettingData.GetAllSettings();
        }
    }
}

