using Microsoft.AspNetCore.Mvc;
using Webfirst.Models;
using Webfirst.Models.Services;

namespace Webfirst.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksApiController : Controller
{
    private readonly BookService _bookService;
    public BooksApiController(BookService bookService)
    {
        _bookService = bookService;
    }
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }
    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }
        return Ok(book);
    }
   
    [HttpPost]
    public IActionResult AddBook([FromBody]ParametrOfBook newBook)
    {
        if (ModelState.IsValid)
        {
            _bookService.AddBook(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id}, newBook);
        }
        return BadRequest(ModelState);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] ParametrOfBook updatedBook)
    {
        if (id != updatedBook.Id) return BadRequest();

        var book = _bookService.GetBookById(id);
        if (book == null) return NotFound();

        _bookService.UpdateBook(updatedBook);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = _bookService.GetBookById(id);
        if (book == null) return NotFound();

        _bookService.DeleteBook(id);
        return NoContent();
    }

}
