using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webfirst.Models.Services;
using Webfirst.Models;
namespace Webfirst.Controllers;

public class HomeController : Controller
{
    private readonly BookService _bookService;

    public HomeController(BookService bookService)
        {
            _bookService = bookService;
        }

    public IActionResult Index()
    {
        var book = _bookService.GetAllBooks();
        return View(book);
    }
    [HttpGet]
    public IActionResult AddBook()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddBook(ParametrOfBook newBook)
    {
        if (ModelState.IsValid)
        {
            _bookService.AddBook(newBook);
            return RedirectToAction("Index");
        }
        return View(newBook);
    }

    public IActionResult EditBook(int id)
    {
        var book = _bookService.GetBookById(id);
        if(book == null) return NotFound();
        return View(book);
    }
    [HttpPost]
    public IActionResult EditBook(ParametrOfBook updateBook)
    {
        if (ModelState.IsValid)
            _bookService.UpdateBook(updateBook);
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult DeleteBook(int id)
    {
        _bookService.DeleteBook(id);
        return RedirectToAction("Index");
    }
}
