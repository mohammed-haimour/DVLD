using DVLD.Properties;
using DVLD_Business.Country;
using DVLD_Business.People;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            WireUpValidationEvents();
        }

        private void WireUpValidationEvents()
        {
            txtFirstName.Validating += txtFirstName_Validating;
            txtSecondName.Validating += txtSecondName_Validating;
            txtThirdName.Validating += txtThirdName_Validating;
            txtLastName.Validating += txtLastName_Validating;
            txtPhone.Validating += txtPhone_Validating;
            txtEmail.Validating += txtEmail_Validating;
            txtNationalNumber.Validating += txtNationalNumber_Validating;
        }

        private void fillFiledsWithPersonData(clsPerson person) {
            lbHeader.Text = "Update Person";
            pictureBox1.Image = Resources.Edit_User_32;
            lbID.Text = person.Id.ToString();
            txtFirstName.Text = person.FirstName;
            txtSecondName.Text = person.SecondName;
            txtThirdName.Text = person.ThirdName;
            txtLastName.Text = person.LastName;
            txtNationalNumber.Text = person.NationalNumber;
            comboCountry.SelectedValue = person.NationalityCountryId;
        
            txtPhone.Text = person.PhoneNumber;

            if (person.Gender == true)
            {
                rdFemale.Checked = true;
                rdMale.Checked = false;
            }
            else
            {
                rdFemale.Checked = false;
                rdMale.Checked = true;
            }


            dtBirth.Value = person.DateOfBirth;

            txtAddress.Text = person.Address??"";
            txtEmail.Text = person.Email??"";

            if (person.ImagePath != null)
            {
                picPerson.Image = Image.FromFile(person.ImagePath);
            }
        }

        void changeGendorDefaultImage()
        {
            if (string.IsNullOrEmpty(picPerson.Tag?.ToString())) // Check for null or empty
            {
                if (rdMale.Checked)
                {
                    picPerson.BackgroundImage = Resources.Male_5121; // Male image resource
                }
                else
                {
                    picPerson.BackgroundImage = Resources.Female_512; // Female image resource
                }
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            dtBirth.MaxDate = DateTime.Now.AddYears(-18).AddDays(-1);
            DataTable _dt = clsCountry.GetAllCountries();
            comboCountry.DataSource = _dt;
            comboCountry.DisplayMember = "CountryName";
            comboCountry.ValueMember = "CountryID";
            comboCountry.SelectedIndex = 89;
            rdMale.Checked = true;
            picPerson.BackgroundImage = Resources.Male_5121;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void SetErorrMessage(Control control, CancelEventArgs e, string message)
        {
            e.Cancel = true;
            epPerson.SetError(control, message);
        }

        private void RemoveErorrMessage(Control control, CancelEventArgs e)
        {
            e.Cancel = false;
            epPerson.SetError(control, "");
        }

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    linkImage.Text = "Edit Image";
                    linkRemove.Visible = true;
                    picPerson.BackgroundImage = Image.FromFile(filePath);
                    picPerson.Tag = filePath;
                }
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            changeGendorDefaultImage();
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            changeGendorDefaultImage();
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.Tag = "";
            changeGendorDefaultImage();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
                return;
            }

            if (IsValidEmail(txtEmail.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
            else
            {
                SetErorrMessage((TextBox)sender, e, "You should enter a valid Email");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                SetErorrMessage((TextBox)sender, e, "First Name can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
                SetErorrMessage((TextBox)sender, e, "Second Name can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
                SetErorrMessage((TextBox)sender, e, "Third Name can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
                SetErorrMessage((TextBox)sender, e, "Last Name can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                SetErorrMessage((TextBox)sender, e, "Phone number can't be blank");
                return;
            }

            if (IsValidPhoneNumber(txtPhone.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
            else
            {
                SetErorrMessage((TextBox)sender, e, "You should enter a valid Phone number");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNumber.Text))
            {
                SetErorrMessage((TextBox)sender, e, "Nationality Number is Required.");

            }
            else {

                if (clsPerson.IsPersonExistByNO(txtNationalNumber.Text))
                {
                    SetErorrMessage((TextBox)sender, e, "NO Number is used by another person");
                }
                else
                {
                    RemoveErorrMessage((TextBox)sender, e);
                }
            }
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPerson personToSave = new clsPerson();

            if (personToSave.Mode == clsPerson.enMode.add)
            {
                personToSave.FirstName = txtFirstName.Text;
                personToSave.SecondName = txtSecondName.Text;
                personToSave.ThirdName = txtThirdName.Text;
                personToSave.LastName = txtLastName.Text;
                personToSave.NationalNumber = txtNationalNumber.Text;
                personToSave.NationalityCountryId = (int)comboCountry.SelectedValue;
                personToSave.Address = txtAddress.Text;
                personToSave.Email = txtEmail.Text;
                personToSave.PhoneNumber = txtPhone.Text;
                personToSave.Gender = rdFemale.Checked;
                personToSave.DateOfBirth = dtBirth.Value;
                string newImagePath = null;
                if (!string.IsNullOrEmpty(picPerson.Tag?.ToString() ?? ""))
                {
                    newImagePath = cachImage(picPerson);
                    picPerson.Tag = newImagePath;
                    picPerson.BackgroundImage = Image.FromFile(newImagePath);

                }
                personToSave.ImagePath = newImagePath;

                personToSave.save();

                if (personToSave.Id == -1)
                {
                    MessageBox.Show("Error, Person Is Not Added Sucessfully");
                }
                else
                {
                    MessageBox.Show($"Successfully Done, Person Id Is {personToSave.Id}");
                    fillFiledsWithPersonData(personToSave);
                }
            }
            else
            {
                MessageBox.Show("Now You Are Gonna Update The Person");
                // delete the image and replace is the path in the picPerson.tag not equal the current person 
                // if not just don't do anything LOL
            }
        }


private string cachImage(PictureBox picPerson)
    {
        if (picPerson.Tag == null)
            throw new Exception("No image path found in Tag property.");

        string sourcePath = picPerson.Tag.ToString();
            string cacheFolder = Path.Combine(@"C:\DVLDCACH");

            // Ensure folder exists
            if (!Directory.Exists(cacheFolder))
        {
            Directory.CreateDirectory(cacheFolder);
        }

        // Generate a GUID filename
        string newFileName = $"{Guid.NewGuid()}{Path.GetExtension(sourcePath)}";
        string destinationPath = Path.Combine(cacheFolder, newFileName);

        // Copy the image
        File.Copy(sourcePath, destinationPath, true);


        return destinationPath;
    }

        private void frmAddUpdatePerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            picPerson.Dispose();
            pictureBox1.Dispose();
        }

        private void picPerson_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdatePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            picPerson.Dispose();
            pictureBox1.Dispose();
        }
    }
}
