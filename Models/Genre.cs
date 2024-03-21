namespace WebApiApp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Title> Titles { get; set; }
        public ICollection<TitleGenre> TitleGenres { get; set; }
    }
}