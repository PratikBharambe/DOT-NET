using System;
using System.Collections.Generic;

namespace _04EntityFrameworkDatabaseFirstApproach.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Narrator { get; set; }
    }
}
