using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{
    public class clsFineData
    {
        public static bool GetFineByID(int FineID, ref int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByFineID(int FineID, ref int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByMemberID(ref int FineID, int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE MemberID = @MemberID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByMemberIDThatDontPayFine(ref int FineID, int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE MemberID = @MemberID AND PaymentStatus = 0";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByBorrowingRecordID(ref int FineID, ref int MemberID, int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE BorrowingRecordID = @BorrowingRecordID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                MemberID = (int)reader["MemberID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByNumberOfLateDays(ref int FineID, ref int MemberID, ref int BorrowingRecordID, short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE NumberOfLateDays = @NumberOfLateDays";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByFineAmount(ref int FineID, ref int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, float FineAmount, ref bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE FineAmount = @FineAmount";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                PaymentStatus = (bool)reader["PaymentStatus"];
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByPaymentStatus(ref int FineID, ref int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, bool PaymentStatus, ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE PaymentStatus = @PaymentStatus";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                CreatedByID = (int)reader["CreatedByID"];
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
        public static bool GetFineByCreatedByID(ref int FineID, ref int MemberID, ref int BorrowingRecordID, ref short NumberOfLateDays, ref float FineAmount, ref bool PaymentStatus, int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Fines WHERE CreatedByID = @CreatedByID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                FineID = (int)reader["FineID"];
                                MemberID = (int)reader["MemberID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = Convert.ToSingle(reader["FineAmount"]);
                                PaymentStatus = (bool)reader["PaymentStatus"];
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
        public static int AddNewFine(int MemberID, int BorrowingRecordID, short NumberOfLateDays, float FineAmount, bool PaymentStatus, int CreatedByID)
        {
            int FineID = -1;
            string query = @"INSERT INTO Fines (MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByID)
                            VALUES (@MemberID, @BorrowingRecordID, @NumberOfLateDays, @FineAmount, @PaymentStatus, @CreatedByID)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            FineID = insertedID;
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

            return FineID;
        }
        public static bool UpdateFine(int FineID, int MemberID, int BorrowingRecordID, short NumberOfLateDays, float FineAmount, bool PaymentStatus, int CreatedByID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Fines  
                                        SET 
                                        MemberID = @MemberID, 
                            BorrowingRecordID = @BorrowingRecordID, 
                            NumberOfLateDays = @NumberOfLateDays, 
                            FineAmount = @FineAmount, 
                            PaymentStatus = @PaymentStatus, 
                            CreatedByID = @CreatedByID
                            WHERE FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FineID", FineID);
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
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
        public static bool DeleteFine(int FineID)
        {
            int rowsAffected = 0;
            string query = @"Delete Fines 
                                where FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);
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
        public static bool IsFineExist(int FineID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);
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
        public static bool IsFineExistByFineID(int FineID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE FineID = @FineID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", FineID);
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
        public static bool HasMemberUnpaidFine(int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE MemberID = @MemberID AND PaymentStatus = 0";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
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
        public static bool IsFineExistByBorrowingRecordID(int BorrowingRecordID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE BorrowingRecordID = @BorrowingRecordID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
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
        public static bool IsFineExistByNumberOfLateDays(short NumberOfLateDays)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE NumberOfLateDays = @NumberOfLateDays";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
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
        public static bool IsFineExistByFineAmount(float FineAmount)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE FineAmount = @FineAmount";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineAmount", FineAmount);
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
        public static bool IsFineExistByPaymentStatus(bool PaymentStatus)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE PaymentStatus = @PaymentStatus";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
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
        public static bool IsFineExistByCreatedByID(int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Fines WHERE CreatedByID = @CreatedByID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedByID", CreatedByID);
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
        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Fines";
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
