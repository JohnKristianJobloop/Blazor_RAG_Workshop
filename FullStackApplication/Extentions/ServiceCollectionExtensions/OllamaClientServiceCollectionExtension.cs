using System;
using FullStackApplication.Models.Ollama.Client;
using FullStackApplication.Models.Ollama.Options;

namespace FullStackApplication.Extentions.ServiceCollectionExtensions;

public static class OllamaClientServiceCollectionExtension
{
    extension(IServiceCollection collection)
    {
        public IServiceCollection AddOllamaClient(Action<OllamaClientOptions>? configuration = null)
        {
            collection
            .AddOptions<OllamaClientOptions>()
            .BindConfiguration("OllamaClient");

            if (configuration is not null)
            {
                collection.PostConfigure(configuration);
            }
            collection.AddSingleton<OllamaClientBase>();
            return collection;
        }
    }
}
