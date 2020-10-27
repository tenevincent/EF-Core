using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLab.Model.Models
{

    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // --> relationship has been removed!
        // 1 to many relationship
        //public List<Book> Books { get; set; }
    }
}
