using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nom
{
    class Program
    {
        static void Main(string[] args)
        {

            string reponse;

            Console.WriteLine("Lecture du texte !");
            Console.WriteLine("Avez vous compris l'ennonce? o/n");
            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                Console.WriteLine("Relecture de l'énoncé");
                Console.WriteLine("Avez vous compris l'ennonce? o/n"); //sortie 1 form
                reponse = Console.ReadLine();

                if (reponse == "n")
                {

                    Console.WriteLine("Appel du formateur!");
                    Console.WriteLine("Passer à l'énoncé suivant ! "); //sortie 2 relecture

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Passer à l'énoncé suivant ! "); //sortie 3 compréhension

                    Console.ReadKey();
                }




            }
            else
            {

                Console.WriteLine("Passer à l'énoncé suivant ! ");
                Console.ReadKey();

            }







        }
    }
}
