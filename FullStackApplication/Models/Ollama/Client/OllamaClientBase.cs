using System;
using FullStackApplication.Models.Ollama.Options;
using Microsoft.Extensions.Options;
using Ollama;

namespace FullStackApplication.Models.Ollama.Client;

public class OllamaClientBase
{
    private OllamaApiClient Client {get; init;}
    private readonly string _systemMessage;
    private readonly string _model;

    public OllamaClientBase(IOptions<OllamaClientOptions> options)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(options.Value.Host)
        };

        Client = new OllamaApiClient(httpClient);
        _systemMessage = options.Value.SystemMessage;
        _model = options.Value.Model;
    }
    public async Task<string> GetTranslation(
        string sourceLang,
        string sourceCode,
        string targetLang,
        string targetCode,
        string textToTranslate
    )
    {
        var chat = Client.Chat(
            model: _model,
            systemMessage: FormatMessage(sourceLang, sourceCode, targetLang, targetCode, textToTranslate)
        );
        chat.RequestOptions = new RequestOptions
        {
            NumCtx = 4096
        };

        var result = await chat.SendAsync();
        return result.Content;
    }
    private string FormatMessage(
        string sourceLang,
        string sourceCode,
        string targetLang,
        string targetCode,
        string textToTranslate
    ) => string.Format(_systemMessage, sourceLang, sourceCode, targetLang, targetCode, textToTranslate);
}
