namespace Quiz.Services
{
    public class BookService
    {
        public BookService()
        {
            //This will depend on the lower level class: BookRepository
            //Consider using chained constructors for your DependencyInjection or your favourite Inversion of Control Container
            //e.g.: StructureMap
        }

        public Book Get(int id)
        {
            return new Book();
        }
    }
}
