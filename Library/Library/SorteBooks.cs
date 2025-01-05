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
    public void SortByTitle()
    {
        var sortedTitle = listOfBooks.Books.OrderBy(x => x.Title).ToList();
        listOfBooks.Books.Clear(); 
        listOfBooks.Books.AddRange(sortedTitle);

    }
    public void SortByAuthor()
    {
        var sortedAuthor = listOfBooks.Books.OrderBy(x => x.Author).ToList();
        listOfBooks.Books.Clear();
        listOfBooks.Books.AddRange(sortedAuthor);
    }
    public void SortByGenre()
    {
        var sortedGenre = listOfBooks.Books.OrderBy(x => x.Genre).ToList();
        listOfBooks.Books.Clear();
        listOfBooks.Books.AddRange(sortedGenre);
    }
    public void SortByYear()
    {
        var sortedYear = listOfBooks.Books.OrderBy(x => x.Year).ToList();
        listOfBooks.Books.Clear();
        listOfBooks.Books.AddRange(sortedYear);
    }
    public void SortByPages()
    {
        var sortedPages = listOfBooks.Books.OrderBy(x => x.Pages).ToList();
        listOfBooks.Books.Clear();
        listOfBooks.Books.AddRange(sortedPages);
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
