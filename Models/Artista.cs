using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Artista
    {

        public int IdArtista { get; set; }
        public string NomeArtistico { get; set; }
        public string NomeReal { get; set; }
        public string Biografia { get; set; }
        public DateTime DataNascimento { get; set; }
        public string GeneroMusicalPrincipal { get; set; }
        public DateTime DataInicioCarreira{ get; set; }

    }

    public class ArtistaCollection : List<Artista> { }

}
