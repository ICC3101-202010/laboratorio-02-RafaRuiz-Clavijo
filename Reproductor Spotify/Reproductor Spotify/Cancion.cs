using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_Spotify
{
    class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
            
        }
        public string Informacion()
        {
            return "genero: " + genero + ", artista: " + artista + ", album: " + album +", nombre:" + nombre;
        }

        public string GetName()
        {
            return this.nombre;
        }

        public string GetGenero()
        {
            return this.genero;
        }

        public string GetArtist()
        {
            return this.artista;
        }

        public string GetAlbum()
        {
            return this.album;
        }
    }
}
