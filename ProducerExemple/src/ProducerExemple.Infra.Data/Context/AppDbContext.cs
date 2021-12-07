using Microsoft.EntityFrameworkCore;
using ProducerExemple.Domain.Entities;

namespace ProducerExemple.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
