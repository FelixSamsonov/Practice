using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class SortedBook
{
    private List<AddBook> books = new List<AddBook>();
    public IEnumerable<AddBook> SortByTitle()
    {
        var sorted = books.OrderBy(books => books.Title);
        return sorted;
    }
    public IEnumerable<AddBook> SortByAutor()
    {
        var sorted = books.OrderBy(books => books.Author);
        return sorted;
    }
    public IEnumerable<AddBook> SortByGenre()
    {
        var sorted = books.OrderBy(books => books.Genre);
        return sorted;
    }
    public IEnumerable<AddBook> SortByYear()
    {
        var sorted = books.OrderBy(books => books.Year);
        return sorted;
    }
    public IEnumerable<AddBook> SortByPages()
    {
        var sorted = books.OrderBy(books => books.Pages);
        return sorted;
    }
    public void ShowAllSortedBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Список книг порожній.");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine($"Назва: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}, Рік: {book.Year}, Сторінок: {book.Pages}");
        }
    }
}
