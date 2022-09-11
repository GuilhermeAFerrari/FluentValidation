using FluentValidations.Application.InputModels;
using FluentValidations.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidations.Controllers
{
    [Route("api/[controller]")]
    public class BooksStoresController : ControllerBase
    {
        private readonly IBooksStoreService _booksStoreService;

        public BooksStoresController(IBooksStoreService booksService)
        {
            _booksStoreService = booksService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BooksStoreInputModel newBookStore)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            var booksStoreViewModel = _booksStoreService.ProcessBooksStore(newBookStore);
            return Ok(booksStoreViewModel);
        }
    }
}
