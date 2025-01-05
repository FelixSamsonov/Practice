using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class AddBook
{
    public string Title {  get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    private int year;
    private int pages;


    public AddBook(string title, string author, string genre, int year, int pages)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
        Pages = pages;
    }

    public int Year
    {
        get { return year; }

        set 
        {
            if (value > 0)
                year = value;
            else
                throw new ArgumentException("Year has to be more than 0");
        }
    }
    public int Pages
    {
        get { return pages; }

        set
        {
            if (value > 0)
                pages = value;
            else
                throw new ArgumentException("Pages has to be more than 0");
        }
    }
}
