using QuickMusic.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuickMusic.ClienteBlazor.Services
{
    public class ArtistaService : IArtistaService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ArtistaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Artista>> GetAll()
        {
     
            string resp = await _httpClient.GetStringAsync($"Artista");
            return JsonSerializer.Deserialize<IEnumerable<Artista>>(resp, options);
        }

        public async Task<Artista> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Artista");
            return JsonSerializer.Deserialize<Artista>(resp,options);
        }
    }
}