using QuickMusic.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuickMusic.ClienteBlazor.Services
{
    public class CancionesService : ICancionesService
    {

        private readonly HttpClient _httpClient;
        public  CancionesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       JsonSerializerOptions  options = new JsonSerializerOptions  { PropertyNameCaseInsensitive = true };
        public  async Task<IEnumerable<Canciones>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Canciones");
            return JsonSerializer.Deserialize<IEnumerable<Canciones>>(resp, options);
        }

        public async Task<IEnumerable<Canciones>> GetByCanciones(int id_Artista)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Canciones/Buscar", new { id_Artista =  id_Artista});
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Canciones>>(respString, options);
        }

        public async Task<Canciones> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Canciones/{id}");
            return JsonSerializer.Deserialize<Canciones>(resp, options);


        }

        public async Task<IEnumerable<Canciones>> GetByGenero(int id_Genero)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Canciones/Buscar", new { id_Genero = id_Genero });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Canciones>>(respString, options);
        }
    }
}
