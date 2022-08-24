using Quiz.Interface;

namespace Quiz.Services
{
    public class BookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            //This will depend on the lower level class: BookRepository
            //Consider using chained constructors for your DependencyInjection or your favourite Inversion of Control Container
            //e.g.: StructureMap
            _bookRepository = bookRepository;
        }

        public Book Get(int id)
        {
            return new Book();
        }
    }
}
