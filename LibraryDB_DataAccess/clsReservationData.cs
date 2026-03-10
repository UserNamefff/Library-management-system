using LibraryDB_DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LMSLibrary_DataAccess
{
    public class clsReservationData
    {
        public static bool GetReservationByID(int ReservationID, ref int MemberID, ref int BookID, ref DateTime ReservationDate, ref short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                BookID = (int)reader["BookID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                Status = (short)reader["Status"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByReservationID(int ReservationID, ref int MemberID, ref int BookID, ref DateTime ReservationDate, ref short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                BookID = (int)reader["BookID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                Status = (short)reader["Status"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByMemberID(ref int ReservationID, int MemberID, ref int BookID, ref DateTime ReservationDate, ref short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE MemberID = @MemberID";
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

                                ReservationID = (int)reader["ReservationID"];
                                BookID = (int)reader["BookID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                Status = (short)reader["Status"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByBookID(ref int ReservationID, ref int MemberID, int BookID, ref DateTime ReservationDate, ref short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE BookID = @BookID";
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

                                ReservationID = (int)reader["ReservationID"];
                                MemberID = (int)reader["MemberID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                Status = (short)reader["Status"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByReservationDate(ref int ReservationID, ref int MemberID, ref int BookID, DateTime ReservationDate, ref short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE ReservationDate = @ReservationDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ReservationID = (int)reader["ReservationID"];
                                MemberID = (int)reader["MemberID"];
                                BookID = (int)reader["BookID"];
                                Status = (short)reader["Status"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByStatus(ref int ReservationID, ref int MemberID, ref int BookID, ref DateTime ReservationDate, short Status, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE Status = @Status";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", Status);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ReservationID = (int)reader["ReservationID"];
                                MemberID = (int)reader["MemberID"];
                                BookID = (int)reader["BookID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                CreatedBy = (int)reader["CreatedBy"];
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
        public static bool GetReservationByCreatedBy(ref int ReservationID, ref int MemberID, ref int BookID, ref DateTime ReservationDate, ref short Status, int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Reservations WHERE CreatedBy = @CreatedBy";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ReservationID = (int)reader["ReservationID"];
                                MemberID = (int)reader["MemberID"];
                                BookID = (int)reader["BookID"];
                                ReservationDate = (DateTime)reader["ReservationDate"];
                                Status = (short)reader["Status"];
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
        public static int AddNewReservation(int MemberID, int BookID, DateTime ReservationDate, short Status, int CreatedBy)
        {
            int ReservationID = -1;
            string query = @"INSERT INTO Reservations (MemberID, BookID, ReservationDate, Status, CreatedBy)
                            VALUES (@MemberID, @BookID, @ReservationDate, @Status, @CreatedBy)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ReservationID = insertedID;
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

            return ReservationID;
        }
        public static bool UpdateReservation(int ReservationID, int MemberID, int BookID, DateTime ReservationDate, short Status, int CreatedBy)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Reservations  
                                        SET 
                                        MemberID = @MemberID, 
                            BookID = @BookID, 
                            ReservationDate = @ReservationDate, 
                            Status = @Status, 
                            CreatedBy = @CreatedBy
                            WHERE ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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
        public static bool DeleteReservation(int ReservationID)
        {
            int rowsAffected = 0;
            string query = @"Delete Reservations 
                                where ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
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
        public static bool IsReservationExist(int ReservationID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
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
        public static bool IsReservationExistByReservationID(int ReservationID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE ReservationID = @ReservationID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
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
        public static bool IsReservationExistByMemberID(int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE MemberID = @MemberID";
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
        public static bool IsReservationExistByBookID(int BookID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE BookID = @BookID";
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
        public static bool IsReservationExistByReservationDate(DateTime ReservationDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE ReservationDate = @ReservationDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
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
        public static bool IsReservationExistByStatus(short Status)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE Status = @Status";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", Status);
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
        public static bool IsReservationExistByCreatedBy(int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE CreatedBy = @CreatedBy";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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
        public static bool IsCopyReservated(int BookID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE BookID = @BookID AND Status = 1";
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
        public static bool IsBookReservated(int BookID,int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Reservations WHERE MemberID = @MemberID and BookID = @BookID AND Status = 1";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
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
        public static DataTable GetAllReservations()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT Reservations.ReservationID,case when People.LastName is not null then
People.FirstName +' '+ People.SecondName +' '+People.ThirdName +' '+ People.LastName  else People.FirstName +' '+ People.SecondName +' '+People.ThirdName end as MemberName, Books.Title as BookName, Reservations.ReservationDate, 
case when Reservations.Status = 1 then 'Reserved' when Reservations.Status = 2 then 'Canceled' when Reservations.Status = 2 then 'Expired' else 'Completed' end as Status, Reservations.CreatedBy, Users.UserName
FROM     People INNER JOIN
                  Members ON People.PersonID = Members.PersonID INNER JOIN
                  Reservations ON Members.MemberID = Reservations.MemberID INNER JOIN
                  Books ON Reservations.BookID = Books.BookID INNER JOIN
                  Users ON Reservations.CreatedBy = Users.UserID ";
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
