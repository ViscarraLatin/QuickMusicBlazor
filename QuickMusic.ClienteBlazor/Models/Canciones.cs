using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMusic.ClienteBlazor.Models
{
    public class Canciones
    {
        public int Id { get; set; }
        public int Id_Genero { get; set; }
        public int Id_Artista { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string Cancion { get; set; }
    }
}
