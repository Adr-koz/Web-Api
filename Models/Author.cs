namespace WebApiApp.Models
{
    public class Author 
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public ICollection<Review> Reviews {get; set;}
        public ICollection<TitleAuthor> AuthorTitles{ get; set; }
    }
}