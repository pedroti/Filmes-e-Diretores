using System;

namespace Filmes
{
    class Director
    {
        public string id;
        public string name;

        public void Show()
        {
            Console.Out.WriteLine($"{name}");
        }
    }
}
