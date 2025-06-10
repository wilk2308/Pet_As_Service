// CatApiService.cs
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq; // Para usar .FirstOrDefault() e .Select()

namespace Pet_As_Service
{
    public class CatApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "live_jWcvIy6cjkKpdvsSVjOAAIV10vJEA8Ipxx6KwoY5iakspKvKHYFiAsgmlvee4Yy3"; // Sua chave da API

        public CatApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);
        }

        public async Task<List<RacaGato>> GetTodasRacasAsync()
        {
            string url = "https://api.thecatapi.com/v1/breeds";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic breeds = JsonConvert.DeserializeObject(jsonResponse);

            List<RacaGato> racas = new List<RacaGato>();
            foreach (var breed in breeds)
            {
                racas.Add(new RacaGato
                {
                    Id = breed.id,
                    Nome = breed.name,
                    Origem = breed.origin,
                    Temperamento = breed.temperament,
                    // Mapeando para suas propriedades
                    TamanhoPelo = breed.hairless != null && (bool)breed.hairless ? "Sem pelo" : (breed.shedding != null && (int)breed.shedding == 0 ? "Pouco" : "Normal"), // Adaptação da API para TamanhoPelo
                    Cuidados = breed.grooming != null ? $"Nível de cuidado: {breed.grooming}" : "N/A", // Adaptação da API para Cuidados
                    CaminhoImagem = null // Será preenchido por GetImageUrlByBreedIdAsync
                });
            }
            return racas;
        }

        public async Task<string> GetImageUrlByBreedIdAsync(string breedId)
        {
            string url = $"https://api.thecatapi.com/v1/images/search?breed_ids={breedId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic images = JsonConvert.DeserializeObject(jsonResponse);

            if (images != null && images.Count > 0)
            {
                return images[0].url; // Retorna a URL da primeira imagem encontrada
            }
            return null;
        }
    }
}