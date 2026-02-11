using System;
using FullStackApplication.DatabaseContext;
using FullStackApplication.Models.Entities;
using FullStackApplication.Models.Ollama.Client;
using Microsoft.EntityFrameworkCore;

namespace FullStackApplication.Services.Seeders;

public static class DadJokeSeeder
{
    public static async Task SeedAsync(
        VectorDbContext db,
        OllamaClientBase client,
        IEnumerable<DadJoke> Jokes,
        CancellationToken ct = default!
    )
    {
        foreach (var joke in Jokes)
        {
            ct.ThrowIfCancellationRequested();

            var exsists = await db.Jokes.AsNoTracking().AnyAsync(j => j.Id == joke.Id);
            if (exsists) continue;

            var vector = await client.EmbeddTextAsync(joke.Joke);
            var embedding = new DadJokeEmbedding
            {
                DadJokeId = joke.Id,
                Embedding = vector,
                Joke = joke
            };
            db.Jokes.Add(joke);
            db.Embeddings.Add(embedding);

        }
        await db.SaveChangesAsync();
    }
}
