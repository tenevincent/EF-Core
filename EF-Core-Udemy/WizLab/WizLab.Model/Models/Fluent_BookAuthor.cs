﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLab.Model
{
    public class Fluent_BookAuthor
    {
       
        public int Book_Id { get; set; }
        public Fluent_Book Fluent_Book { get; set; }


        public int Author_Id { get; set; }        
        public Fluent_Author Fluent_Author { get; set; }

    }
}
