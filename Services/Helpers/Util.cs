using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Services.Helpers
{
    public class Util
    {
        HttpClient _httpClient;
        public Util(string uri)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(uri);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public T Invocar<T>(string path)
        {
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("No se puede invocar al API");
            }
            string contenido = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(contenido);
        }

    }
}
