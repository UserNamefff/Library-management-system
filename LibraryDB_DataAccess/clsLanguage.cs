using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{
    public class clsLanguageData
    {
        public static bool GetLanguageByID(int LanguageID, ref string LanguageName)
        {
            bool isFound = false;
            string query = "SELECT * FROM Languages WHERE LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["LanguageName"] != DBNull.Value)
                                    LanguageName = (string)reader["LanguageName"];
                                else
                                    LanguageName = "";

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
        public static bool GetLanguageByLanguageID(int LanguageID, ref string LanguageName)
        {
            bool isFound = false;
            string query = "SELECT * FROM Languages WHERE LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;


                                if (reader["LanguageName"] != DBNull.Value)
                                    LanguageName = (string)reader["LanguageName"];
                                else
                                    LanguageName = "";

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
        public static bool GetLanguageByLanguageName(ref int LanguageID, string LanguageName)
        {
            bool isFound = false;
            string query = "SELECT * FROM Languages WHERE LanguageName = @LanguageName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageName", LanguageName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                LanguageID = (int)reader["LanguageID"];
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
        public static int AddNewLanguage(string LanguageName)
        {
            int LanguageID = -1;
            string query = @"INSERT INTO Languages (LanguageName)
                            VALUES (@LanguageName)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        if (LanguageName != "")
                            command.Parameters.AddWithValue("@LanguageName", LanguageName);
                        else
                            command.Parameters.AddWithValue("@LanguageName", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LanguageID = insertedID;
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

            return LanguageID;
        }
        public static bool UpdateLanguage(int LanguageID, string LanguageName)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Languages  
                                        SET 
                                        LanguageName = @LanguageName
                            WHERE LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
                        command.Parameters.AddWithValue("@LanguageName", LanguageName);
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
        public static bool DeleteLanguage(int LanguageID)
        {
            int rowsAffected = 0;
            string query = @"Delete Languages 
                                where LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
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
        public static bool IsLanguageExist(int LanguageID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Languages WHERE LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
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
        public static bool IsLanguageExistByLanguageID(int LanguageID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Languages WHERE LanguageID = @LanguageID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageID", LanguageID);
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
        public static bool IsLanguageExistByLanguageName(string LanguageName)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Languages WHERE LanguageName = @LanguageName";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LanguageName", LanguageName);
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
        public static DataTable GetAllLanguages()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Languages";
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
