using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLab.Model.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string Location { get; set; }

        public List<Book> Books { get; set; }

    }
}
