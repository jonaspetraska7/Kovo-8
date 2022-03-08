using Microsoft.EntityFrameworkCore;

namespace Kovo8.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
        public DbSet<TulpeModel> Tulpes { get; set; }
    }
}
