using Quiz.Interface;
using Quiz.Services;
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


        //TODO: when method is called, use a try catch to ensure method is validated

        public void SaveBookDto(BookDto bookDto)
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

        public IList<BookDto> GetBooks()
        {
            IList<BookDto> books = new List<BookDto>(); 
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

                            BookDto book = new BookDto() { Author = author, Title = title, PublishedDate = publishedDate };
                            books.Add(book);

                        }
                    }
                }
                return books;
            }
        }

        public Book? GetBook(int bookId)
        {
            Book? book;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ReadOneBookDetail";
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd != null)
                    {
                        while (rd.Read())
                        {
                            var name = rd.GetString(0);
                            var title = rd.GetString(1);
                            var author = rd.GetString(2);
                            var publishedDate = rd.GetDateTime(3);

                            return book = new Book() { Author = author, Title = title, PublishedDate = publishedDate };
                        }
                    }
                }
                return new Book();
            }
        }

        //log out message when id doesnt exist
        public void UpdateBook(BookDto bookDto, int bookId)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateBookDetails";
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@Name", bookDto.Name);
                    cmd.Parameters.AddWithValue("@Title", bookDto.Title);
                    cmd.Parameters.AddWithValue("@Author", bookDto.Author);
                    cmd.Parameters.AddWithValue("@PublishedDate", bookDto.PublishedDate);
                    cmd.ExecuteNonQuery();
                }
            }
 
        }

        public void DeleteBook(int bookId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteBookDetails";
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    int numRes = cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
