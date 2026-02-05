using System;
using System.Globalization;

namespace FullStackApplication.Models.LanguageModels;

public static class LanguageCatalog
{
    public static IReadOnlyList<LanguageItem> Build(bool includeNetrual = true, bool includeSpesific = true)
    {
        var cultureTypes = (includeNetrual ? CultureTypes.NeutralCultures : 0) | (includeSpesific ? CultureTypes.SpecificCultures : 0); 
        return CultureInfo.GetCultures(cultureTypes)
            .Where(c => !string.IsNullOrWhiteSpace(c.Name))
            .Select(c => new LanguageItem(
                Name: c.EnglishName,
                Code: c.Name
            ))
            .DistinctBy(l => l.Code)
            .OrderBy(l => l.Name)
            .ToList();
    }
}
