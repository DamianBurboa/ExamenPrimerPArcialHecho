using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist A8 = new Playlist("Peliculas del año pasado", "Peliculas 2018: ");
            Playlist A9 = new Playlist("Peliculas de este año", "Peliculas 2019:");

            playlists.Add(A8);
            playlists.Add(A9);

            A8.Peliculas.Add(new Pelicula("Pelicula1", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula2", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula3", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula4", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula5", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula6", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));
            A8.Peliculas.Add(new Pelicula("Pelicula7", 2018, " Hermanos Russo", "Accion", "USA", 180, 9.1, "Tiene un gran impacto en el MCU" + "LA pelicula mas taquillera del año"));

            A9.Peliculas.Add(new Pelicula("Pelicula8", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula9", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula10", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula11", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula12", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula13", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));
            A9.Peliculas.Add(new Pelicula("Pelicula14", 2019, "Hermanos Russo", "Drama", "USA", 220, 8.1, "Tiene un gran impacto en el MCU" + " LA pelicula mas taquillera del año"));

            foreach (Playlist playlist in playlists)
            {

                Console.WriteLine("\n\nNombre de playlist: " + playlist.Titulo);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);
                Console.WriteLine("Lista de Pelicula(s):");
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("Titulo: " + pelicula.Titulo + "\nGenero: " + pelicula.Genero + "\nApto para todas las edades" );
                }
            }

            Console.Read();
        }
    }
}