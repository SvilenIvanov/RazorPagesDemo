﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RazorPagesProject.Model {
    public class Category {


        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
    }
}
