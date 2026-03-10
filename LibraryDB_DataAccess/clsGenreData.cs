using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{

    public class clsGenreData
    {
        public static bool GetGenreByID(int GenreID, ref string GenreName, ref string Description)
        {
            bool isFound = false;
            string query = "SELECT * FROM Genres WHERE GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", GenreID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                GenreName = (string)reader["GenreName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

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
        public static bool GetGenreByGenreID(int GenreID, ref string GenreName, ref string Description)
        {
            bool isFound = false;
            string query = "SELECT * FROM Genres WHERE GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", GenreID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                GenreName = (string)reader["GenreName"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

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
        public static bool GetGenreByGenreName(ref int GenreID, string GenreName, ref string Description)
        {
            bool isFound = false;
            string query = "SELECT * FROM Genres WHERE GenreName = @GenreName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreName", GenreName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                GenreID = (int)reader["GenreID"];

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";

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
        public static bool GetGenreByDescription(ref int GenreID, ref string GenreName, string Description)
        {
            bool isFound = false;
            string query = "SELECT * FROM Genres WHERE Description = @Description";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Description", Description);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                GenreID = (int)reader["GenreID"];
                                GenreName = (string)reader["GenreName"];
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
        public static int AddNewGenre(string GenreName, string Description)
        {
            int GenreID = -1;
            string query = @"INSERT INTO Genres (GenreName, Description)
                        VALUES (@GenreName, @Description)
                        SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GenreName", GenreName);

                        if (Description != "")
                            command.Parameters.AddWithValue("@Description", Description);
                        else
                            command.Parameters.AddWithValue("@Description", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            GenreID = insertedID;
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

            return GenreID;
        }
        public static bool UpdateGenre(int GenreID, string GenreName, string Description)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Genres  
                                    SET 
                                    GenreName = @GenreName, 
                        Description = @Description
                        WHERE GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GenreID", GenreID);
                        command.Parameters.AddWithValue("@GenreName", GenreName);
                        command.Parameters.AddWithValue("@Description", Description);
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
        public static bool DeleteGenre(int GenreID)
        {
            int rowsAffected = 0;
            string query = @"Delete Genres 
                            where GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", GenreID);
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
        public static bool IsGenreExist(int GenreID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Genres WHERE GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", GenreID);
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
        public static bool IsGenreExistByGenreID(int GenreID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Genres WHERE GenreID = @GenreID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", GenreID);
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
        public static bool IsGenreExistByGenreName(string GenreName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Genres WHERE GenreName = @GenreName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreName", GenreName);
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
        public static bool IsGenreExistByDescription(string Description)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Genres WHERE Description = @Description";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Description", Description);
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
        public static DataTable GetAllGenres()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Genres";
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
