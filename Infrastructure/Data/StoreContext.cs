using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)   // created a connection string in appsettings.development
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}