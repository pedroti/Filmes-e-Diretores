using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Filmes
{
    class Program
    {
        static  void Main(string[] args)
        {
            string directorsPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "directors.txt");
            ArrayList diretores = new ArrayList();
            try
            {
                using (StreamReader sr = new StreamReader(directorsPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.Out.WriteLine(line);
                        diretores.Add(line.Split(','));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
