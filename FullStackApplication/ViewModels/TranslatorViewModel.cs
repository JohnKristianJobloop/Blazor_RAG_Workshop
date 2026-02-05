using System;
using FullStackApplication.Models.LanguageModels;
using FullStackApplication.Models.Ollama.Client;

namespace FullStackApplication.ViewModels;

public class TranslatorViewModel(IReadOnlyList<LanguageItem> items, OllamaClientBase client)
{
    public string TextToTranslate {get;set;} = string.Empty;
    public string OriginalLanguage {get; set;} = string.Empty;
    public string TargetLanguage {get; set;} = string.Empty;
    public string OriginalLanguageCode {get; set;} = string.Empty;
    public string TargetLanguageCode {get; set;} = string.Empty;
    public string TranslatedText {get; set;} = string.Empty;
    public IReadOnlyList<LanguageItem> Items { get; init; } = items;
    public OllamaClientBase Client { get; init; } = client;
    public Action OnChange;

    public async Task Translate()
    {
        TranslatedText = await Client.GetTranslation(OriginalLanguage, OriginalLanguageCode, TargetLanguage, TargetLanguageCode, TextToTranslate);
        OnChange?.Invoke();
    }
}
