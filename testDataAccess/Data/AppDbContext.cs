using Microsoft.EntityFrameworkCore;
using testDataAccess.Models;

namespace testDataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CharacterTest> Character { get; set; } = default!;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
