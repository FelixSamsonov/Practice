using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class BookSearch
{
    private List<AddBook> books = new List<AddBook>();

    public IEnumerable<AddBook> SearchByTitle(string title)
    {
        return books.Where(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByAutor(string author)
    {
        return books.Where(x => x.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByGenre(string genre)
    {
        return books.Where(x => x.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase));
    }
    public IEnumerable<AddBook> SearchByYear(int year)
    {
        return books.Where(x => x.Year == year);
    }
    public IEnumerable<AddBook> SearchByPages(int pages)
    {
        return books.Where(x => x.Pages == pages);
    }
    public void ShowAllSearchedBooks()
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

