using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class ListOfBooks
{
    public List<AddBook> books = new List<AddBook>();

    public void AddBookToList(string title, string author, string genre, int year, int pages)
    {
        AddBook newBook = new AddBook(title, author, genre, year, pages);
        books.Add(newBook);
        Console.WriteLine($"Назва: {newBook.Title}, Автор: {newBook.Author} was successfully added.");
    }
    public void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Список книг порожній.");
            return;
        }

        Console.WriteLine("Список книг: ");
        foreach (var book in books)
        {
            Console.WriteLine($"Назва: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}, Рік: {book.Year}, Сторінок: {book.Pages}");
        }
    }
}
