using Newtonsoft.Json;
using static ConvertorDeMoedasWindowsForms.Form1;

namespace ConvertorDeMoedas
{
    public class Rates
    {
        private static API_Obj apiData;

        public static bool Import()
        {
            string URLString = "https://v6.exchangerate-api.com/v6/122ab198b167980f0dc770f5/latest/USD";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URLString);
                apiData = JsonConvert.DeserializeObject<API_Obj>(json);
                return true;
            }
        }

        public static double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            if (apiData == null) throw new InvalidOperationException("Dados de câmbio não carregados.");

            double fromRate = GetConversionRate(fromCurrency);
            double toRate = GetConversionRate(toCurrency);
            return (amount / fromRate) * toRate;
        }

        private static double GetConversionRate(string currencyCode)
        {
            var conversionRates = apiData.conversion_rates;
            var rateProperty = conversionRates.GetType().GetProperty(currencyCode);
            if (rateProperty != null)
            {
                return (double)rateProperty.GetValue(conversionRates);
            }
            else
            {
                throw new ArgumentException("Moeda desconhecida");
            }
        }
    }
}
