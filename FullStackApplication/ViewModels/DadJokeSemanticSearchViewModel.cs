using System;
using FullStackApplication.Models.Entities;
using FullStackApplication.Services;

namespace FullStackApplication.ViewModels;

public class DadJokeSemanticSearchViewModel(DadJokeSemanticSearchService service)
{
    public List<DadJoke> Jokes {get;private set;} = [];

    public string Prompt {get;set;} = string.Empty;

    public Action OnChange;

    public async Task SearchBasedOnPrompt()
    {
        Jokes = await service.SearchForJoke(Prompt);
    }

    public void NotifyHasChanged() => OnChange?.Invoke();
}
