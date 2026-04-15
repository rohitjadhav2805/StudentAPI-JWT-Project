using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System.Reflection.Emit;

namespace StudentAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasIndex(x => x.Email)
            .IsUnique();
    }
}