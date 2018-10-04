using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char pr;
            char lpr;
            string prénom;
            string nom;
            string ident;
            
            
            Console.WriteLine( "Quel est votre prénom?");
            prénom = Console.ReadLine();
            Console.WriteLine( "et votre nom ?");
            nom = Console.ReadLine();
            pr = char(prénom,1,1);

            lpr = char(prénom);
            ident = pr + "." + nom;

            Console.WriteLine("Votre prénom de", lpr, "lettres a été abrégé et votre identification est : ", ident);

        }
    }
}
