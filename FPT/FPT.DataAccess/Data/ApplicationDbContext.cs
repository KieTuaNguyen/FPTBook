using FPT.Models;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD
namespace FPT.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Snippet code to create constructor: ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                        
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );
        }
    }
=======
namespace FPT.DataAcess.Data
{
  public class ApplicationDbContext : DbContext
  {
    // Snippet code to create constructor: ctor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Category>().HasData(
          new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
          new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
          new Category { Id = 3, Name = "History", DisplayOrder = 3 }
      );
    }
  }
>>>>>>> dd438ed30c0d777fc96190ed8cbb0cd9517f75bd
}
