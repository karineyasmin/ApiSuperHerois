
using Microsoft.EntityFrameworkCore;
using SuperHerois.Api.Data.ContextConfigurations;
using SuperHerois.Api.Entities;

namespace SuperHerois.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var ids = new Guid[] {Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        builder.ApplyConfiguration(new SuperHeroiContextConfiguration(ids));
        builder.ApplyConfiguration(new SuperPoderContextConfiguration(ids));
        builder.ApplyConfiguration(new FilmeContextConfiguration(ids));

    }

    public DbSet<SuperHeroi> SuperHerois { get; set; }
    public DbSet<SuperPoder> SuperPoderes { get; set; }
    public DbSet<Filme> Filmes { get; set; }
    
}

