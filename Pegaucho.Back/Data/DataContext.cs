using Microsoft.EntityFrameworkCore;
using Pegaucho.Shared.Entities;

namespace Pegaucho.Back.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<ProductoInventario>ProductoInventarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
