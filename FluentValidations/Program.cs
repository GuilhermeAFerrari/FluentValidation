using FluentValidation.AspNetCore;
using FluentValidations.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBooksStoreService, BooksStoreService>();

builder.Services.AddControllers();

builder.Services.AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
    config.AutomaticValidationEnabled = true;
});

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Service running");

app.Run();
