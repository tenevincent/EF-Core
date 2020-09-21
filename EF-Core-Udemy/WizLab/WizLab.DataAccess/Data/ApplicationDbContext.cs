using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WizLab.Model.Models;

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
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

        }



        public DbSet<Category> Categories { get; set; }

        public DbSet<Genre> Genres { get; set; }


        public DbSet<Book> Books { get; set; }


        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }


    }

}
