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
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Tenant> Tenants { get; set; } = null!;


    }
}
