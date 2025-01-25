using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class AddBook
{
    private readonly ListOfBooks listOfBooks;

    public AddBook(ListOfBooks listOfBooks)
    {
        this.listOfBooks = listOfBooks;
    }
    public void AddingBook()
    {
        Console.WriteLine("Enter the details for the new book:");

        Console.Write("Title: ");
        string? title = Console.ReadLine();

        Console.Write("Author: ");
        string? author = Console.ReadLine();

        Console.WriteLine(
                                        "Choose type of genre:\r\n" +
                                        "1 - Fiction\r\n" +
                                        "2 - Non-Fiction\r\n"
                                        );
        string? genre = "Unknown";
        string? genreNumb = Console.ReadLine();
        if (byte.TryParse(genreNumb, out byte genreType))
        {
            switch (genreType)
            {
                case 1:
                    Console.WriteLine(
                        "Choose genre for book:\r\n" +
                                        "1 - Fantasy\r\n" +
                                        "2 - Science Fiction\r\n" +
                                        "3 - Romance\r\n" +
                                        "4 - Detective\r\n" +
                                        "5 - Thriller\r\n" +
                                        "6 - Horror\r\n" +
                                        "7 - Historical Fiction\\r\n" +
                                        "8 - Realistic Fiction\r\n"
                        );
                    string? genreFiction = Console.ReadLine();
                    if (byte.TryParse(genreFiction, out byte genreTypeFiction))
                    {
                        switch (genreTypeFiction)
                        {
                            case 1:
                                genre = "Fantasy";
                                break;
                            case 2:
                                genre = "Science Fiction";
                                break;
                            case 3:
                                genre = "Romance";
                                break;
                            case 4:
                                genre = "Detective";
                                break;
                            case 5:
                                genre = "Thriller";
                                break;
                            case 6:
                                genre = "Horror";
                                break;
                            case 7:
                                genre = "Historical Fiction";
                                break;
                            case 8:
                                genre = "Realistic Fiction";
                                break;
                            case 9:
                                genre = "Novel";
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Your choice doesn't exist");
                    break;
                case 2:
                    Console.WriteLine(
                        "Choose genre for book:\r\n" +
                                        "1 - Biographies and Memoirs\r\n" +
                                        "2 - Documentary\r\n" +
                                        "3 - Self-help\r\n" +
                                        "4 - Popular Science\r\n" +
                                        "5 - Reference\r\n"
                        );
                    string? genreNonFiction = Console.ReadLine();
                    if (byte.TryParse(genreNonFiction, out byte genreTypeNonFiction))
                    {
                        switch (genreTypeNonFiction)
                        {
                            case 1:
                                genre = "Biographies and Memoirs";
                                break;
                            case 2:
                                genre = "Documentary";
                                break;
                            case 3:
                                genre = "Self-help";
                                break;
                            case 4:
                                genre = "Popular Science";
                                break;
                            case 5:
                                genre = "Reference";
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Invalid choice");
                    break;
                default:
                    Console.WriteLine("You chose incorrect variant");
                    return;
            }
        }


        Console.Write("Year: ");
        if (!ushort.TryParse(Console.ReadLine(), out ushort year))
        {
            Console.WriteLine("Invalid year.");
            return;
        }

        Console.Write("Pages: ");
        if (!ushort.TryParse(Console.ReadLine(), out ushort pages))
        {
            Console.WriteLine("Invalid page count.");
            return;
        }
        Console.Write(
                "Choose language your book:\r\n" +
                                        "1 - English\r\n" +
                                        "2 - Ukrainian\r\n" +
                                        "3 - Russian\r\n"
                                        );
        string? inputLanguage = Console.ReadLine();
        string? language = "unknovn";
        if (byte.TryParse(inputLanguage, out byte ChosenLanguage))
        {
            switch (ChosenLanguage)
            {
                case 1:
                    language = "English";
                    break;
                case 2:
                    language = "Ukrainian";
                    break;
                case 3:
                    language = "Russian";
                    break;
            }
        }
        else
            Console.WriteLine("You chose incorrect variant");

        ParametrsForBook book = new ParametrsForBook(title, author, genre, year, pages, language);
        this.listOfBooks.AddBookToList(book);
    }
}

