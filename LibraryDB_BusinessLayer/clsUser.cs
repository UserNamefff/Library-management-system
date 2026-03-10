using System;
using System.Data;
using LibraryDB_BusinessLayer;
using LibraryDB_DataAccess;

namespace LibraryDB_Business
{
    public class clsUser
    {
        public enum ePermisions { ManageUsers = 1 , ManageBorowing = 2,ManageMembers = 4, ManageBooks = 8,ManageCopies = 16,ManageSubscriptions = 32 , FullAccess = 63}
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public int Permisions { set; get; }
        clsPerson Person;
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.Permisions = -1;
            Mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, int Permisions)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permisions = Permisions;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = (int)clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive, this.Permisions);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive, this.Permisions);
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExistByUserID(int UserID)
        {
            return clsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }
        public static bool IsUserExistByUserName(string UserName)
        {
            return clsUserData.IsUserExistByUserName(UserName);
        }
        public static bool IsUserExistByPassword(string Password)
        {
            return clsUserData.IsUserExistByPassword(Password);
        }
        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;
            int Permisions = -1;

            bool IsFound = clsUserData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive, ref Permisions);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permisions);
            else
                return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;
            int Permisions = -1;

            bool IsFound = clsUserData.GetUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive, ref Permisions);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permisions);
            else
                return null;
        }
        public static clsUser FindByUserName(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            bool IsActive = false;
            int Permisions = -1;

            bool IsFound = clsUserData.GetUserByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive, ref Permisions);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, Permisions);
            else
                return null;
        }
        public static bool IsUserNameExists(string UserName)
        {
            return clsUserData.IsUserExistByUserName(UserName);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static DataTable GetUsers()
        {
            return clsUserData.GetAllUsers();
        }
    }
}
