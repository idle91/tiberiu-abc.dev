using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine(" Introduisez l'année que vous voulez souhaiter si il est Bissextile ou Non bissextile : ");
            a = int.Parse(Console.ReadLine());

            if (a % 4 == 0 && a % 100 != 0 && a % 400 != 0)
            {
                Console.WriteLine(" l'année est bissextile . ");
            }
            else
            {
                Console.WriteLine(" l'année est Non bissextile . ");

            }
            Console.ReadKey();
            
        }
    }
}
