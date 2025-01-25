using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens;

public class ScreenChoiceOfAction : IShowAction, IShowSorteBooks
{
    private readonly ListOfBooks listOfBooks;
    public ScreenChoiceOfAction(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }

    public void ShowAction()
    {
        string? inputFunc = Console.ReadLine();
        if (byte.TryParse(inputFunc, out byte inputFuncNum))
        {
            switch (inputFuncNum)
            {
                case 1:
                    AddBook addBook = new AddBook(listOfBooks);
                    addBook.AddingBook();
                    break;
                case 2:
                    Console.WriteLine("Enter search parameter: ");
                    BookSearch bookSearch = new BookSearch(listOfBooks);
                    string? inputSearch = Console.ReadLine();
                    if (byte.TryParse(inputSearch, out byte bookNumber))
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
                case 3:
                    ScreenSorteBooks screenSorteBooks = new ScreenSorteBooks(listOfBooks);
                    screenSorteBooks.ShowSorteBooks();
                    ScreenChoiceOfSort screenChoiceOfSort = new ScreenChoiceOfSort(listOfBooks);
                    screenChoiceOfSort.ShowChoiceOfSort();
                    break;
                case 4:
                    ScreenGroupOfBooks screenGroupBooks = new ScreenGroupOfBooks(listOfBooks);
                    screenGroupBooks.ShowGroupBooks();
                    screenGroupBooks.ChoiceOfGrouping();
                    break;
                case 5:
                    Statistic statistic = new Statistic(listOfBooks);
                    statistic.ShowStatistic();
                    break;
                case 6:
                    listOfBooks.ShowBooks();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Input number don't work");
                    break;
            }
        }
        else
            Console.WriteLine("You enter non-numeric value!");
    }
}
