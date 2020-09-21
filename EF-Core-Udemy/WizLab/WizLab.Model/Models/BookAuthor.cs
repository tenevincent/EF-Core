﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLab.Model.Models
{
    public class BookAuthor
    {
        //[Key]
        [ForeignKey("Book")]
        public int Book_Id { get; set; }
        
        //[Key]
        [ForeignKey("Author")]
        public int Author_Id { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
