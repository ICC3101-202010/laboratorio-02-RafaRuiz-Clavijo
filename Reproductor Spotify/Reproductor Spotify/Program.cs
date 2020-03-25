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
            string opcion = "0";
            Espotifai menu = new Espotifai();
            while (opcion != "3")
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1) Ver canciones");
                Console.WriteLine("2) Agregar canciones");
                Console.WriteLine("3) Salir del programa");
                opcion = Console.ReadLine();


                if (opcion == "1")
                {
                    menu.VerCanciones();
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Indique el titulo de la cancion: ");
                    string no = Console.ReadLine();
                    Console.WriteLine("Indique el genero de la cancion: ");
                    string ge = Console.ReadLine();
                    Console.WriteLine("Indique el artista de la cancion: ");
                    string ar = Console.ReadLine();
                    Console.WriteLine("Indique el album de la cancion: ");
                    string al = Console.ReadLine();
                    Cancion musica = new Cancion(no, al, ar, ge);
                    menu.AgregarCancion(musica);
                }
            }
            /*
            Cancion music = new Cancion("Cumbia del coronavirus","Pandemia","El Cumbias","Cumbia");
            Espotifai g = new Espotifai();
            Console.WriteLine(music.Informacion());
            bool add1 = g.AgregarCancion(music);
            Console.WriteLine(add1);
            bool add2 = g.AgregarCancion(music);
            Console.WriteLine(add2);
            g.VerCanciones();
            */
        }
    }
}
