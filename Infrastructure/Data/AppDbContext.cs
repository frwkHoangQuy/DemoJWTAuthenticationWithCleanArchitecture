using Microsoft.EntityFrameworkCore;
using Domain.Enities;
namespace Infrastructure.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options){ }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}
