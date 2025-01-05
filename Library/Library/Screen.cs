using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Screen
{
    private readonly ListOfBooks _listOfBooks;

    public Screen()
    {
        _listOfBooks = new ListOfBooks();
    }

    public void Start()
    {
        Buttons buttons = new Buttons(_listOfBooks);
        buttons.ButtonАFunctionality();
    }
}



