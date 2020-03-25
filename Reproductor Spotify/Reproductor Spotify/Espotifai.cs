using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_Spotify
{
    class Espotifai
    {
        List<Cancion> gestor = new List<Cancion>();

        public bool AgregarCancion(Cancion cancion)
        {
            if (!gestor.Contains(cancion))
            {
                gestor.Add(cancion);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void VerCanciones()
        {
            int cant_canciones;
            if (gestor == null)
            {
                cant_canciones = 0;
                Console.WriteLine("No tiene canciones agregadas");
            }
            else
            {
                cant_canciones = gestor.Count;
                if (cant_canciones == 0)
                {
                    cant_canciones = 0;
                    Console.WriteLine("No tiene canciones agregadas");
                }
                for (int i = 0; i < cant_canciones; i++)
                {
                    Console.WriteLine(gestor[i].Informacion());
                }
            }
            
        }
        
    }
}
