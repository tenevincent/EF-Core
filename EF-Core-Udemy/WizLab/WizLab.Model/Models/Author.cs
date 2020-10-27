using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLab.Model.Models
{
   
   public class Author
    { 
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        
        [Required]
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string Location { get; set; }


        public ICollection<BookAuthor> BookAuthors { get; set; }



        [NotMapped]
        public string FullName   =>  $"{FirstName} {LastName}";
         
         
    }
}
