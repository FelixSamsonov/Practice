using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class GroupBooks
{
    private readonly ListOfBooks listOfBooks;

    public GroupBooks(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public void GroupByAuthor()
    {
        var groupAutor = listOfBooks.Books.GroupBy(x => x.Title).ToList();
        foreach (var group in groupAutor)
        {
            Console.WriteLine($"Autor: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"Title: {book.Title}");
            }
        }
    }
    public void GroupByGenre()
    {
        var groupGenre = listOfBooks.Books.GroupBy(x => x.Genre).ToList();
        foreach (var group in groupGenre)
        {
            Console.WriteLine($"Genre: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
    public void GroupByYear()
    {
        var groupYear = listOfBooks.Books.GroupBy(x => x.Year).ToList();
        foreach (var group in groupYear)
        {
            Console.WriteLine($"Year: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
        
    //public void ShowAllGroupBooks()
    //{
    //    if (listOfBooks.Books.Count == 0)
    //    {
    //        Console.WriteLine("List of books is empty.");
    //        return;
    //    }

    //    foreach (var group in listOfBooks.Books)
    //    {
    //        Console.WriteLine($"Autor: {group.Key}");
    //        foreach (var book in group)
    //        {
    //            Console.WriteLine($"  Title: {book.Title}, Author: {book.Author}");
    //        }
    //    }
    //}

}

