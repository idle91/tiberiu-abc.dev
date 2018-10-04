using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ennoce1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("Lecture de l'énnonce");
            Console.WriteLine("Avez-vous compris l'énnoncé ?o/n");
            reponse=Console.ReadLine();
            if(reponse=="n")
            {
                Console.WriteLine("Relecture de l'énnonce");
                Console.WriteLine("Avez-vous compris l'énnonce ?o/n");
                reponse=Console.ReadLine();
                
                if (reponse =="n")
	             {
		            Console.WriteLine("Appel du formateur");
                    Console.WriteLine("Passer à l'énnoncé suivant ! sortie 1 form");
           
                    Console.ReadKey();
 
                }
                else 
                {
                    Console.WriteLine("Passer à l'énnocé suivant ! sortie 2 relecture");
                    
                    Console.ReadKey();

                }
            

              }
              else
              {
                    Console.WriteLine("Passer à l'énnocé suivant ! sortie 3 comprehension");
                    Console.ReadKey();
                
              }

        }
    }
}
