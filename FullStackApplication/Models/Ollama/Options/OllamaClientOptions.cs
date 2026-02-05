using System;

namespace FullStackApplication.Models.Ollama.Options;

public class OllamaClientOptions
{
    public required string SystemMessage {get; set;}
    public required string Model {get;set;}
    public required string Host {get;set;}
}
