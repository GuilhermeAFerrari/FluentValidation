using FluentValidations.Application.InputModels;
using FluentValidations.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidations.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookInputModel newBook)
        {
            //if (!ModelState.IsValid)
            //{
            //    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            //}

            var bookViewModel = _bookService.ProcessNewBook(newBook);
            return Ok(bookViewModel);
        }
    }
}
