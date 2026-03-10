using System;
using System.Data;
using LibraryDB_DataAccess;

namespace LibraryDB_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get {  return FirstName +' ' + SecondName+' ' + ThirdName+' '+ LastName; }
        }
        public clsCountry CountryInfo { get { return clsCountry.FindByCountryID(NationalityCountryID); } }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            this.PersonID = (int)clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static bool IsPersonExistByPersonID(int PersonID)
        {
            return clsPersonData.IsPersonExistByPersonID(PersonID);
        }
        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            return clsPersonData.IsPersonExistByNationalNo(NationalNo);
        }
        public static bool IsPersonExistByFirstName(string FirstName)
        {
            return clsPersonData.IsPersonExistByFirstName(FirstName);
        }
        public static bool IsPersonExistBySecondName(string SecondName)
        {
            return clsPersonData.IsPersonExistBySecondName(SecondName);
        }
        public static bool IsPersonExistByThirdName(string ThirdName)
        {
            return clsPersonData.IsPersonExistByThirdName(ThirdName);
        }
        public static bool IsPersonExistByLastName(string LastName)
        {
            return clsPersonData.IsPersonExistByLastName(LastName);
        }
        public static bool IsPersonExistByDateOfBirth(DateTime DateOfBirth)
        {
            return clsPersonData.IsPersonExistByDateOfBirth(DateOfBirth);
        }
        public static bool IsPersonExistByGendor(byte Gendor)
        {
            return clsPersonData.IsPersonExistByGendor(Gendor);
        }
        public static bool IsPersonExistByAddress(string Address)
        {
            return clsPersonData.IsPersonExistByAddress(Address);
        }
        public static bool IsPersonExistByPhone(string Phone)
        {
            return clsPersonData.IsPersonExistByPhone(Phone);
        }
        public static bool IsPersonExistByEmail(string Email)
        {
            return clsPersonData.IsPersonExistByEmail(Email);
        }
        public static bool IsPersonExistByNationalityCountryID(int NationalityCountryID)
        {
            return clsPersonData.IsPersonExistByNationalityCountryID(NationalityCountryID);
        }
        public static bool IsPersonExistByImagePath(string ImagePath)
        {
            return clsPersonData.IsPersonExistByImagePath(ImagePath);
        }
        public static clsPerson FindByPersonID(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByPersonID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByNationalNo(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByFirstName(string FirstName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByFirstName(ref PersonID, ref NationalNo, FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindBySecondName(string SecondName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonBySecondName(ref PersonID, ref NationalNo, ref FirstName, SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByThirdName(string ThirdName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByThirdName(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByLastName(string LastName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByLastName(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByDateOfBirth(DateTime DateOfBirth)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByDateOfBirth(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByGendor(byte Gendor)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByGendor(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByAddress(string Address)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByAddress(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByPhone(string Phone)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByPhone(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByEmail(string Email)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByEmail(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByNationalityCountryID(int NationalityCountryID)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";

            bool IsFound = clsPersonData.GetPersonByNationalityCountryID(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByImagePath(string ImagePath)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;

            bool IsFound = clsPersonData.GetPersonByImagePath(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ImagePath);

            if (IsFound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static DataTable GetPeople()
        {
            return clsPersonData.GetAllPeople();
        }


    }
}
