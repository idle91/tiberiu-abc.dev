using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aetb
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float moyenne;

            Console.WriteLine(" Veuillez saisir un nombre decimal ou non pour A");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine(" Veuillez saisir un nombre decimal ou non pour B");
            b = float.Parse(Console.ReadLine());
            moyenne = (a + b) / 2;
            Console.WriteLine(" La moyenne de deux nombre est : {0:###.000}",moyenne);
            Console.ReadKey();


        }
    }
}
