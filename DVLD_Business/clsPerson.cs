using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data.People;

namespace DVLD_Business.People
{

    public class clsPerson
    {

        public enum enMode { add, update }

        public int Id { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int NationalityCountryId { get; set; }
        public enMode Mode; 

        public clsPerson() {
            Id = -1;
            NationalNumber = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = false;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            ImagePath = string.Empty;
            NationalityCountryId = 0;
            Mode = enMode.add;
        }

        private clsPerson(int id, string nationalNumber, string firstName, string secondName, string thirdName, string lastName,
                 DateTime dateOfBirth, bool gender, string address, string phoneNumber, string email, string imagePath,
                 int nationalityCountryId)
        {
            Id = id;
            NationalNumber = nationalNumber;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            ImagePath = imagePath;
            NationalityCountryId = nationalityCountryId;
            Mode = enMode.update;
        }

        public static DataTable getPeople(out int numberOfRows) {
            return clsPersonData.getPeople(out numberOfRows);
        }

        public static bool deletePerson(int personId) {
            return clsPersonData.deletePerson(personId);
        }


        public static bool IsPersonExistByNO(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

        public static clsPerson getPersonById(int personId)
        {
            string nationalNumber = string.Empty, firstName = string.Empty, secondName = string.Empty, thirdName = string.Empty, lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            bool gender = true;
            string address = string.Empty;
            string phoneNumber = string.Empty;
            string email = string.Empty;
            string imagePath = string.Empty;
            int nationalityCountryId = 0;

            bool isFound = clsPersonData.getPersonById(personId, ref nationalNumber, ref firstName, ref secondName, ref thirdName, ref lastName,
               ref dateOfBirth, ref gender, ref address, ref phoneNumber, ref nationalityCountryId, ref email, ref imagePath);

            if (isFound)
            {
                return new clsPerson(personId, nationalNumber,
                     firstName, secondName, thirdName, lastName, dateOfBirth, gender, address, phoneNumber, email, imagePath, nationalityCountryId);
            }
            else {
                return null;
            }
        }

        private int _addNewPerson(string NationalNo, string FirstName, string SecondName, string ThiredName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath) {
            return clsPersonData.AddNewPerson(
                    NationalNo, FirstName, SecondName, ThiredName, LastName, DateOfBirth, Gender, Address, Phone, Email,NationalityCountryID,ImagePath  
                );
        }

        private bool _updatePerson() { 
            throw new NotImplementedException();
        }

        public void save() {
            switch (Mode) {
                case enMode.add:
                    this.Id = _addNewPerson(this.NationalNumber , this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,  this.Gender , this.Address , this.PhoneNumber , this.Email , this.NationalityCountryId , this.ImagePath);
                    Mode = enMode.update;
                    break;
                case enMode.update:
                    _updatePerson();
                    break;
            }
        }
    }
}
