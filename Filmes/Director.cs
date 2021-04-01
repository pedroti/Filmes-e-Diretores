using System;

namespace Filmes
{
    class Director
    {
        public string movieId;
        public string name;

        public void Show()
        {
            Console.Out.WriteLine($"{name}");
        }
    }
}
