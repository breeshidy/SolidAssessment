using Quiz.Repositories;
using Quiz.Services;

namespace Quiz.Interface
{
    public interface IBookRepository
    {
        public void SaveBookDto(BookDto bookDto);
        public IList<BookDto> GetBooks();
        public void UpdateBook(BookDto bookDto, int bookID);
        public void DeleteBook(int bookId);
        public Book? GetBook(int bookId);
    }
}
