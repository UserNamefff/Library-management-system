
using LMSLibrary_DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDB_DataAccess
{
    public class clsCopyData
    {
        public static bool GetCopyByID(int CopyID, ref int BookID, ref bool AvailabilityStatus, ref string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                IndexCopy = (string)reader["IndexCopy"];
                                AddDate = (DateTime)reader["AddDate"];
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
        public static bool GetCopyByCopyID(int CopyID, ref int BookID, ref bool AvailabilityStatus, ref string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                IndexCopy = (string)reader["IndexCopy"];
                                AddDate = (DateTime)reader["AddDate"];
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
        public static bool GetCopyByBookID(ref int CopyID, int BookID, ref bool AvailabilityStatus, ref string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE BookID = @BookID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                IndexCopy = (string)reader["IndexCopy"];
                                AddDate = (DateTime)reader["AddDate"];
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
        public static bool GetAvailabileBookCopyByBookID(ref int CopyID, int BookID, ref bool AvailabilityStatus, ref string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE BookID = @BookID AND AvailabilityStatus = 1";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                IndexCopy = (string)reader["IndexCopy"];
                                AddDate = (DateTime)reader["AddDate"];
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

        public static bool GetCopyByAvailabilityStatus(ref int CopyID, ref int BookID, bool AvailabilityStatus, ref string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE AvailabilityStatus = @AvailabilityStatus";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                BookID = (int)reader["BookID"];
                                IndexCopy = (string)reader["IndexCopy"];
                                AddDate = (DateTime)reader["AddDate"];
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
        public static bool GetCopyByIndexCopy(ref int CopyID, ref int BookID, ref bool AvailabilityStatus, string IndexCopy, ref DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE IndexCopy = @IndexCopy";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IndexCopy", IndexCopy);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                AddDate = (DateTime)reader["AddDate"];
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
        public static bool GetCopyByAddDate(ref int CopyID, ref int BookID, ref bool AvailabilityStatus, ref string IndexCopy, DateTime AddDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM BookCopies WHERE AddDate = @AddDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AddDate", AddDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                                IndexCopy = (string)reader["IndexCopy"];
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
        public static int AddNewCopy(int BookID, bool AvailabilityStatus, string IndexCopy, DateTime AddDate,int NumberOfCopyies)
        {
            int CopyID = -1;
            string query = @"INSERT INTO BookCopies (BookID, AvailabilityStatus, IndexCopy, AddDate)
                            VALUES (@BookID, @AvailabilityStatus, @IndexCopy, @AddDate)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result;
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                        command.Parameters.AddWithValue("@IndexCopy", IndexCopy);
                        command.Parameters.AddWithValue("@AddDate", AddDate);
                        connection.Open();

                        if (NumberOfCopyies == 1)
                        {
                            result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int inertedID))
                            {
                                CopyID = inertedID;
                            }
                            return CopyID;
                        }

                        for (int i = 0; i < NumberOfCopyies; i++)
                        {
                            result = command.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            {
                                CopyID = insertedID;
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

            return CopyID;
        }
        public static bool UpdateCopy(int CopyID, int BookID, bool AvailabilityStatus, string IndexCopy, DateTime AddDate)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BookCopies  
                                        SET 
                                        BookID = @BookID, 
                            AvailabilityStatus = @AvailabilityStatus, 
                            IndexCopy = @IndexCopy, 
                            AddDate = @AddDate
                            WHERE CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                        command.Parameters.AddWithValue("@IndexCopy", IndexCopy);
                        command.Parameters.AddWithValue("@AddDate", AddDate);
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
        public static bool DeleteCopy(int CopyID)
        {
            int rowsAffected = 0;
            string query = @"Delete BookCopies 
                                where CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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
        public static bool IsCopyExist(int CopyID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BookCopies WHERE CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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
        
        public static bool IsCopyExistByBookID(int BookID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BookCopies WHERE BookID = @BookID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
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
        
        
        public static bool IsCopyReserved(int CopyID)
        {
            return clsReservationData.IsCopyReservated(CopyID);
        }
        public static bool IsCopyAvaliable(int CopyID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BookCopies WHERE CopyID = @CopyID and  AvailabilityStatus = 1";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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

       
        public static DataTable GetAllBookCopies()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BookCopies";
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

        public static DataTable GetAllBookCopiesByBookID(int BookID)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BookCopies where BookID = @BookID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);

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

        public static bool UpdateCopy(int CopyID,bool Status)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BookCopies  
                                        SET 
                            AvailabilityStatus = @Status
                            
                            WHERE CopyID = @CopyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@Status", Status);
                        
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


    }
}
