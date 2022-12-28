using BOS.Admin.Api.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace BOS.Admin.Api.Infrastructure
{
    public class BOSContext : DbContext
    {
        public BOSContext()
        {

        }

        public BOSContext(DbContextOptions<BOSContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Test> Tests { get; set; } = null!;

    }
}
