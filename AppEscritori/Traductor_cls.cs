using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppEscritori
{
    internal class Traductor_cls
    {
        private static readonly HttpClient httpClient = new HttpClient();

        
        public static async Task<string> TraducirEspanolACatalanAsync(string textoParaTraducir)
        {
            var url = "http://paumateu.top/traducir_español_catalan";
            var requestBody = new { text_to_translate = textoParaTraducir };

            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return jsonResponse;
            }
            else
            {
                throw new Exception($"Error en la API: {response.StatusCode}");
            }
        }
    }
}
