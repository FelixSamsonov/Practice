using Library.Interfaces;
using Library.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Buttons : IShowStartPage
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
            StartScreenEnglish startScreenEnglish = new StartScreenEnglish();
            startScreenEnglish.StartPage();
            ScreenChoiceOfAction choiceOfAction = new ScreenChoiceOfAction(listOfBooks);
            choiceOfAction.ShowAction();
        }
    }
}
