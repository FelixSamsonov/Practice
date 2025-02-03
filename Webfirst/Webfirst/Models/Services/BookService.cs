namespace Webfirst.Models.Services
{
    public class BookService
    {
        private static List<ParametrOfBook> books = new List<ParametrOfBook>
        {
        new ParametrOfBook {Id = 1, Title = "The Lord of the Rings: The Fellowship of the Ring",
                Author = "J.R.R. Tolkien", Genre = "Fantasy", Year = 1954, Pages = 423, Language = "English"},
             new ParametrOfBook {Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling", Genre = "Fantasy", Year = 1997, Pages = 223, Language = "English"}
             };
        public List<ParametrOfBook> GetAllBooks()
        { return books; }
        public ParametrOfBook GetBookById(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                throw new Exception("Book not found");
            return book;
        }
        public void AddBook(ParametrOfBook newBook)
        {
            newBook.Id = books.Max(x => x.Id) + 1;
            books.Add(newBook);
        }
        public void UpdateBook(ParametrOfBook updateBook)
        {
            var book = GetBookById(updateBook.Id);
            if(book != null)
            {
                book.Title = updateBook.Title;
                book.Author = updateBook.Author;
                book.Genre = updateBook.Genre;
                book.Year = updateBook.Year;
                book.Pages = updateBook.Pages;
                book.Language = updateBook.Language;
            }
        }
        public void DeleteBook(int id)
        {
            var book = GetBookById(id);
            if(book != null)
                books.Remove(book);
        }
    }
}
