using System.Data;
using System.Data.SqlClient;
using System;

namespace LibraryDB_DataAccess
{

        public class clsBookData
        {
            public static bool GetBookByID(int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE BookID = @BookID";
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

                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByBookID(int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE BookID = @BookID";
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

                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByTitle(ref int BookID, string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE Title = @Title";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Title", Title);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.Read())
                                {
                                    isFound = true;

                                    BookID = (int)reader["BookID"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByISBN(ref int BookID, ref string Title, string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE ISBN = @ISBN";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ISBN", ISBN);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.Read())
                                {
                                    isFound = true;

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByPublicationDate(ref int BookID, ref string Title, ref string ISBN, DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE PublicationDate = @PublicationDate";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.Read())
                                {
                                    isFound = true;

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByGenreID(ref int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, int GenreID, ref string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE GenreID = @GenreID";
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

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByAdditionalDetails(ref int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, string AdditionalDetails, ref int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE AdditionalDetails = @AdditionalDetails";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.Read())
                                {
                                    isFound = true;

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];
                                    AuthorID = (int)reader["AuthorID"];
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
            public static bool GetBookByAuthorID(ref int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, int AuthorID, ref int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE AuthorID = @AuthorID";
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

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

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
            public static bool GetBookByLanguageID(ref int BookID, ref string Title, ref string ISBN, ref DateTime PublicationDate, ref int GenreID, ref string AdditionalDetails, ref int AuthorID, int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT * FROM Books WHERE LanguageID = @LanguageID";
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

                                    BookID = (int)reader["BookID"];
                                    Title = (string)reader["Title"];
                                    ISBN = (string)reader["ISBN"];
                                    PublicationDate = (DateTime)reader["PublicationDate"];
                                    GenreID = (int)reader["GenreID"];

                                    if (reader["AdditionalDetails"] != DBNull.Value)
                                        AdditionalDetails = (string)reader["AdditionalDetails"];
                                    else
                                        AdditionalDetails = "";

                                    AuthorID = (int)reader["AuthorID"];
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
            public static int AddNewBook(string Title, string ISBN, DateTime PublicationDate, int GenreID, string AdditionalDetails, int AuthorID, int LanguageID)
            {
                int BookID = -1;
                string query = @"INSERT INTO Books (Title, ISBN, PublicationDate, GenreID, AdditionalDetails, AuthorID, LanguageID)
                            VALUES (@Title, @ISBN, @PublicationDate, @GenreID, @AdditionalDetails, @AuthorID, @LanguageID)
                            SELECT SCOPE_IDENTITY();";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@Title", Title);
                            command.Parameters.AddWithValue("@ISBN", ISBN);
                            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                            command.Parameters.AddWithValue("@GenreID", GenreID);

                            if (AdditionalDetails != "")
                                command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
                            else
                                command.Parameters.AddWithValue("@AdditionalDetails", DBNull.Value);
                            command.Parameters.AddWithValue("@AuthorID", AuthorID);
                            command.Parameters.AddWithValue("@LanguageID", LanguageID);
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            {
                                BookID = insertedID;
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

                return BookID;
            }
            public static bool UpdateBook(int BookID, string Title, string ISBN, DateTime PublicationDate, int GenreID, string AdditionalDetails, int AuthorID, int LanguageID)
            {
                int rowsAffected = 0;
                string query = @"UPDATE Books  
                                        SET 
                                        Title = @Title, 
                            ISBN = @ISBN, 
                            PublicationDate = @PublicationDate, 
                            GenreID = @GenreID, 
                            AdditionalDetails = @AdditionalDetails, 
                            AuthorID = @AuthorID, 
                            LanguageID = @LanguageID
                            WHERE BookID = @BookID";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@BookID", BookID);
                            command.Parameters.AddWithValue("@Title", Title);
                            command.Parameters.AddWithValue("@ISBN", ISBN);
                            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                            command.Parameters.AddWithValue("@GenreID", GenreID);
                            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
                            command.Parameters.AddWithValue("@AuthorID", AuthorID);
                            command.Parameters.AddWithValue("@LanguageID", LanguageID);
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
            public static bool DeleteBook(int BookID)
            {
                int rowsAffected = 0;
                string query = @"Delete Books 
                                where BookID = @BookID";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", BookID);
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
            public static bool IsBookExist(int BookID)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE BookID = @BookID";
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
            public static bool IsBookExistByBookID(int BookID)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE BookID = @BookID";
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
            public static bool IsBookExistByTitle(string Title)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE Title = @Title";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Title", Title);
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
            public static bool IsBookExistByISBN(string ISBN)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE ISBN = @ISBN";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ISBN", ISBN);
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
            public static bool IsBookExistByPublicationDate(DateTime PublicationDate)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE PublicationDate = @PublicationDate";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
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
            public static bool IsBookExistByGenreID(int GenreID)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE GenreID = @GenreID";
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
            public static bool IsBookExistByAdditionalDetails(string AdditionalDetails)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE AdditionalDetails = @AdditionalDetails";
                try
                {
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
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
            public static bool IsBookExistByAuthorID(int AuthorID)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE AuthorID = @AuthorID";
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
            public static bool IsBookExistByLanguageID(int LanguageID)
            {
                bool isFound = false;
                string query = "SELECT Found=1 FROM Books WHERE LanguageID = @LanguageID";
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
            public static DataTable GetAllBooks()
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Books";
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
