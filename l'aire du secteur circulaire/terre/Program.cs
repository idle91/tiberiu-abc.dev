using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terre
{
    class Program
    {
        static void Main(string[] args)
        {

            double r;
            double a;
            double v;

            Console.WriteLine(" Quelle est le rayon de la sphère ?");
            r = double.Parse(Console.ReadLine());
            a = 4 * Math.PI * Math.Pow(r, 2);
            v = (double)4 / 3 * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("Laire de la sphère de rayon R : {0:###;###} km est {1:##,###.00} km² et son volume est {2:#,###.###} km³", r, a, v);

            Console.ReadKey();

        }
    }
}
