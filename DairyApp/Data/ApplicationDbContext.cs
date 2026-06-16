using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DairyEntry> DairyEntries { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);
        //        modelBuilder.Entity<DairyEntry>().HasData(
        //            new DairyEntry { ID = 7, Title = "Went Hiking", Content = "Went Hiking with Joe", Created = DateTime.Now },
        //            new DairyEntry { ID = 8, Title = "Went Shopping", Content = "Went Shopping with Joe", Created = DateTime.Now },
        //            new DairyEntry { ID = 9, Title = "Went Swimming", Content = "Went Swimming with Joe", Created = DateTime.Now }
        //            );
        //    }
        //}
    }
}
