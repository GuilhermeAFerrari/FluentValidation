using FluentValidations.Application.InputModels;
using FluentValidations.Application.ViewModels;

namespace FluentValidations.Application.Services
{
    public interface IBooksStoreService
    {
        BooksStoreViewModel ProcessBooksStore(BooksStoreInputModel newBooksStore);
    }
}
