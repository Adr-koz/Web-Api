namespace WebApiApp.Models
{
    public class Title
    {
        public int Id {get; set;}
        public string BookTitle {get; set;}
        public Genre Genre {get; set;}
        public Author Author {get; set;}
        public Review Review {get; set;}
        public ICollection<Publisher> Publishers {get; set;}
        public ICollection<Review> Reviews {get; set;}
        public ICollection<TitlePublisher> TitlePublishers {get; set;}
        public ICollection<TitleGenre> TitleGenres {get; set;}
        public ICollection<TitleAuthor> TitleAuthors {get; set;}
    }
}