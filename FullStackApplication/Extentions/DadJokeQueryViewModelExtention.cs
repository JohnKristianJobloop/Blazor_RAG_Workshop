using System;
using FullStackApplication.ViewModels;
using Microsoft.AspNetCore.WebUtilities;

namespace FullStackApplication.Extentions;

public static class DadJokeQueryViewModelExtention
{
    extension(DadJokeQueryViewModel Model)
    {
        public string ToQueryString(string baseAdress)
        {
            if (Model.Page > 0) baseAdress = QueryHelpers.AddQueryString(baseAdress, nameof(Model.Page).ToLower(), Model.Page.ToString());
            if (!string.IsNullOrWhiteSpace(Model.Term)) baseAdress = QueryHelpers.AddQueryString(baseAdress, nameof(Model.Term).ToLower(), Model.Term);
            if (Model.Limit > 0)baseAdress = QueryHelpers.AddQueryString(baseAdress, nameof(Model.Limit).ToLower(), Model.Limit.ToString());
            return baseAdress;
        }
    }
}
