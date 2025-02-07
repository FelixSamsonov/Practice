using Microsoft.EntityFrameworkCore;
using Webfirst.Models;

namespace Webfirst.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<ParametrOfBook> Books { get; set; }
}
