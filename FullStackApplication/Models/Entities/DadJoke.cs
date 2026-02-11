using System;
using System.ComponentModel.DataAnnotations;

namespace FullStackApplication.Models.Entities;

public class DadJoke
{
    [Key]
    public required string Id {get; init;}
    public required string Joke {get;init;}
    public DadJokeEmbedding? Embedding {get; init;}
}
