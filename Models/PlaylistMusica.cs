using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class PlaylistMusica
    {
        public Playlist IdPlaylist { get; set; }
        public Musica IdMusica { get; set; }
    }

    public class PMCollection : List<PlaylistMusica> { }

}
