using DVLD.Properties;
using DVLD_Business.People;
using DVLD_Business.Country;
using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        static private clsPerson _person;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public  int personId;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This method is empty. If not needed, consider removing it.
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
       
        }

        private void ctrlPersonCard_Load_1(object sender, EventArgs e)
        {
            _person = clsPerson.getPersonById(personId);

        
        

            lbPersonID.Text = _person.Id.ToString();
            lbName.Text = string.Join(" ", _person.FirstName, _person.SecondName,_person.ThirdName, _person.LastName);
            lbAddrress.Text = _person.Address;
          
            //lbCountry.Text = clsCountry.Find(_person.NationalityCountryId).CountryName;
            lbCountry.Text = _person.NationalityCountryId.ToString();

            lbPhone.Text = _person.PhoneNumber;
            lbEmail.Text = _person.Email;
            lbGender.Text = _person.Gender ? "Female" : "Male";
            lbNO.Text = _person.NationalNumber;
            lbDataOfBirth.Text = _person.DateOfBirth.ToString("yyyy-MM-dd"); // Added a more readable date format

            if (!string.IsNullOrEmpty(_person.ImagePath))
                picPerson.BackgroundImage = Image.FromFile(_person.ImagePath);
            else
                picPerson.BackgroundImage = _person.Gender ? Resources.Female_512  : Resources.Male_5121;

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lbPersonID_Click(object sender, EventArgs e)
        {

        }

        private void picPerson_Click(object sender, EventArgs e)
        {

        }
    }
}
