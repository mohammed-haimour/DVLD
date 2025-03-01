
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business.People;

namespace DVLD.People
{
    public partial class frmPeopleManagment : Form
    {
        public frmPeopleManagment()
        {
            InitializeComponent();
        }

        private int _numberOfPeople;
        private bool _isFilterOnlyNumeric;
        private DataTable _dtPeople = new DataTable();
        

        private void _refreshPeopleGrid()
        {
            _dtPeople = clsPerson.getPeople(out _numberOfPeople);
            gridPeople.DataSource = _dtPeople;
            lbNumberOfPeople.Text = $"#{_numberOfPeople.ToString()}";
        }

        private void frmPeopleManagment_Load(object sender, EventArgs e)
        {
            _refreshPeopleGrid();
            txtFilterValue.Visible = false;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = true;
            txtFilterValue.Text = "";

            if (comboBox1.Text == "PersonID")
            {
                _isFilterOnlyNumeric = true;
            }
            else
            {
                _isFilterOnlyNumeric = false;
            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_isFilterOnlyNumeric)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _dtPeople.DefaultView.RowFilter = string.Empty;
                gridPeople.DataSource = _dtPeople;
                return;
            }

            Type type = _dtPeople.Columns[comboBox1.Text].DataType;


            switch (type)
            {
                case Type _ when type == typeof(string):
                    _dtPeople.DefaultView.RowFilter = $"{comboBox1.Text} LIKE '%{txtFilterValue.Text}%'";
                    break;
                case Type _ when type == typeof(int):
                    _dtPeople.DefaultView.RowFilter = $"{comboBox1.Text} = {Convert.ToInt32(txtFilterValue.Text)}";
                    break;
                   
                    break;
                default:
                    MessageBox.Show("Unsupported data type for filtering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
        private void btnDeletePerson_Click_1(object sender, EventArgs e)
        {
            // Check if a cell is selected in the grid
            if (gridPeople.SelectedCells.Count > 0)
            {
                // Get the selected cell's row index
                int rowIndex = gridPeople.SelectedCells[0].RowIndex;

                // Get the PersonID from the selected row
                int personId = Convert.ToInt32(gridPeople.Rows[rowIndex].Cells["PersonID"].Value);

                string imagePath = clsPerson.getPersonImage(personId);

                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        if (File.Exists(imagePath))
                        {
                            File.Delete(imagePath); // Deletes the file
                            Console.WriteLine("Image deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while deleting the file: {ex.Message}");
                    }
                }


                // Attempt to delete the person
                bool isDeleted = clsPerson.deletePerson(personId);

                if (isDeleted)
                {
                    // Show success message
                    MessageBox.Show($"Person with ID {personId} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Show error message
                    MessageBox.Show("The person is linked to another person and cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the grid to reflect changes
                _refreshPeopleGrid();
            }
            else
            {
                // Show a message if no cell is selected
                MessageBox.Show("Please select a person to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            int rowIndex = gridPeople.SelectedCells[0].RowIndex;
            Form personDetailsForm = new frmPersonDetails((int)gridPeople.Rows[rowIndex].Cells["PersonID"].Value);
            personDetailsForm.ShowDialog();
            _refreshPeopleGrid();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form addPersonForm = new frmAddUpdatePerson();
            addPersonForm.ShowDialog();
            _refreshPeopleGrid();
        }
    }
}
