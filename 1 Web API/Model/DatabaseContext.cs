using Microsoft.EntityFrameworkCore;

namespace CancerCouncilPalindrome.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
        }

        public DbSet<PalindromeData> AddPalindromeNames { get; set; }
    }
}