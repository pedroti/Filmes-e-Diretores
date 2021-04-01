using System;
using System.Collections.Generic;
using System.IO;

namespace Filmes
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorsPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "directors.txt");
            string moviesPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "arqMovies.txt");
            List<Director> directors = new List<Director>();
            List<Movie> movies = new List<Movie>();
            try
            {
                using (StreamReader sr = new StreamReader(directorsPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Director director = new Director();
                        var informations = line.Split(',');
                        director.id = informations[0];
                        director.name = informations[1];
                        directors.Add(director);
                        director.Show();
                    }
                }

                using (StreamReader sr = new StreamReader(moviesPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Movie movie = new Movie();
                        var informations = line.Split(';');
                        movie.id = informations[0];
                        movie.title = informations[1];
                        movie.yearOfRealese = informations[2];
                        movie.url = informations[3];
                        movie.directorId = informations[4];
                        movies.Add(movie);
                        movie.Show();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            ShowMoviesForEachDirector(movies, directors);
            foreach (var movie in movies)
            {
                IsIdDirectorInDirectors(movie.directorId, directors);
            }
           
        }

        private static void IsIdDirectorInDirectors(string id, List<Director> directors)
        {
            Director director = directors.Find(x => x.id == id);
            if (director != null)
            {
                Console.WriteLine("It is");
            } else
            {
                Console.WriteLine("It isn't");
            }
        }

        private static void ShowMoviesForEachDirector(List<Movie> movies, List<Director> directors)
        {
            foreach (var director in directors)
            {
                Movie movie = movies.Find(x => x.directorId == director.id);
                if (movie != null)
                {
                    Console.WriteLine("Movie: ");
                    movie.Show();
                    Console.WriteLine("Director: ");
                    director.Show();
                }
            }
        }
    }
}
