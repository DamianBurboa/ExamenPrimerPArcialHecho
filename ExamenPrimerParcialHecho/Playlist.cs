using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Peliculas { get; set; }

        public Playlist()
        {
            Titulo = "Sin titulo de playlist";
            Descripcion = "Sin descripcion de playlist";
            Peliculas = new List<Pelicula>();
        }
        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Peliculas = new List<Pelicula>();
        }
    }
}