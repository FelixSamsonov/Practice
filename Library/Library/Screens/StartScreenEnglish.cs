using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens;

public class StartScreenEnglish : IShowStartPage
{
    public void StartPage()
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
    }
}
