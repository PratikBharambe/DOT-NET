using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06EEntityFrameworkCodeFirst.Models
{

    [Table("Movies")]
    public class Movies
    {

        [Key]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; } 
    }
}
