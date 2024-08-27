using CodeFirstRadore.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRadore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<Kitap> Kitap { get; set; }

    }
}
