using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            await _db.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
