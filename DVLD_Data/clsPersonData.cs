using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data.People
{
    public class clsPersonData
    {

        public static DataTable getPeople(out int numberOfPeople) {
            DataTable dt = new DataTable();
            numberOfPeople = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_GetPeople", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                    
                        SqlParameter rowCountParam = new SqlParameter("@NumberOfRows", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(rowCountParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) { 
                           dt.Load(reader);
                            }
                        }

                        numberOfPeople = (int)cmd.Parameters["@NumberOfRows"].Value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return dt;
        }

        public static bool deletePerson(int personId)
        {
            int numberOfRowsEffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_DeletePerson", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter personIdToDeleteParam = new SqlParameter("@PersonIdToDelete", SqlDbType.Int)
                        {
                            Value = personId
                        };
                        cmd.Parameters.Add(personIdToDeleteParam);

                        numberOfRowsEffected = cmd.ExecuteNonQuery();

                        if (numberOfRowsEffected > 0)
                        {
                            return true ;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                catch (SqlException ex) {
                    if (ex.Number == 547) // Foreign key constraint violation error code
                    {
                      return  false;
                    }
                }
            

                return false;


            }
        }

        public static bool getPersonById(int personId,ref string  NationnalityNumber ,ref string FirstName, ref string SecondName, ref string ThiredName, ref string LastName, ref DateTime DateOfBirth, ref bool Gender, ref string Address, ref string Phone, ref int NationalityCountryId, ref string Email, ref string ImagePath)
        {
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_GetPersonById", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add the PersonId parameter
                        cmd.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int) { Value = personId });

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isSuccess = true; // Person found

                                // Fill out the properties from the reader
                                NationnalityNumber = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThiredName = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender =  Convert.ToBoolean(reader["Gendor"]);
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryId = (int)reader["NationalityCountryID"];

                                // Handle null values for Email and ImagePath
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return isSuccess;
        }

        public static string GetImagePathByPersonId(int personId)
        {
            string imagePath = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_GetPersonById", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add the PersonId parameter
                        cmd.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int) { Value = personId });

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handle null value for ImagePath
                                imagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return imagePath;
        }


        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;



            string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isFound = true;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isFound;
        }

        public static int AddNewPerson(
           string NationalNo,
           string FirstName,
           string SecondName,
           string ThirdName,
           string LastName,
           DateTime DateOfBirth,
           bool Gender,
           string Address,
           string Phone,
           string Email,
           int NationalityCountryID,
           string ImagePath)
        {
            // This function will return the new PersonID if succeeded, or -1 if not.
            int PersonID = -1;

            string query = @"
        INSERT INTO People
            (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
        VALUES
            (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
        SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender ? (byte)1 : (byte)0); // Mapping bool to tinyint
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            PersonID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle errors
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return PersonID;
        }


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThiredName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowAffected = -1;



            string query = "UPDATE People SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThiredName = @ThiredName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath   WHERE PersonID=@PersonID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettnigs.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //in code gen not out the conditiond!!
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThiredName", ThiredName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return rowAffected > 0;
        }

    }
}
