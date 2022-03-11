using System;
using System.Collections.Generic;
using System.Linq;

namespace HansJohnnysButikApp
{
    public class Movies : Media
    {        
        public Movies(string fromMoviesCsv)
        {            
            string[] columns = fromMoviesCsv.Split(_separator);

            Title = columns[1];
            Creator = columns[2];
            UserGrade = Convert.ToDouble(columns[3]);
            ReleaseDate = Convert.ToDateTime(columns[4]);
            Length = columns[5];
            Price = _randomizer.Next(49, 259);
        }
        public static void PrintMovies(IEnumerable<Movies> movies)
        {
            IEnumerable<Movies> moviesSortedByReleaseDate = movies.OrderByDescending(p => p.ReleaseDate)
                                           .ThenBy(p => p.Creator)
                                           .ThenBy(p => p.Title)
                                           .ToList();
            
            foreach (var movie in moviesSortedByReleaseDate)
            {
                Console.WriteLine($"Film: {movie.Title}\n     " +
                    $"Regisör: {movie.Creator}\n     " +
                    $"Release datum: {movie.ReleaseDate:yyyy-MM-dd}\n     " +
                    $"Rating:{movie.UserGrade}\n     " +
                    $"Längd:{movie.Length:hh:mm:ss}\n  " +
                    $"   Pris: {movie.Price}:-\n");
            }
        }
    }
}
