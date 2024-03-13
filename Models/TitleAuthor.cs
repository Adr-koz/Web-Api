namespace WebApiApp.Models
{
    public class TitleAuthor
    {
        public int TitleId { get; set; }
        public int AuthorId { get; set; }
        public Title BookTitle { get; set; }
        public Author FirstName { get; set; }
        public Author LastName { get; set; }
    }
}