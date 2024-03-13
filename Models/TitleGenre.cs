namespace WebApiApp.Models
{
    public class TitleGenre
    {
        public int TitleId { get; set; }
        public int GenreId { get; set; }
        public Title BookTitle { get; set; }
        public Genre GenreName { get; set; }
    }
}