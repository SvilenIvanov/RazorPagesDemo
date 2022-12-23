using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorPagesProject.Data;
using RazorPagesProject.Model;

namespace RazorPagesProject.Pages.Categories
{
    //[BindProperties]
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db) {
            _db = db;
        }
        
        public void OnGet()
        { 
        }

        public async Task<IActionResult> OnPost() {
            if (Category.Name == Category.DisplayOrder.ToString()) {
                ModelState.AddModelError("Category.Name", "The category name cannot be the same as the display order.");
            }
            if (ModelState.IsValid) {
                await _db.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["SuccessOperation"] = "Category was created successfully.";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
