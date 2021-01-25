using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //this.Database.EnsureCreated();
        }

        public DbSet<AppUser> Users { get; set; }
    }
}