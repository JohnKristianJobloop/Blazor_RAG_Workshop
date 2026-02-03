using System;
using System.ComponentModel.DataAnnotations;

namespace FullStackApplication.ViewModels;

public class DadJokeQueryViewModel
{
    [Range(1, 1000)]
    public int Page {get;set;}
    [Required(AllowEmptyStrings = true)]
    public string Term {get;set;} = string.Empty;
    [Range(1,1000)]
    public int Limit {get;set;}
}
