using Microsoft.EntityFrameworkCore;
using ServerTask.Entities;

namespace ServerTask.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    public DbSet<Info> Infos => Set<Info>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // seed author table
        modelBuilder.Entity<Info>().HasData(
            new Info {
                slackUsername = "Ese_O",
                backend = true,
                age = 28,
                bio = "Hereos never die!"
            }
        );
    }

}
        