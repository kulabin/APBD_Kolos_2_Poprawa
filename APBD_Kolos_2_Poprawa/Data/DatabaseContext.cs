using APBD_Kolos_2_Poprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2_Poprawa.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }
    
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Model1> Model1 { get; set; }
    public DbSet<Model2> Model2 { get; set; }
    public DbSet<Model3> Model3 { get; set; }
    public DbSet<Model4> Model4 { get; set; }
    public DbSet<Model5> Model5 { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model1>().HasData(new List<Model1>()
        {

        });
        modelBuilder.Entity<Model2>().HasData(new List<Model2>()
        {

        });
        modelBuilder.Entity<Model3>().HasData(new List<Model3>()
        {

        });
        modelBuilder.Entity<Model4>().HasData(new List<Model4>()
        {

        });
        modelBuilder.Entity<Model5>().HasData(new List<Model5>()
        {

        });
    }
}