using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLab.Model.Models
{
    public class BookAuthor
    {

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }


   
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
