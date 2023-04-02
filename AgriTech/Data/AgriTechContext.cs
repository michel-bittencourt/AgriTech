using Microsoft.EntityFrameworkCore;
using AgriTech.Models;

namespace AgriTech.Data
{
    public class AgriTechContext : DbContext
    {
        public AgriTechContext (DbContextOptions<AgriTechContext> options)
            : base(options)
        {
        }

        public DbSet<Adubo> Adubo { get; set; }
    }
}
