﻿using System;
using System.Collections.Generic;

namespace _07EntityFrameworkDatabaseFirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
