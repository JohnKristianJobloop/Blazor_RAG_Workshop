using System;
using System.Reflection;
using FullStackApplication.DatabaseContext;
using FullStackApplication.Models.Entities;
using FullStackApplication.Models.Ollama.Client;
using Microsoft.EntityFrameworkCore;
using Pgvector.EntityFrameworkCore;

namespace FullStackApplication.Services;

public class DadJokeSemanticSearchService(OllamaClientBase client, VectorDbContext db)
{
    public async Task<List<DadJoke>> SearchForJoke(string prompt, int count = 10)
    {
        var embeddedPrompt = await client.EmbeddTextAsync(prompt);
        var result = db.Embeddings
                        .Where(e => 1 - e.Embedding
                                            .CosineDistance(embeddedPrompt) > 0.65)
                        .Include(e => e.Joke)
                        .Select(e => e.Joke)
                        .Take(count);
        return await result.ToListAsync();
    }
}

