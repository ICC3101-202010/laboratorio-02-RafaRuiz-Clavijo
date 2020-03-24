using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_Spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion music = new Cancion("Cumbia del coronavirus","Pandemia","El Cumbias","Cumbia");
            Espotifai g = new Espotifai();
            Console.WriteLine(music.Informacion());
            bool add1 = g.AgregarCancion(music);
            Console.WriteLine(add1);
            bool add2 = g.AgregarCancion(music);
            Console.WriteLine(add2);
            g.VerCanciones();
        }
    }
}
