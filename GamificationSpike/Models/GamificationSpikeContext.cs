using Microsoft.EntityFrameworkCore;

namespace GamificationSpike.Models
{
    public class GamificationSpikeContext : DbContext
    {
        public GamificationSpikeContext(DbContextOptions<GamificationSpikeContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Step> Steps { get; set; }
    }
}