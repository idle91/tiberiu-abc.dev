using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age
{
    class Program
    {
        static void Main(string[] args)
        {
            string réponse;
            int age;
            Console.WriteLine("Votre age:?");
            réponse = Console.ReadLine();            //lecture d’une chaine
            age = int.Parse(réponse);                   // conversion de chaine en entier
            Console.WriteLine("age = " + age);  // affichage chaine concaténée

            Console.ReadKey();



        }
    }
}
