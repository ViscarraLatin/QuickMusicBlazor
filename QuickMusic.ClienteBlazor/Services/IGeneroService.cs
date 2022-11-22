using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickMusic.ClienteBlazor.Models;
namespace QuickMusic.ClienteBlazor.Services
{
   public  interface IGeneroService
    {
        Task<IEnumerable<Genero>> GetAll();
        Task<Genero> GetById (int id);
    }
}
