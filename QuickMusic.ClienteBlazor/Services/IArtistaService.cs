using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickMusic.ClienteBlazor.Models;


namespace QuickMusic.ClienteBlazor.Services
{
   public interface IArtistaService
    {
        Task<IEnumerable<Artista>> GetAll();
        Task<Artista> GetById(int id);
    }
}
