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
        List<Playlist> playing = new List<Playlist>();

        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancion)
        {
            int verificador = 1;
            foreach(Cancion comp in gestor)
            {
                if (comp.Informacion() == cancion.Informacion())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                gestor.Add(cancion);
                Console.WriteLine("Cancion agregada con exito");
                return true;
            }
            else
            {
                Console.WriteLine("Esta cancion ya se encuentra disponible ");
                return false;
            }
        }


        public void VerCanciones()
        {
            int cant_canciones = gestor.Count;
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


        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> buscados = new List<Cancion>();
            switch (criterio)
            {
                case "1":
                    {
                        foreach (Cancion dato in gestor)
                        {
                            if (dato.GetName() == valorCriterio)
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
                            if (dato.GetAlbum() == valorCriterio)
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
                            if (dato.GetArtist() == valorCriterio)
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
                            if (dato.GetGenero() == valorCriterio)
                            {
                                buscados.Add(dato);
                            }

                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ese criterio no existe");
                        return false;
                    }
            }
            Cancion[] buscadosarray = buscados.ToArray();
            if (buscadosarray.Length == 0)
            {
                Console.WriteLine("No se han encontrado canciones con el criterio asociado");
                return false;
            }
            Playlist p = new Playlist(nombrePlaylist,buscadosarray);
            int verificador = 1;
            foreach (Playlist data in playing)
            {
                if (nombrePlaylist == data.GetNamePlaylist())
                {
                    verificador = 0;
                }
            }
            if (verificador == 1)
            {
                playing.Add(p);
                Console.WriteLine("La lista ha sido agregada con exito");
                Console.WriteLine("Nombre Playlist: " + nombrePlaylist);
                for (int i = 0; i < buscadosarray.Length; i++)
                {
                    Console.WriteLine("Cancion " + i + ": " + buscadosarray[i].Informacion());
                }
                return true;
            }
            else
            {
                Console.WriteLine("Existe una playlist con este nombre");
                return false;
            }

        }
        
        public string VerMisPlaylists()
        {
            string datos = "";
            foreach(Playlist mostrar in playing)
            {
                datos += mostrar.GetNamePlaylist() + "\n";
                Cancion[] mostrarplaylist = mostrar.listacancion;
                for (int i = 0; i < mostrarplaylist.Length; i++)
                {
                    datos += "Cancion " + i + ": " + mostrarplaylist[i].Informacion() + "\n";
                }
            }

            return datos;
        }
    }
}
