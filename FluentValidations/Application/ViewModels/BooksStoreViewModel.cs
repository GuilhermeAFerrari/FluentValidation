namespace FluentValidations.Application.ViewModels
{
    public class BooksStoreViewModel
    {
        public BooksStoreViewModel(Guid secondId, string name, string city)
        {
            SecondId = secondId;
            Name = name;
            City = city;
        }

        public Guid SecondId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
