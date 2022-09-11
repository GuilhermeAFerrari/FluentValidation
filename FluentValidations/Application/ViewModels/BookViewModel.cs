namespace FluentValidations.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(Guid id, string title, string author, string subject, int pages)
        {
            SecondId = id;
            Title = title;
            Author = author;
            Subject = subject;
            Pages = pages;
        }

        public Guid SecondId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public int Pages { get; set; }
    }
}
