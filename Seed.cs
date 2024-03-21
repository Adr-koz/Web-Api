using WebApiApp.Data;
using WebApiApp.Models;

namespace WebApiApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.TitleAuthors.Any())
            {
                var titleAuthors = new List<TitleAuthor>()
                {
                    new TitleAuthor()
                    {
                        BookTitle = new Title()
                        {
                            BookTitle = "Winnie the Pooh",
                            TitleGenres = new List<TitleGenre>()
                            {
                                new TitleGenre { GenreName = new Genre() { GenreName = "Children's literature"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Self-centered logic of childhood",Text = "The writing really shines when you read it out loud and I enjoyed reading it as much as my kids enjoyed listening to it.",
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" }, BookTitle = new Title() { BookTitle = "Winnie the Pooh" } },
                                new Review { Title="Distinct writing style", Text = "My favorite element of the writing style were the capital letters which changed the tone of the sentence. ",
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" }, BookTitle = new Title() { BookTitle = "Winnie the Pooh" } },
                                new Review { Title="The world of Winnie-the-Pooh",Text = "There are no over-arching plots in the Pooh books. They are more a series of vignettes or perhaps short stories, bound together by book glue or, in the case of Winnie-the-Pooh, the pulling back of the curtain to reveal the author as a father telling stories to his son.",
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" }, BookTitle = new Title() { BookTitle = "Winnie the Pooh" } },
                            }
                        },
                        Author = new Author()
                        {
                            FirstName = "Alan Alexander",
                            LastName = "Milne",
                        }
                    }
                    };
                    
                dataContext.TitleAuthors.AddRange(titleAuthors);
                dataContext.SaveChanges();
            }
        }
        
    }
}

