using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickMusic.ClienteBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace QuickMusic.ClienteBlazor.Services

{
    public class GeneroService : IGeneroService
    {
        private readonly HttpClient _httpClient;
        public GeneroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public  async Task<IEnumerable<Genero>> GetAll()
        {
        
            string resp = await _httpClient.GetStringAsync($"Genero");
            return JsonSerializer.Deserialize<IEnumerable<Genero>>(resp, options);
        }

        public  async Task<Genero> GetById(int id)
        {

            string resp = await _httpClient.GetStringAsync($"Genero/{id}");
            return JsonSerializer.Deserialize<Genero>(resp, options);
        }
    }
}
