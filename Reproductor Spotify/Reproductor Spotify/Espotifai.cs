using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_Spotify
{
    class Espotifai
    {
        private Cancion[] gestor;

        public bool AgregarCancion(Cancion cancion)
        {
            int cant_canciones;
            if (gestor == null)
            {
                cant_canciones = 0;
            }
            else
            {
                cant_canciones = gestor.Length;
            }
            string[] lista_info = {cancion.GetName(),cancion.GetAlbum(),cancion.GetArtist(),cancion.GetGenero()};
            int verificador = 1;
            for (int i = 0; i < cant_canciones; i++)
            {
                string[] comp_info = {gestor[i].GetName(), gestor[i].GetAlbum(), gestor[i].GetArtist(), gestor[i].GetGenero()};
                if (comp_info == lista_info)
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                gestor.append(cancion);
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
