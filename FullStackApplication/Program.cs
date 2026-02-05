using FullStackApplication.Components;
using FullStackApplication.Extentions.ServiceCollectionExtensions;
using FullStackApplication.Models.Ollama.Options;
using FullStackApplication.Services;
using FullStackApplication.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();
builder.Services.AddTransient<RandomDadJokeViewModel>();
builder.Services.AddTransient<DadJokeQueryViewModel>();
builder.Services.AddTransient<DadJokeQueryService>();
builder.Services.AddScoped<TranslatorViewModel>();
builder.Services.AddLanguageCatalog();
builder.Services.AddOllamaClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
