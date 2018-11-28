using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static int CalculSommeEntiers(int inf, int sup)
        {
            int res = 0;
            for (int i = inf; i < sup; i++)
            {
                res = res + i;

            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculSommeEntiers(1, 10));


        









            Console.ReadKey();
        }
    }
}
