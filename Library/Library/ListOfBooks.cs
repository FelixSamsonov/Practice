using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class ListOfBooks
{
    public List<AddBook> Books { get; private set;} = new List<AddBook>();

    public void AddBookToList(AddBook book)
    {
        Books.Add(book);
        Console.WriteLine($"Назва: {book.Title}, Автор: {book.Author} was successfully added.");
    }
    public void ShowBooks()
    {
        if (Books.Count == 0)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        Console.WriteLine("List of books: ");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year: {book.Year}, Pages: {book.Pages}");
        }
    }
}
