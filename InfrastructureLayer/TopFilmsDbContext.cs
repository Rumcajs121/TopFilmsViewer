using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer;

public class TopFilmsDbContext : DbContext
{
    public string DbPath { get; }
    public TopFilmsDbContext()
    {
        var folder = Environment.SpecialFolder.Personal;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "TopFilmsViewer.db");
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Studio> Studios { get; set; }
    public DbSet<Trailer> Trailers { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Photo> Photos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Movie>(eb =>
        {
            eb.HasMany(w => w.Genres)
            .WithOne(x => x.Movie)
            .HasForeignKey(c => c.MovieId);

            eb.HasMany(w => w.Comments)
            .WithOne(x => x.Movie)
            .HasForeignKey(c => c.MovieId);

            eb.HasMany(w => w.Photos)
            .WithOne(x => x.Movie)
            .HasForeignKey(c => c.MovieId);

            eb.HasOne(w => w.Trailer)
            .WithOne(x => x.Movie)
            .HasForeignKey<Trailer>(c => c.MovieId);
        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

}
