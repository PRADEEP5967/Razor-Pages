using Microsoft.EntityFrameworkCore;
using pradeepweb.Model;

namespace pradeepweb.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Login> Login { get; set; }
}
