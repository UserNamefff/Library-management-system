using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{
    public class clsBorrowingRecordData
    {
        public static bool GetBorrowingRecordByID(int BorrowingRecordID, ref int MemberID, ref int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID";
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

                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByBorrowingRecordID(int BorrowingRecordID, ref int MemberID, ref int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID";
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

                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByMemberID(ref int BorrowingRecordID, int MemberID, ref int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE MemberID = @MemberID";
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

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByCopyID(ref int BorrowingRecordID, ref int MemberID, int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE CopyID = @CopyID";
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

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                MemberID = (int)reader["MemberID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByBorrowingDate(ref int BorrowingRecordID, ref int MemberID, ref int CopyID, DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE BorrowingDate = @BorrowingDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByDueDate(ref int BorrowingRecordID, ref int MemberID, ref int CopyID, ref DateTime BorrowingDate, DateTime DueDate, ref DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE DueDate = @DueDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static bool GetBorrowingRecordByActualReturnDate(ref int BorrowingRecordID, ref int MemberID, ref int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, DateTime ActualReturnDate , ref int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE ActualReturnDate = @ActualReturnDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];
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
        public static bool GetBorrowingRecordByCreatedByID(ref int BorrowingRecordID, ref int MemberID, ref int CopyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate , int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT * FROM BorrowingRecords WHERE CreatedByID = @CreatedByID";
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

                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                MemberID = (int)reader["MemberID"];
                                CopyID = (int)reader["CopyID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] != DBNull.Value)
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                else
                                    ActualReturnDate = DateTime.MinValue;

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
        public static int AddNewBorrowingRecord(int MemberID, int CopyID, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate , int CreatedByID)
        {
            int BorrowingRecordID = -1;
            string query = @"INSERT INTO BorrowingRecords (MemberID, CopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByID)
                            VALUES (@MemberID, @CopyID, @BorrowingDate, @DueDate, @ActualReturnDate, @CreatedByID)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        command.Parameters.AddWithValue("@CreatedByID", CreatedByID);

                        if (ActualReturnDate != DateTime.MinValue)
                            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        else
                            command.Parameters.AddWithValue("@ActualReturnDate", DBNull.Value);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            BorrowingRecordID = insertedID;
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

            return BorrowingRecordID;
        }
        public static bool UpdateBorrowingRecord(int BorrowingRecordID, int MemberID, int CopyID, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate , int CreatedByID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BorrowingRecords  
                                        SET 
                                        MemberID = @MemberID, 
                            CopyID = @CopyID, 
                            BorrowingDate = @BorrowingDate, 
                            DueDate = @DueDate, 
                            ActualReturnDate = @ActualReturnDate, 
                            CreatedByID = @CreatedByID
                            WHERE BorrowingRecordID = @BorrowingRecordID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
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
        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
        {
            int rowsAffected = 0;
            string query = @"Delete BorrowingRecords 
                                where BorrowingRecordID = @BorrowingRecordID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
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
        public static bool IsBorrowingRecordExist(int BorrowingRecordID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID";
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
        public static bool IsBorrowingRecordExistByBorrowingRecordID(int BorrowingRecordID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID";
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
        public static bool IsBorrowingRecordExistByMemberID(int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE MemberID = @MemberID";
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
        public static bool IsBorrowingRecordExistByCopyID(int CopyID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE CopyID = @CopyID";
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
        public static bool IsBorrowingRecordExistByBorrowingDate(DateTime BorrowingDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE BorrowingDate = @BorrowingDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
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
        public static bool IsBorrowingRecordExistByDueDate(DateTime DueDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE DueDate = @DueDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DueDate", DueDate);
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
        public static bool IsBorrowingRecordExistByActualReturnDate(DateTime ActualReturnDate )
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE ActualReturnDate = @ActualReturnDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
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
        public static bool IsBorrowingRecordExistByCreatedByID(int CreatedByID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE CreatedByID = @CreatedByID";
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
        public static DataTable GetAllBorrowingRecords()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT BorrowingRecords.BorrowingRecordID, BorrowingRecords.MemberID, BorrowingRecords.CopyID, Books.Title,case when  People.LastName is not null then People.FirstName +' ' + People.SecondName+' ' + People.ThirdName+' ' + People.LastName else People.FirstName +' ' + People.SecondName+' ' + People.ThirdName end as MemberName, BorrowingRecords.BorrowingDate, 
                  BorrowingRecords.DueDate, BorrowingRecords.ActualReturnDate, Users.UserName
FROM     Members INNER JOIN
                  BorrowingRecords ON Members.MemberID = BorrowingRecords.MemberID INNER JOIN
                  People ON Members.PersonID = People.PersonID INNER JOIN
                  Users ON  BorrowingRecords.CreatedByID = Users.UserID  INNER JOIN
                  BookCopies ON BorrowingRecords.CopyID = BookCopies.CopyID INNER JOIN
                  Books ON BookCopies.BookID = Books.BookID ";
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

        public static bool IsReturnedBook(int BorrowingRecordID)

        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID and ActualReturnDate Is NOT NULL ";
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
        public static bool IsBookAlreadyBorrowedByMemberAndDoesNotReturned(int BookID,int MemberID)

        {
            bool isFound = false;
            string query = @"SELECT Found = 1
                        FROM  BookCopies    INNER JOIN BorrowingRecords
                               ON BookCopies.CopyID = BorrowingRecords.CopyID
							   where (BorrowingRecords.ActualReturnDate is null) and  BorrowingRecords.MemberID = @MemberID
				             AND BookCopies.BookID = @BookID ";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
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
    }
}
