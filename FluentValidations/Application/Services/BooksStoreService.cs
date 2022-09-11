using FluentValidations.Application.InputModels;
using FluentValidations.Application.ViewModels;

namespace FluentValidations.Application.Services
{
    public class BooksStoreService : IBooksStoreService
    {
        public BooksStoreViewModel ProcessBooksStore(BooksStoreInputModel newBooksStore)
        {
            BooksStoreViewModel bookStore = new BooksStoreViewModel(Guid.NewGuid(), newBooksStore.Name, newBooksStore.City);
            return bookStore;
        }
    }
}
