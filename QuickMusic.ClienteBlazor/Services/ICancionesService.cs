using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickMusic.ClienteBlazor.Models;

namespace QuickMusic.ClienteBlazor.Services
{
   public interface ICancionesService
    {
        Task<IEnumerable<Canciones>> GetAll();

        Task<IEnumerable<Canciones>> GetByCanciones(int id_Artista);
        Task<IEnumerable<Canciones>> GetByGenero(int id_Genero);
        Task<Canciones> GetById(int id);


    }
}
