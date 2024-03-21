namespace WebApiApp.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Title> Titles {get; set;}
        public ICollection<TitlePublisher> TitlePublishers {get; set;}

    }
}