using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json; // Remova o Newtonsoft.Json se não for mais necessário

namespace AmigoPet.APIService
{
    public class CatApiService
    {
        private readonly HttpClient _httpClient;

        public CatApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.thecatapi.com/v1/")
            };

            _httpClient.DefaultRequestHeaders.Add("x-api-key", "live_fKX1CYdcnuqMtNWIRfFWyRtR9VjHDs8v8LRIWLuhtmZzOUjhF8fSveF0MtUVFLDd");
        }

        public async Task<List<Gato>> GetBreedsAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("breeds");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Resposta JSON: {json}"); // Debug

                    var breeds = JsonSerializer.Deserialize<List<Gato>>(json);
                    return breeds ?? new List<Gato>();
                }
                else
                {
                    throw new Exception($"Erro na resposta da API: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar raças: {ex.Message}");
            }
        }

        public async Task<bool> FavoriteBreedAsync(string imageId)
        {
            try
            {
                var requestBody = new { image_id = imageId, sub_id = "user123" };
                var jsonContent = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("https://api.thecatapi.com/v1/favourites", content);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar dados para favoritos: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Favourite>> GetFavouritesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("favourites");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var favourites = JsonSerializer.Deserialize<List<Favourite>>(json);

                return favourites ?? new List<Favourite>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar favoritos: {ex.Message}");
                return new List<Favourite>();
            }
        }

        public async Task<bool> DeleteFavouriteAsync(int favouriteId)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"favourites/{favouriteId}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir favorito: {ex.Message}");
                return false;
            }
        }
    }

    public class Gato
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public CatImage image { get; set; }
    }

    public class CatImage
    {
        public string id { get; set; }
        public string url { get; set; }
    }
}