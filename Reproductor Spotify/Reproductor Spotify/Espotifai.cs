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

        public Espotifai()
        {

        }

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
            int cant_canciones = gestor.Count;
            Console.WriteLine(cant_canciones);
            if (cant_canciones == 0)
            {
                Console.WriteLine("No tiene canciones agregadas");
            }
            for (int i = 0; i < cant_canciones; i++)
            {
                Console.WriteLine(gestor[i].Informacion());
            }
        }

        public Cancion[] CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> buscados = new List<Cancion>();

            switch (criterio)
            {
                case "1":
                    {
                        foreach(Cancion dato in gestor)
                        {
                           if (dato.GetName() == valor)
                            {
                                buscados.Add(dato);
                            }
                            
                        }
                        break;
                    }

                case "2":
                    {
                        foreach (Cancion dato in gestor)
                        {
                            if (dato.GetAlbum() == valor)
                            {
                                buscados.Add(dato);
                            }

                        }
                        break;
                    }

                case "3":
                    {
                        foreach (Cancion dato in gestor)
                        {
                            if (dato.GetArtist() == valor)
                            {
                                buscados.Add(dato);
                            }

                        }
                        break;
                    }

                case "4":
                    {
                        foreach (Cancion dato in gestor)
                        {
                            if (dato.GetGenero() == valor)
                            {
                                buscados.Add(dato);
                            }

                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("El criterio ingresado no es valido");
                        return null;
                    }
               
            }

            Cancion[] nuevalistabuscados = new Cancion[buscados.Count];
            foreach (Cancion res in buscados)
            {
                Console.WriteLine(res.Informacion());
                nuevalistabuscados.Append(res);
            }
            if (nuevalistabuscados.Length == 0)
            {
                Console.WriteLine("No se encuentra lo que esta buscando");
            }
            return nuevalistabuscados;
            

            


        }
    }
}
