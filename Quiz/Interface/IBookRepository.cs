using Quiz.Repositories;

namespace Quiz.Interface
{
    public interface IBookRepository
    {
        public void SaveBookToBookTable(BookDto bookDto);
        public void ReadBookFromBookTable();
        public void UpdateBookInBookTable(BookDto bookDto, int bookID);
        public void DeleteBookInBookTable(int bookId);
    }
}
