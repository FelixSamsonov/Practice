using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Buttons
{
    private List<AddBook> library = new List<AddBook>();
    public string ChoseButton { get; set; }

    public void ButtonАFunctionality(string ChoseButton)
    {
        while (true) 
        {
            switch (ChoseButton)
            {
                case "1":
                    Console.WriteLine("Input next parametrs for book: ");
                    Console.WriteLine("Title: ");
                    string inputTitle = Console.ReadLine();
                    Console.WriteLine("Author: ");
                    string inputAuthor = Console.ReadLine();
                    Console.WriteLine("Genre: ");
                    string inputGenre = Console.ReadLine();
                    Console.WriteLine("Year: ");
                    int.TryParse(Console.ReadLine(), out int inputYear);
                    Console.WriteLine("Pages: ");
                    int.TryParse(Console.ReadLine(), out int inputPages);
                    AddBook newbook = new AddBook(inputTitle, inputAuthor, inputGenre, inputYear, inputPages);
                    library.Add(newbook);
                    break;
                case "2":
                    Console.WriteLine("You can search for books using the following parameters: ");
                    BookSearch bookSearch = new BookSearch();
                    var inputSearch = Console.ReadLine();
                    if (int.TryParse(inputSearch, out int bookNumber))
                    {
                        bookSearch.SearchByYear(bookNumber);
                        bookSearch.SearchByPages(bookNumber);
                        bookSearch.ShowAllSearchedBooks();
                    }
                    else
                    {
                        bookSearch.SearchByAutor(inputSearch);
                        bookSearch.SearchByTitle(inputSearch);
                        bookSearch.SearchByGenre(inputSearch);
                        bookSearch.ShowAllSearchedBooks();
                    }
                    break;
                case "3":
                    return;
                case "4":
                    return;
                case "5":
                    return;
                case "6":
                    return;
                case "0":
                    return;
                default:
                    Console.WriteLine("Input number don't work");
                    break;
            }
        }
    }
}
