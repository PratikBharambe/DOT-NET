

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _34EntityFramework.Model
{

    [Table("Emp")]
    internal class Employee
    {

        [Key]
        [Column("Id", TypeName ="int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column("Address", TypeName ="varchar(50)")]
        public string? Address { get; set; }

    }
}
