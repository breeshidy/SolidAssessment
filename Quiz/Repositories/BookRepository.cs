using Quiz.Interface;
using System.Data;
using System.Data.SqlClient;

namespace Quiz.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly string _connectionString;
        public BookRepository()
        {
            _connectionString = "server=localhost;database=Training;uid=TMC;pwd=TMC";
            //get this to talk to a SQL db, with a table for for storing Book entries
            //this BookRepository class should be able to do CRUD operations on the Books SQL table.
        }

        public void SaveBookToBookTable(BookDto bookDto)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertBookDetails";
                    cmd.Parameters.AddWithValue("@Name", bookDto.Name);
                    cmd.Parameters.AddWithValue("@Title", bookDto.Title);
                    cmd.Parameters.AddWithValue("@Author", bookDto.Author);
                    cmd.Parameters.AddWithValue("@PublishedDate", bookDto.PublishedDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ReadBookFromBookTable()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ReadBookDetails";
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd != null)
                    {
                        while (rd.Read())
                        {
                            var name = rd.GetString(0);
                            var title = rd.GetString(1);
                            var author = rd.GetString(2);
                            var publishedDate = rd.GetDateTime(3);

                            //display retrieved record
                            Console.WriteLine("{0},{1},{2},{3}", name, title, author, publishedDate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                }
            }
        }



        public void UpdateBookInBookTable(BookDto bookDto, int bookID)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateBookDetails";
                    cmd.Parameters.AddWithValue("@BookId", bookID);
                    cmd.Parameters.AddWithValue("@Name", bookDto.Name);
                    cmd.Parameters.AddWithValue("@Title", bookDto.Title);
                    cmd.Parameters.AddWithValue("@Author", bookDto.Author);
                    cmd.Parameters.AddWithValue("@PublishedDate", bookDto.PublishedDate);
                    cmd.ExecuteNonQuery();
                }
            }
 
        }



        public void DeleteBookInBookTable(int bookId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteBookDetails";
                    int numRes = cmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully !!!");
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again !!!");
                    }


                }
            }
        }
    }
}
