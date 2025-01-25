using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens;

public class ScreenGroupOfBooks : IShowGroupOfBooks, IChoiceOfGrouping
{
    private readonly ListOfBooks listOfBooks;
    public ScreenGroupOfBooks(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public void ShowGroupBooks()
    {
        GroupBooks groupBooks = new GroupBooks(listOfBooks);
        Console.WriteLine(
                            "Choose func for grouping:\r\n" +
                            "1 - Author\r\n" +
                            "2 - Genre\r\n" +
                            "3 - Year\r\n" +
                            "4 - Language\r\n"
                          );
    }
    public void ChoiceOfGrouping() 
    {
        GroupBooks groupBooks = new GroupBooks(listOfBooks);
        string? optionsGroup = Console.ReadLine();
        if (byte.TryParse(optionsGroup, out byte optionGroup))
        {
            switch (optionGroup)
            {
                case 1:
                    groupBooks.GroupByAuthor();
                    break;
                case 2:
                    groupBooks.GroupByGenre();
                    break;
                case 3:
                    groupBooks.GroupByYear();
                    break;
                case 4:
                    groupBooks.GroupByLanguage();
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
