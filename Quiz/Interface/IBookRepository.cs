using Quiz.Repositories;

namespace Quiz.Interface
{
    public interface IBookRepository
    {
        public void SaveBook(BookDto bookDto);
        public IList<BookDto> GetBooks();
        public void UpdateBook(BookDto bookDto, int bookID);
        public void DeleteBook(int bookId);
    }
}
