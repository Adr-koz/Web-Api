using Microsoft.EntityFrameworkCore;
using WebApiApp.Models;

namespace WebApiApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        public DbSet<Publisher> Publishers {get; set;}
        public DbSet<Genre> Genres {get; set;}
        public DbSet<Title> Titles {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Reviewer> Reviewers {get; set;}
        public DbSet<Review> Reviews {get; set;}
        public DbSet<TitleAuthor> TitleAuthors {get; set;}
        public DbSet<TitleGenre> TitleGenres {get; set;}
        public DbSet<TitlePublisher> TitlePublishers {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<TitlePublisher>()
                .HasKey(tp => new { tp. TitleId, tp.PublisherId });
        modelBuilder.Entity<TitlePublisher>()
                .HasOne(t => t.BookTitle)
                .WithMany(tp => tp.TitlePublishers)
                .HasForeignKey(t => t.TitleId);
        modelBuilder.Entity<TitlePublisher>()
                .HasOne(p => p.PublisherName)
                .WithMany(tp => tp.TitlePublishers)
                .HasForeignKey(p => p.PublisherId);

        modelBuilder.Entity<TitleGenre>()
                .HasKey(tg => new { tg. TitleId, tg.GenreId });
        modelBuilder.Entity<TitleGenre>()
                .HasOne(t => t.BookTitle)
                .WithMany(tg => tg.TitleGenres)
                .HasForeignKey(t => t.TitleId);
        modelBuilder.Entity<TitleGenre>()
                .HasOne(g => g.GenreName)
                .WithMany(tg => tg.TitleGenres)
                .HasForeignKey(g => g.GenreId);

        modelBuilder.Entity<TitleAuthor>()
                .HasKey(ta => new { ta. TitleId, ta.AuthorId });
        modelBuilder.Entity<TitleAuthor>()
                .HasOne(t => t.BookTitle)
                .WithMany(ta => ta.TitleAuthors)
                .HasForeignKey(t => t.TitleId);
        modelBuilder.Entity<TitleAuthor>()
                .HasOne(a => a.Author)
                .WithMany(ta => ta.TitleAuthors)
                .HasForeignKey(a => a.AuthorId);

        modelBuilder.Entity<Review>()
                .HasOne(r => r.BookTitle) 
                .WithMany(t => t.Reviews);
        }


    }
    
}