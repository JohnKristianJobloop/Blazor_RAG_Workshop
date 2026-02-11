using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pgvector;

namespace FullStackApplication.Models.Entities;

public class DadJokeEmbedding
{
    [Key]
    public int Id {get;init;}
    [ForeignKey(nameof(Joke))]
    public string DadJokeId {get; init;}
    public Vector Embedding {get;init;}
    public DadJoke Joke {get; init;}
}
