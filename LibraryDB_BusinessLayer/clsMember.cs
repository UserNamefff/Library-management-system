using System;
using System.Data;
using System.Runtime.Versioning;
using LibraryDB_Business;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsMember
    {
        
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int MemberID { set; get; }
        public int PersonID { set; get; }
        public DateTime JoinDate { set; get; }
        public DateTime ExpiredDateMembership { set; get; }
        public bool IsActive { set; get; }
        public int CreatedBy { set; get; }

        public clsPerson PersonInfo { get; }
        public clsUser UserInfo { get; }
        public clsMember()
        {
            this.MemberID = -1;
            this.PersonID = -1;
            this.JoinDate = DateTime.MinValue;
            this.ExpiredDateMembership = DateTime.MinValue;
            this.IsActive = false;
            this.CreatedBy = -1;
            Mode = enMode.AddNew;
        }
        private clsMember(int MemberID, int PersonID, DateTime JoinDate, DateTime ExpiredDateMembership, bool IsActive, int CreatedBy)
        {
            this.MemberID = MemberID;
            this.PersonID = PersonID;
            this.JoinDate = JoinDate;
            this.ExpiredDateMembership = ExpiredDateMembership;
            this.IsActive = IsActive;
            this.CreatedBy = CreatedBy;
            Mode = enMode.Update;
            
            PersonInfo = clsPerson.FindByPersonID(this.PersonID);
            UserInfo = clsUser.FindByUserID(this.CreatedBy);

        }
        private bool _AddNewMember()
        {
            this.MemberID = (int)clsMemberData.AddNewMember(this.PersonID, this.JoinDate, this.ExpiredDateMembership, this.IsActive, this.CreatedBy);
            return (this.MemberID != -1);
        }
        private bool _UpdateMember()
        {
            return clsMemberData.UpdateMember(this.MemberID, this.PersonID, this.JoinDate, this.ExpiredDateMembership, this.IsActive, this.CreatedBy);
        }
        public static bool DeleteMember(int MemberID)
        {
            return clsMemberData.DeleteMember(MemberID);
        }
        public static bool IsMemberExistByMemberID(int MemberID)
        {
            return clsMemberData.IsMemberExistByMemberID(MemberID);
        }
        public static bool IsMemberExistByPersonID(int PersonID)
        {
            return clsMemberData.IsMemberExistByPersonID(PersonID);
        }

        public static bool IsMemberExistByIsActive(bool IsActive)
        {
            return clsMemberData.IsMemberExistByIsActive(IsActive);
        }
        public static bool IsMemberExistByCreatedBy(int CreatedBy)
        {
            return clsMemberData.IsMemberExistByCreatedBy(CreatedBy);
        }
        public static clsMember FindByMemberID(int MemberID)
        {
            int PersonID = -1;
            DateTime JoinDate = DateTime.MinValue;
            DateTime ExpiredDateMembership = DateTime.MinValue;
            bool IsActive = false;
            int CreatedBy = -1;

            bool IsFound = clsMemberData.GetMemberByMemberID(MemberID, ref PersonID, ref JoinDate, ref ExpiredDateMembership, ref IsActive, ref CreatedBy);

            if (IsFound)
                return new clsMember(MemberID, PersonID, JoinDate, ExpiredDateMembership, IsActive, CreatedBy);
            else
                return null;
        }
        public static clsMember FindByPersonID(int PersonID)
        {
            int MemberID = -1;
            DateTime JoinDate = DateTime.MinValue;
            DateTime ExpiredDateMembership = DateTime.MinValue;
            bool IsActive = false;
            int CreatedBy = -1;

            bool IsFound = clsMemberData.GetMemberByPersonID(ref MemberID, PersonID, ref JoinDate, ref ExpiredDateMembership, ref IsActive, ref CreatedBy);

            if (IsFound)
                return new clsMember(MemberID, PersonID, JoinDate, ExpiredDateMembership, IsActive, CreatedBy);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateMember();
            }
            return false;
        }
        public static bool IsMembershipExpired(int MemberID)
        {
            return false;
            //return clsSubscription.IsMembershipExpired();
        }

        public bool IsMembershipExpired()
        {
            return false;
            //return clsMember.IsMembershipExpired(this.MemberID);
        }
        public bool DoesThisMemberHaveAFine
        {
            get { return clsMemberData .DoesThisMemberHaveAFine(MemberID); }
        }
        public static DataTable GetMembers()
        {
            return clsMemberData.GetAllMembers();
        }
    }
}
