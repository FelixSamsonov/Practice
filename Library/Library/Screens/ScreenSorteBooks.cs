using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens;

public class ScreenSorteBooks : IShowSorteBooks
{
    private readonly ListOfBooks listOfBooks;

    public ScreenSorteBooks(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public void ShowSorteBooks()
    {
        SorteBooks sorteBooks = new SorteBooks(listOfBooks);
        Console.WriteLine(
                            "Choose func for sorting:\r\n" +
                            "1 - Title\r\n" +
                            "2 - Author\r\n" +
                            "3 - Genre\r\n" +
                            "4-  Years\r\n" +
                            "5 - Pages\r\n" +
                            "6 - Language\r\n"
                            );
    }
}
