using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLab.Model.Models
{
   public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public double Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }


        // ==> "One to one relationship" between
        // Book and BookDetail
        [ForeignKey("BookDetail")]
        public int BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; }


        // ==> "One to many relationship" between
        // Book and Publisher
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }


        public ICollection<BookAuthor> BookAuthors { get; set; }
         
        // --> relationship has been removed!
        // [ForeignKey("Category")]
        //public int Category_Id { get; set; }
        //  public Category Category { get; set; }

    }
}
