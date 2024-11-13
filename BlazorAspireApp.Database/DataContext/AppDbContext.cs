using BlazorAspireApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAspireApp.Database.DataContext
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
