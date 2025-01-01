

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03EnitiyFramworkCodeFirst.Models
{

    [Table("AudioBooks")]
    internal class AudioBooks
    {

        [Key]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column("Author", TypeName = "varchar(50)")]
        public string? Author { get; set; }

        [Column("Narrator", TypeName = "varchar(50)")]
        public string? Narrator { get; set; }

    }

}
