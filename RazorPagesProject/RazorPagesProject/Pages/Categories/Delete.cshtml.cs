using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorPagesProject.Data;
using RazorPagesProject.Model;

namespace RazorPagesProject.Pages.Categories
{
    //[BindProperties]
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db) {
            _db = db;
        }
        
        public void OnGet(int id)
        {
            Category = _db.Category.SingleOrDefault(i => i.Id == id);
        }

        public async Task<IActionResult> OnPost() {
            //Category? category = _db.Category.SingleOrDefault(i => i.Id == id);
            Category? category = _db.Category.SingleOrDefault(i => i.Id == Category.Id);
            
            if (category != null) {
                _db.Remove(category);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }


            
            return Page();
        }
    }
}
