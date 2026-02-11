using System;
using FullStackApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStackApplication.DatabaseContext;

public class VectorDbContext(DbContextOptions<VectorDbContext> options) : DbContext(options)
{
    public DbSet<DadJoke> Jokes => Set<DadJoke>();
    public DbSet<DadJokeEmbedding> Embeddings => Set<DadJokeEmbedding>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("vector");

        modelBuilder.Entity<DadJokeEmbedding>(e =>
        {
            e.Property(d => d.Embedding).HasColumnType("vector(768)");
        });
    }
}
