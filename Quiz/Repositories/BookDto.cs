using Quiz.Services;

namespace Quiz.Repositories
{
    public class BookDto
    {
        public string? Name { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public DateTime PublishedDate { get; set; }

    }
}