using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using FluentValidations.Application.InputModels;
using FluentValidations.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidations.Application.Services
{
    public class BookService : IBookService
    {
        public BookViewModel ProcessNewBook(BookInputModel newBook)
        {
            BookViewModel book = new BookViewModel(Guid.NewGuid(), newBook.Title, newBook.Author, newBook.Subject, newBook.Pages);
            return book;
        }
    }
}
