using FPTBook.Models;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Snippet code to create constructor: ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
