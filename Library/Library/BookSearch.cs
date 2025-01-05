using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class BookSearch
{
    private readonly ListOfBooks listOfBooks;

    public BookSearch(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }

    public IEnumerable<AddBook> SearchByTitle(string title)
    {
        return listOfBooks.Books.Where(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByAutor(string author)
    {
        return listOfBooks.Books.Where(x => x.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByGenre(string genre)
    {
        return listOfBooks.Books.Where(x => x.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByYear(int year)
    {
        return listOfBooks.Books.Where(x => x.Year == year);
    }
    public IEnumerable<AddBook> SearchByPages(int pages)
    {
        return listOfBooks.Books.Where(x => x.Pages == pages);
    }
    public void ShowAllSearchedBooks()
    {
        if (listOfBooks.Books.Count == 0)
        {
            Console.WriteLine("List of books is empty");
            return;
        }

        foreach (var book in listOfBooks.Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year: {book.Year}, Pages: {book.Pages}");
        }
    }
}

