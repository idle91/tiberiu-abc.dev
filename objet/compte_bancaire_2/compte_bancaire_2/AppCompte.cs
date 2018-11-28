using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_2
{
    class AppCompte
    {
        static void Main(string[] args)
        {

            Banque b = new Banque();
            b.Init();
            b.AjouteCompte(1245, "dutronc", 4500, -500);

            b.AfficherComptes();


            b.AjouteCompte(1, "tib", 999999, -1000000);
            b.AfficherComptes();

            b.CompteSup();

            Console.WriteLine("\n\n----------------------------------------GAME OVER--------------------------------------------");


            Console.ReadKey();
        }
    }
}
