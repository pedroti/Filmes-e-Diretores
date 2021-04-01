using System;
namespace Filmes
{
    class Movie
    {
        public string id;
        public string title;
        public string yearOfRealese;
        public string url;
        public string directorId;

        public void Show()
        {
            Console.Out.WriteLine($"{title} - {yearOfRealese} - {url}");
        }
    }

}
