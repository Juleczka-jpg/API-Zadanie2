using MauiApp7.Models;
using MauiApp7.Services;
using System.Diagnostics;

namespace MauiApp7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetRatesClicked(object sender, EventArgs e)
        {
            // W MAUI HttpClient zazwyczaj żyje przez cały czas działania aplikacji
            using var client = new HttpClient();
            var service = new CurrencyService(client);

            // Pobieranie danych
            double usd = await service.GetRateAsync("usd");
            double eur = await service.GetRateAsync("eur");

            // Wypisanie do debuggera (zgodnie z zadaniem)
            Debug.WriteLine($"[DEBUG] USD: {usd}, EUR: {eur}");

            // Wyświetlenie na ekranie (dla użytkownika)
            if (usd > 0 && eur > 0)
            {
                ResultLabel.Text = $"USD: {usd:F4} PLN\nEUR: {eur:F4} PLN";
            }
            else
            {
                ResultLabel.Text = "Błąd pobierania danych.";
                await DisplayAlert("Błąd", "Nie udało się pobrać kursów walut.", "OK");
            }
        }
    }
}
