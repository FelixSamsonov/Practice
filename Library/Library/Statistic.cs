using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Statistic
{
    private List<AddBook> books = new List<AddBook>();

    public void ShowStatistic()
    {
        var countBooks = books.Count();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
        var statisticGenre = books.GroupBy(x => x.Genre);
        foreach (var group in statisticGenre)
        {
            Console.WriteLine($"Genre: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"  Title: {book.Title}, Autor: {book.Author}");
            }
        }
        var averagePages = books.Average(x => x.Pages);
        foreach (var pages in books)
        {
            Console.WriteLine(pages);
        }

        var oldestBook = books.Min(x => x.Year);
        foreach (var oldest in books)
        {
            Console.WriteLine(oldest);
        }
        var youngesBook = books.Max(x => x.Year);
        foreach (var oldest in books)
        {
            Console.WriteLine(youngesBook);
        }
        var authorBook = books.Max(x => x.Author);
        foreach (var oldest in books)
        {
            Console.WriteLine(oldest);
        }

    }
}
