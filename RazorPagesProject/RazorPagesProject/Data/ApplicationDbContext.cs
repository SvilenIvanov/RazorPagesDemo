
using Microsoft.EntityFrameworkCore;
using RazorPagesProject.Model;

namespace RazorPagesProject.Data {
    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }
        public DbSet<Category> Category { get; set; }

    }
}
