using Microsoft.EntityFrameworkCore;

namespace Sillystringz.Models
{
    public class SillystringzContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        public SillystringzContext(DbContextOptions options) : base(options) { }
    }
}