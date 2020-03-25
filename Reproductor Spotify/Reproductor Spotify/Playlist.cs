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
        Cancion[] listacancion = new Cancion[] { };

        Playlist(string n)
        {
            nameplaylist = n;
        }


    }
}
