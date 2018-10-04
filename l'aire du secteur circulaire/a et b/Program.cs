using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float moyenne;

            Console.WriteLine(" Veuillez la valeur du nombre decimal ou non A !");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine(" Veuillez la valeur du nombre decimal ou non B!");
            b = float.Parse(Console.ReadLine());
            moyenne = (a + b) / 2;
            Console.WriteLine("La moyenne pour A et B est : {0:##,###.00}", moyenne);
            Console.ReadKey();


        }
    }
}
