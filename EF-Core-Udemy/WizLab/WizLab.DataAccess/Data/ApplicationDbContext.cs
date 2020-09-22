using Microsoft.EntityFrameworkCore;
using WizLab.DataAccess.FluentConfig;
using WizLab.Model;
using WizLab.Model.Models;
using WizLib.Models.Models;

namespace WizLab.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //composite key
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });

            ////category table name and column name
            //modelBuilder.Entity<Category>().ToTable("tbl_category");
            //modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");


            modelBuilder.ApplyConfiguration(new FluentBookDetailsConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());          
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());


            modelBuilder.Entity<BookDetailsFromView>().HasNoKey().ToView("GetOnlyBookDetails");


    

        }



        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        public DbSet<Fluent_BookDetail> FluentBookDetails { get; set; }
        public DbSet<Fluent_Book> FluentBooks { get; set; }
        public DbSet<Fluent_Author> FluentAuthors { get; set; }
        public DbSet<Fluent_Publisher> FluentPublishers { get; set; }




    }

}
