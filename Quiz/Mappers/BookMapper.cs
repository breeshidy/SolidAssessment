using Quiz.Repositories;
using Quiz.Services;

namespace Quiz.Mappers
{
    internal class BookMapper
    {
        public static BookDto ToBookDTOMap(Book book)
        {
            return new BookDto()
            {
                Name = book.Name,
                Title = book.Title,
                Author = book.Author,
                PublishedDate = book.PublishedDate,

            };
        }
    }
}
