using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp7.Constants
{
    public static class AppConstants
    {
        public static readonly string NbpRateUrl =
            "https://api.nbp.pl/api/exchangerates/rates/a/{0}/?format=json";

        public static readonly string NbpLastRatesUrl =
            "https://api.nbp.pl/api/exchangerates/rates/a/{0}/last/{1}/?format=json";

        public static readonly string NbpTableUrl =
            "https://api.nbp.pl/api/exchangerates/tables/a/?format=json";
    }
}
