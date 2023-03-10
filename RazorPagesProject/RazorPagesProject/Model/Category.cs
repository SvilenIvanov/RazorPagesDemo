using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RazorPagesProject.Model {
    public class Category {


        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="The range must be between 1 and 100!")]
        public int DisplayOrder { get; set; }
    }
}
