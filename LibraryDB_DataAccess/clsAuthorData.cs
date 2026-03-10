

using System.Data;
using System.Data.SqlClient;
using System;


namespace LibraryDB_DataAccess
{
    public class clsAuthorData
    {
        public static bool GetAuthorByID(int AuthorID, ref string AuthorName, ref int CountryID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Authors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["AuthorName"] != DBNull.Value)
                                    AuthorName = (string)reader["AuthorName"];
                                else
                                    AuthorName = "";

                                CountryID = (int)reader["CountryID"];
                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetAuthorByAuthorID(int AuthorID, ref string AuthorName, ref int CountryID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Authors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["AuthorName"] != DBNull.Value)
                                    AuthorName = (string)reader["AuthorName"];
                                else
                                    AuthorName = "";

                                CountryID = (int)reader["CountryID"];
                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetAuthorByAuthorName(ref int AuthorID, string AuthorName, ref int CountryID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Authors WHERE AuthorName = @AuthorName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                AuthorID = (int)reader["AuthorID"];
                                CountryID = (int)reader["CountryID"];
                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool GetAuthorByCountryID(ref int AuthorID, ref string AuthorName, int CountryID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Authors WHERE CountryID = @CountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                AuthorID = (int)reader["AuthorID"];

                                if (reader["AuthorName"] != DBNull.Value)
                                    AuthorName = (string)reader["AuthorName"];
                                else
                                    AuthorName = "";

                            }
                            else
                            {
                                isFound = false;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static int AddNewAuthor(string AuthorName, int CountryID)
        {
            int AuthorID = -1;
            string query = @"INSERT INTO Authors (AuthorName, CountryID)
                            VALUES (@AuthorName, @CountryID)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        if (AuthorName != "")
                            command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        else
                            command.Parameters.AddWithValue("@AuthorName", DBNull.Value);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            AuthorID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return AuthorID;
        }
        public static bool UpdateAuthor(int AuthorID, string AuthorName, int CountryID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Authors  
                                        SET 
                                        AuthorName = @AuthorName, 
                            CountryID = @CountryID
                            WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {

            }

            return (rowsAffected > 0);
        }
        public static bool DeleteAuthor(int AuthorID)
        {
            int rowsAffected = 0;
            string query = @"Delete Authors 
                                where AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
            return (rowsAffected > 0);
        }
        public static bool IsAuthorExist(int AuthorID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Authors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsAuthorExistByAuthorID(int AuthorID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Authors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", AuthorID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsAuthorExistByAuthorName(string AuthorName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Authors WHERE AuthorName = @AuthorName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorName", AuthorName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static bool IsAuthorExistByCountryID(int CountryID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Authors WHERE CountryID = @CountryID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }

            return isFound;
        }
        public static DataTable GetAllAuthors()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Authors";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return dt;
        }
    }
}
