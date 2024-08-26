using Api.Models;
using Microsoft.EntityFrameworkCore; // contains DbContext, DbContextOptions, DbSet


namespace Api.Data
{
    // Note DbContext
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}