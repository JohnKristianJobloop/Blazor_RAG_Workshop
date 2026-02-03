using System.Text.Json.Serialization;

namespace FullStackApplication.Models;

public record RandomDadJoke([property: JsonPropertyName("id")]string Id, [property: JsonPropertyName("joke")]string Joke, [property: JsonPropertyName("status")]int Status);