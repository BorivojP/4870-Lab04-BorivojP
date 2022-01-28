using Code1st_.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code1st.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Add this method to ApplicationDbContext.cs
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Team>().HasData(SampleData.GetTeams());
        modelBuilder.Entity<Player>().HasData(SampleData.GetPlayers());
        modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
        modelBuilder.Entity<City>().HasData(SampleData.GetCities());
    }

    public DbSet<Team>? Teams { get; set; }
    public DbSet<Player>? Players { get; set; }

      public DbSet<Province>? Provinces { get; set; }
    public DbSet<City>? Cities { get; set; }
}
