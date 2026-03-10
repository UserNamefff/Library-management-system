using LibraryDB_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB_DataAccess
{

    public class clsSettingData
    {
        public static bool GetSettingByID(int SettingID, ref byte DefualtBorrrowDays, ref decimal DefaultFinePerDay)
        {
            bool isFound = false;
            string query = "SELECT * FROM Settings WHERE SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SettingID", SettingID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DefualtBorrrowDays = (byte)reader["DefualtBorrrowDays"];
                                DefaultFinePerDay = Convert.ToDecimal(reader["DefaultFinePerDay"]);
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
        public static bool GetSettingBySettingID(int SettingID, ref byte DefualtBorrrowDays, ref decimal DefaultFinePerDay)
        {
            bool isFound = false;
            string query = "SELECT * FROM Settings WHERE SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SettingID", SettingID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DefualtBorrrowDays = (byte)reader["DefualtBorrrowDays"];
                                DefaultFinePerDay = Convert.ToDecimal(reader["DefaultFinePerDay"]);
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
        public static bool GetSettingByDefualtBorrrowDays(ref int SettingID, byte DefualtBorrrowDays, ref decimal DefaultFinePerDay)
        {
            bool isFound = false;
            string query = "SELECT * FROM Settings WHERE DefualtBorrrowDays = @DefualtBorrrowDays";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefualtBorrrowDays", DefualtBorrrowDays);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                SettingID = (int)reader["SettingID"];
                                DefaultFinePerDay = Convert.ToDecimal(reader["DefaultFinePerDay"]);
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
        public static bool GetSettingByDefaultFinePerDay(ref int SettingID, ref byte DefualtBorrrowDays, decimal DefaultFinePerDay)
        {
            bool isFound = false;
            string query = "SELECT * FROM Settings WHERE DefaultFinePerDay = @DefaultFinePerDay";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                SettingID = (int)reader["SettingID"];
                                DefualtBorrrowDays = (byte)reader["DefualtBorrrowDays"];
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
        public static int AddNewSetting(byte DefualtBorrrowDays, decimal DefaultFinePerDay)
        {
            int SettingID = -1;
            string query = @"INSERT INTO Settings (DefualtBorrrowDays, DefaultFinePerDay)
                            VALUES (@DefualtBorrrowDays, @DefaultFinePerDay)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DefualtBorrrowDays", DefualtBorrrowDays);
                        command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            SettingID = insertedID;
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

            return SettingID;
        }
        public static bool UpdateSetting(int SettingID, byte DefualtBorrrowDays, decimal DefaultFinePerDay)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Settings  
                                        SET 
                                        DefualtBorrrowDays = @DefualtBorrrowDays, 
                            DefaultFinePerDay = @DefaultFinePerDay
                            WHERE SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@SettingID", SettingID);
                        command.Parameters.AddWithValue("@DefualtBorrrowDays", DefualtBorrrowDays);
                        command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
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
        public static bool DeleteSetting(int SettingID)
        {
            int rowsAffected = 0;
            string query = @"Delete Settings 
                                where SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SettingID", SettingID);
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
        public static bool IsSettingExist(int SettingID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Settings WHERE SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SettingID", SettingID);
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
        public static bool IsSettingExistBySettingID(int SettingID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Settings WHERE SettingID = @SettingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SettingID", SettingID);
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
        public static bool IsSettingExistByDefualtBorrrowDays(byte DefualtBorrrowDays)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Settings WHERE DefualtBorrrowDays = @DefualtBorrrowDays";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefualtBorrrowDays", DefualtBorrrowDays);
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
        public static bool IsSettingExistByDefaultFinePerDay(decimal DefaultFinePerDay)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Settings WHERE DefaultFinePerDay = @DefaultFinePerDay";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
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
        public static DataTable GetAllSettings()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Settings";
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



