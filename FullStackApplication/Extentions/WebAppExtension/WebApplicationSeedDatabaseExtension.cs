using System;
using FullStackApplication.DatabaseContext;
using FullStackApplication.Models.Ollama.Client;
using FullStackApplication.Services.Seeders;
using Microsoft.EntityFrameworkCore;

namespace FullStackApplication.Extentions.WebAppExtension;

public static class WebApplicationSeedDatabaseExtension
{
    extension(WebApplication app)
    {
        public async Task<WebApplication> SeedDataAsync()
        {
            using (var scope = app.Services.CreateScope())
            {
                var database = scope.ServiceProvider.GetService<VectorDbContext>();
                var client = scope.ServiceProvider.GetService<OllamaClientBase>();

                var dadJokes = DadJokeSeedData.GenerateDadJokes();

                if (!await database!.Jokes.AnyAsync()) await DadJokeSeeder.SeedAsync(database, client!, dadJokes); 
                return app;
            }
        }
    }
}
