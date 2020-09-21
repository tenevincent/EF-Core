using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLab.Model.Models
{

    [Table("tb_Genre")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string  GenreName { get; set; }

        public string DisplayOrder { get; set; }

    }
}
