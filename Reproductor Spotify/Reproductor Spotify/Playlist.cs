using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_Spotify
{
    class Playlist
    {
        private string nameplaylist;
        public Cancion[] listacancion = new Cancion[] { };

        public Playlist(string n, Cancion[] l)
        {
            nameplaylist = n;
            listacancion = l;

        }

        public string GetNamePlaylist()
        {
            return this.nameplaylist;
        }

    }
}
