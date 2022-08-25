
using Quiz.Repositories;

var bookRepo = new BookRepository();
//var bookDto = new BookDto() { Name = "Name", Title ="Title", Author = "Author",PublishedDate = DateTime.Now };
////bookRepo.SaveBookToBookTable(bookDto);

//var bookDto2 = new BookDto() { Name = "Bridget Did it", Title = "Title", Author = "Author", PublishedDate = DateTime.Now };
//bookRepo.UpdateBook(bookDto2, 6); 

//bookRepo.GetBooks();
Console.WriteLine(bookRepo.GetBook(2).Title);

//bookRepo.DeleteBook(6);

//Using the bookService, Create, Read, Update and Delete Book Entries from your SQL Books Table.

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("                                                                                         ");

Console.WriteLine("Using your knowledge of Dependency Inversion, could you use the concept of Dependency Injection to complete the BookService & BookRepository classes ?");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                                                                                         ");
