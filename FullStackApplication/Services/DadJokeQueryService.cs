using System;
using System.Net.Http.Headers;
using FullStackApplication.Extentions;
using FullStackApplication.Models;
using FullStackApplication.ViewModels;

namespace FullStackApplication.Services;

public class DadJokeQueryService(IHttpClientFactory factory)
{
    public async Task<DadJokeCollection?> FetchQuery(string baseAddress, DadJokeQueryViewModel model)
    {
        var client = factory.CreateClient();
        client.BaseAddress = new Uri(model.ToQueryString(baseAddress));
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var response = await client.GetAsync("");
        return await response.Content.ReadFromJsonAsync<DadJokeCollection>();
    }
}
