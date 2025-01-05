using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class SorteBooks
{

    private readonly ListOfBooks listOfBooks;

    public SorteBooks(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public IEnumerable<AddBook> SortByTitle()
    {
        var sorted = listOfBooks.Books.OrderBy(x => x.Title);
        return sorted;
    }
    public IEnumerable<AddBook> SortByAuthor()
    {
        var sorted = listOfBooks.Books.OrderBy(x => x.Author);
        return sorted;
    }
    public IEnumerable<AddBook> SortByGenre()
    {
        var sorted = listOfBooks.Books.OrderBy(x => x.Genre);
        return sorted;
    }
    public IEnumerable<AddBook> SortByYear()
    {
        var sorted = listOfBooks.Books.OrderBy(x => x.Year);
        return sorted;
    }
    public IEnumerable<AddBook> SortByPages()
    {
        var sorted = listOfBooks.Books.OrderBy(x => x.Pages);
        return sorted;
    }
    public void ShowAllSortedBooks()
    {
        if (listOfBooks.Books.Count == 0)
        {
            Console.WriteLine("List of books is empty.");
            return;
        }

        foreach (var book in listOfBooks.Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year: {book.Year}, Pages: {book.Pages}");
        }
    }
}
