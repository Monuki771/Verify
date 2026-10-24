using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Playlist
    {

        public int IdPlayist { get; set; }
        public string NomePlayist { get; set; }
        public string DescPlayist { get; set; }
        public DateTime CriacaoPlayist { get; set; }
        public DateTime AtualizacaoPlayist { get; set; }
        
        // Retorna string porem no sql ta como INT (0 e 1) antes de inserir no banco precisa tratar isso aqui >_<
        // opção da bolinha - Privado ou Publico
        public string Privacidade {  get; set; }
        public int QtdLikes { get; set; }

        // Relações Usuário
        public Usuario IdUsuario { get; set; }

    }

    public class PlaylistCollection : List<Playlist> { }

}
