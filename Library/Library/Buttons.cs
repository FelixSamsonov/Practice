using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Buttons
{
    private readonly ListOfBooks listOfBooks;

    public Buttons(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }

    public void ButtonАFunctionality()
    {
        while (true)
        {
            Console.WriteLine(
                                     "Choose func:\r\n" +
                                     "1 - Add book\r\n" +
                                     "2 - Search books\r\n" +
                                     "3 - Sort books\r\n" +
                                     "4 - Group books\r\n" +
                                     "5 - Statistic\r\n" +
                                     "6 - Show all books\r\n" +
                                     "0 - Exit"
                            );

            string inputFunc = Console.ReadLine();
            switch (inputFunc)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    Console.WriteLine("Enter search parameter : ");
                    BookSearch bookSearch = new BookSearch(listOfBooks);
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
                    SorteBooks sorteBooks = new SorteBooks(listOfBooks);
                    Console.WriteLine(
                                        "Choose func for sorting:\r\n" +
                                        "1 - Title\r\n" +
                                        "2 - Author\r\n" +
                                        "3 - Genre\r\n" +
                                        "4-  Years\r\n" +
                                        "5 - Pages\r\n"
                                     );
                    string chooseSort = Console.ReadLine();
                    if (int.TryParse(chooseSort, out int sortTitle))
                    {
                        switch (chooseSort)
                        {
                            case "1":
                                sorteBooks.SortByTitle();
                                sorteBooks.ShowAllSortedBooks();
                                break;
                            case "2":
                                sorteBooks.SortByAuthor();
                                sorteBooks.ShowAllSortedBooks();
                                break;
                            case "3":
                                sorteBooks.SortByGenre();
                                sorteBooks.ShowAllSortedBooks();
                                break;
                            case "4":
                                sorteBooks.SortByYear();
                                sorteBooks.ShowAllSortedBooks();
                                break;
                            case "5":
                                sorteBooks.SortByPages();
                                sorteBooks.ShowAllSortedBooks();
                                break;
                            default:
                                Console.WriteLine("You chose non-existent parametr!");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("You enter non-numeric value!");
                    break;
                case "4":
                    GroupBooks groupBooks = new GroupBooks(listOfBooks);
                    Console.WriteLine(
                                        "Choose func for grouping:\r\n" +
                                        "1 - Author\r\n" +
                                        "2 - Genre\r\n" +
                                        "3 - Year\r\n"
                                      );
                    string chooseGroup = Console.ReadLine();
                    if (int.TryParse(chooseGroup, out int sortGroup))
                    {
                        switch (chooseGroup)
                        {
                            case "1":
                                groupBooks.GroupByAuthor();
                                break;
                            case "2":
                                groupBooks.GroupByGenre();
                                break;
                            case "3":
                                groupBooks.GroupByYear();
                                break;
                            default:
                                Console.WriteLine("You chose non-existent parametr!");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("You enter non-numeric value!");
                        break;   
                case "5":
                    Statistic statistic = new Statistic(listOfBooks);
                    statistic.ShowStatistic();
                    break;
                case "6":
                    this.listOfBooks.ShowBooks();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Input number don't work");
                    break;
            }
        }
    }
    private void AddBook()
    {
        Console.WriteLine("Enter the details for the new book:");

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("Genre: ");
        string genre = Console.ReadLine();

        Console.Write("Year: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year <= 0)
        {
            Console.WriteLine("Invalid year.");
            return;
        }

        Console.Write("Pages: ");
        if (!int.TryParse(Console.ReadLine(), out int pages) || pages <= 0)
        {
            Console.WriteLine("Invalid page count.");
            return;
        }

        AddBook book = new AddBook(title, author, genre, year, pages);
        this.listOfBooks.AddBookToList(book);
    }
}
