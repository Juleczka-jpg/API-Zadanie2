using MauiApp7.Constants;
using MauiApp7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace MauiApp7.Services
{
    public class CurrencyService
    {
        private readonly HttpClient _client;

        public CurrencyService(HttpClient client)
        {
            _client = client;
        }

        public async Task<double> GetRateAsync(string code)
        {
            try
            {
                string url = $"https://api.nbp.pl/api/exchangerates/rates/a/{code.ToLower()}/?format=json";
                var response = await _client.GetFromJsonAsync<NbpRateResponse>(url);
                return response?.Rates?[0].Mid ?? 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Błąd API NBP: {ex.Message}");
                return 0;
            }
        }
    }
}
