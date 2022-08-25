using Quiz.Interface;
using Quiz.Mappers;
using Quiz.Repositories;

namespace Quiz.Services
{
    public class BookService
    {
        private IBookRepository _bookRepository;
        public BookService(): this(new BookRepository())
        {
            //This will depend on the lower level class: BookRepository
            //Consider using chained constructors for your DependencyInjection or your favourite Inversion of Control Container
            //e.g.: StructureMap
          
        }

        internal BookService(IBookRepository bookRepository) 
        {
            _bookRepository = bookRepository;
        }

        public Book? GetBook(int bookId)
        {
            return _bookRepository.GetBook(bookId);
        }

        public void SaveBook(Book book)
        {
            var bookDto =  BookMapper.ToBookDTOMap(book);

             _bookRepository.SaveBookDto(bookDto);
        }

        public void UpdateBook(Book book, int bookId)
        {
            var bookDto = BookMapper.ToBookDTOMap(book);

            _bookRepository.UpdateBook(bookDto, bookId);
        }

        public void DeleteBook(int bookId)
        {
            var book = _bookRepository.GetBook(bookId);
        }
    }
}
