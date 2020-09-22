using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLab.Model.Models
{

    [Table("BookDetail")]
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }

        public double Weight { get; set; }


        public Book Book { get; set; }
    }
}
