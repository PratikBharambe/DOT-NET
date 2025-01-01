using System;
using System.Collections.Generic;

namespace _07EntityFrameworkDatabaseFirst.Models
{
    public partial class AudioBook
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Narrator { get; set; }
    }
}
