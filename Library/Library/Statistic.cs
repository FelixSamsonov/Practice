using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Statistic
{
    private readonly ListOfBooks listOfBooks;

    public Statistic(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public void ShowStatistic()
    {
        var countBooks = listOfBooks.Books.Count();

        Console.WriteLine($"Number of books in the library: {countBooks}");

        var statisticGenre = listOfBooks.Books.GroupBy(x => x.Genre);
        foreach (var group in statisticGenre)
        {
            Console.WriteLine($"Genre: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"  Title: {book.Title}, Autor: {book.Author}");
            }
        }
        var averagePages = listOfBooks.Books.Average(x => x.Pages);
        Console.WriteLine($"Average number of pages is {averagePages}");

        var oldestBook = listOfBooks.Books.Min(x => x.Year);
        var oldestBookAuthor = listOfBooks.Books.Where(x => x.Year == oldestBook);

        Console.WriteLine($"The oldest books in the library are from year \"{oldestBook}\", written by:");
        foreach (var book in oldestBookAuthor)
        {
            Console.WriteLine($"- {book.Author} ({book.Title})");
        }

        var newestBook = listOfBooks.Books.Min(x => x.Year);
        var newestBookAuthor = listOfBooks.Books.Where(x => x.Year == newestBook);

        Console.WriteLine($"The oldest books in the library are from year \"{newestBook}\", written by:");
        foreach (var book in newestBookAuthor)
        {
            Console.WriteLine($"- {book.Author} ({book.Title})");
        }

        var bookWithMostPages = listOfBooks.Books.OrderByDescending(x => x.Pages).FirstOrDefault();

        if (bookWithMostPages != null)
        {
            Console.WriteLine($"The author of the book with the most pages is {bookWithMostPages.Author}");
        }
        else
        {
            Console.WriteLine("The book list is empty.");
        }

    }
}
