using FluentValidations.Application.InputModels;
using FluentValidations.Application.ViewModels;

namespace FluentValidations.Application.Services
{
    public interface IBookService
    {
        BookViewModel ProcessNewBook(BookInputModel newBook);
    }
}
