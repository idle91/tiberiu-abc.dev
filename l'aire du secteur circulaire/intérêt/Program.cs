using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            double s;
            int n;
            double i;
            int reponse = 0;
            double valeuraquise;
            bool testnb;


            Console.WriteLine("Combien souhaitez vous placer?");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Souhaitez vous placer argent sur un compte bloqué (intérêt compose):1 ou sur un compte rémunéré( intérêt simple):2 ?");
            testnb=int.TryParse(Console.ReadLine(),out reponse);

            if (reponse == 1 && testnb ==true)
            {
                Console.Write("Combien d'année de placement?");
                n=int.Parse(Console.ReadLine());
                Console.Write("Quel est le taux de placement? %");
                i=double.Parse(Console.ReadLine());












            Console.ReadKey();







        }
    }
}
