using System;
using FullStackApplication.Models.LanguageModels;

namespace FullStackApplication.Extentions.ServiceCollectionExtensions;

public static class LanguageCatalocServiceCollectionExtention
{
    extension (IServiceCollection collection)
    {
        public IServiceCollection AddLanguageCatalog()
        {
            collection.AddSingleton<IReadOnlyList<LanguageItem>>(_ => LanguageCatalog.Build());
            return collection;
        }
    }
}
