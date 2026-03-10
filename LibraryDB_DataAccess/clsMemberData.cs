

using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{
    public class clsMemberData
    {
        public static bool GetMemberByID(int MemberID, ref int PersonID, ref DateTime JoinDate, ref DateTime ExpiredDateMembership, ref bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE MemberID = @MemberID";
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

                                PersonID = (int)reader["PersonID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetMemberByMemberID(int MemberID, ref int PersonID, ref DateTime JoinDate, ref DateTime ExpiredDateMembership, ref bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE MemberID = @MemberID";
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

                                PersonID = (int)reader["PersonID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetMemberByPersonID(ref int MemberID, int PersonID, ref DateTime JoinDate, ref DateTime ExpiredDateMembership, ref bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetMemberByJoinDate(ref int MemberID, ref int PersonID, DateTime JoinDate, ref DateTime ExpiredDateMembership, ref bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE JoinDate = @JoinDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JoinDate", JoinDate);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                PersonID = (int)reader["PersonID"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetMemberByExpiredDateMembership(ref int MemberID, ref int PersonID, ref DateTime JoinDate, DateTime ExpiredDateMembership, ref bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE ExpiredDateMembership = @ExpiredDateMembership";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpiredDateMembership", ExpiredDateMembership);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                PersonID = (int)reader["PersonID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetMemberByIsActive(ref int MemberID, ref int PersonID, ref DateTime JoinDate, ref DateTime ExpiredDateMembership, bool IsActive, ref int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE IsActive = @IsActive";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                PersonID = (int)reader["PersonID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
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
        public static bool GetMemberByCreatedBy(ref int MemberID, ref int PersonID, ref DateTime JoinDate, ref DateTime ExpiredDateMembership, ref bool IsActive, int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT * FROM Members WHERE CreatedBy = @CreatedBy";
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

                                MemberID = (int)reader["MemberID"];
                                PersonID = (int)reader["PersonID"];
                                JoinDate = (DateTime)reader["JoinDate"];
                                ExpiredDateMembership = (DateTime)reader["ExpiredDateMembership"];
                                IsActive = (bool)reader["IsActive"];
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
        public static int AddNewMember(int PersonID, DateTime JoinDate, DateTime ExpiredDateMembership, bool IsActive, int CreatedBy)
        {
            int MemberID = -1;
            string query = @"INSERT INTO Members (PersonID, JoinDate, ExpiredDateMembership, IsActive, CreatedBy)
                            VALUES (@PersonID, @JoinDate, @ExpiredDateMembership, @IsActive, @CreatedBy)
                            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@JoinDate", JoinDate);
                        command.Parameters.AddWithValue("@ExpiredDateMembership", ExpiredDateMembership);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            MemberID = insertedID;
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

            return MemberID;
        }
        public static bool UpdateMember(int MemberID, int PersonID, DateTime JoinDate, DateTime ExpiredDateMembership, bool IsActive, int CreatedBy)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Members  
                                        SET 
                                        PersonID = @PersonID, 
                            JoinDate = @JoinDate, 
                            ExpiredDateMembership = @ExpiredDateMembership, 
                            IsActive = @IsActive, 
                            CreatedBy = @CreatedBy
                            WHERE MemberID = @MemberID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@JoinDate", JoinDate);
                        command.Parameters.AddWithValue("@ExpiredDateMembership", ExpiredDateMembership);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool DeleteMember(int MemberID)
        {
            int rowsAffected = 0;
            string query = @"Delete Members 
                                where MemberID = @MemberID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", MemberID);
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
        public static bool IsMemberExist(int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE MemberID = @MemberID";
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
        public static bool IsMemberExistByMemberID(int MemberID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE MemberID = @MemberID";
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
        public static bool IsMemberExistByPersonID(int PersonID)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE PersonID = @PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool IsMemberExistByJoinDate(DateTime JoinDate)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE JoinDate = @JoinDate";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@JoinDate", JoinDate);
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
        public static bool IsMemberExistByExpiredDateMembership(DateTime ExpiredDateMembership)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE ExpiredDateMembership = @ExpiredDateMembership";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExpiredDateMembership", ExpiredDateMembership);
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
        public static bool IsMemberExistByIsActive(bool IsActive)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE IsActive = @IsActive";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool IsMemberExistByCreatedBy(int CreatedBy)
        {
            bool isFound = false;
            string query = "SELECT Found=1 FROM Members WHERE CreatedBy = @CreatedBy";
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
        public static bool DoesThisMemberHaveAFine(int MemberID)
        {
            bool IsHave = false;
            string query = "SELECT Found=1 FROM Fines WHERE MemberID = @MemberID And PaymentStatus = 0";
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
                            IsHave = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsHave = false;
            }
            finally
            {

            }

            return IsHave;
        }
        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT Members.MemberID, case when People.LastName is not null then
People.FirstName +' '+ People.SecondName +' '+People.ThirdName +' '+ People.LastName  else People.FirstName +' '+ People.SecondName +' '+People.ThirdName end as MemberName,
Members.JoinDate, Members.ExpiredDateMembership, Members.IsActive
FROM     Members INNER JOIN
                  People ON Members.PersonID = People.PersonID ";
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
