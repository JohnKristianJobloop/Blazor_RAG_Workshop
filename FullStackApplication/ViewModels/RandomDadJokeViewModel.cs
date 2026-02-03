using System;
using System.Net.Http.Headers;
using FullStackApplication.Models;

namespace FullStackApplication.ViewModels;

public class RandomDadJokeViewModel(IHttpClientFactory factory)
{
    public string Joke {get; private set;} = "Dad Joke loading...";
    private const int _retries = 3;
    public event Action OnChange;

    private RandomDadJoke? RandomJoke {get;set;}

    public async Task FetchRandomJoke()
    {
        int tries = 0;
        do
        {
            var client = factory.CreateClient();
            client.BaseAddress = new Uri("https://icanhazdadjoke.com");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("/");
            RandomJoke = await response.Content.ReadFromJsonAsync<RandomDadJoke>();
            if (RandomJoke is null) continue;
            Joke = RandomJoke.Joke;
            NotifyStateHasChanged();
        } while(RandomJoke?.Status is not 200 && tries++ <= _retries);

        if (RandomJoke is null) Joke = "Failed to fetch joke...";
    }
    private void NotifyStateHasChanged() => OnChange?.Invoke();
}
