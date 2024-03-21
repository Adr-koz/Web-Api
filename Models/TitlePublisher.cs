namespace WebApiApp.Models
{
    public class TitlePublisher
    {
        public int TitleId { get; set; }
        public int PublisherId { get; set; }
        public Title BookTitle { get; set; }
        public Publisher PublisherName { get; set; }
    }
}