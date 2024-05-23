using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace InfrastructureLayer;

public class TopFilmsDbContext : DbContext
{
    public TopFilmsDbContext(DbContextOptions<TopFilmsDbContext> options): base(options)
    {
        
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
            eb.HasMany(w=>w.Comments)
            .WithOne(x => x.Movie)
            .HasForeignKey(c=>c.MovieId);

            eb.HasOne(x=>x.Genres)
            .WithMany(x=>x.Movies)
            .HasForeignKey(c=>c.GenreId);

            eb.HasMany(w => w.Photos)
            .WithOne(x => x.Movie)
            .HasForeignKey(c => c.MovieId);

            eb.HasOne(w=>w.Studios)
            .WithMany(x=>x.Movies)
            .HasForeignKey(c=>c.StudioId);

            eb.HasOne(w => w.Trailer)
            .WithOne(x => x.Movie)
            .HasForeignKey<Trailer>(c => c.MovieId);
        });
    }
}
