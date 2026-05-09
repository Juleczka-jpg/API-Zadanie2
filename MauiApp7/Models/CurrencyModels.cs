using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MauiApp7.Models
{
    public class ExchangeRate
    {
        [JsonPropertyName("mid")]
        public double Mid { get; set; }
    }

    public class NbpRateResponse
    {
        [JsonPropertyName("rates")]
        public List<ExchangeRate> Rates { get; set; }
    }
}
