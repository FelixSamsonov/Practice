using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens;

public class ScreenChoiceOfSort : IShowChoiseOfSort
    {
    private readonly ListOfBooks listOfBooks;
public ScreenChoiceOfSort(ListOfBooks listOfBooks)
{
    this.listOfBooks = listOfBooks;
}
    public void ShowChoiceOfSort()
    {
        SorteBooks sorteBooks = new SorteBooks(listOfBooks);
        string? choiceOfSort = Console.ReadLine();
        if (byte.TryParse(choiceOfSort, out byte sortOptions))
        {
            switch (sortOptions)
            {
                case 1:
                    sorteBooks.SortByTitle();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                case 2:
                    sorteBooks.SortByAuthor();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                case 3:
                    sorteBooks.SortByGenre();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                case 4:
                    sorteBooks.SortByYear();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                case 5:
                    sorteBooks.SortByPages();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                case 6:
                    sorteBooks.SortByLanguage();
                    sorteBooks.ShowAllSortedBooks();
                    break;
                default:
                    Console.WriteLine("You chose non-existent parametr!");
                    break;
            }
        }
        else
            Console.WriteLine("You enter non-numeric value!");
    }
}
