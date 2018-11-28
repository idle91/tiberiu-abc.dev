using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_2
{
    class Banque
    {
        /// <summary>
        /// compte le nombre de comptes
        /// </summary>
        private int NbComptes;
        /// <summary>
        /// lier la banque à ses comptes
        /// </summary>
        private Compte[] LesComptes;


        public Banque()
        {

            LesComptes = new Compte[20];        //crée le tableau 
            this.NbComptes = 0;                 //initialise à 0 le nombre de comptes
        }

        private void AjouteCompte(Compte unCompte)
        {
            LesComptes[NbComptes++] = unCompte;
        }

        public void Init()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            this.AjouteCompte(c1);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            this.AjouteCompte(c2);
            Compte c3 = new Compte(32345, "dupond", 1500, -1500);
            this.AjouteCompte(c3);
            Compte c4 = new Compte(11633, "durand", 1200, -500);
            this.AjouteCompte(c4);
            Compte c5 = new Compte(2568, "dubois", -200, -500);
            this.AjouteCompte(c5);
            Compte c6 = new Compte(8978, "duval", 7500, -2000);
            this.AjouteCompte(c6);

        }

        public void AfficherComptes()
        {
            foreach (Compte i in LesComptes)
            {
                if (i != null)
                {
                    Console.WriteLine(i);
                }
            }

            //for (int i = 0; i < LesComptes.Length; i++)
            //{
            //    if (LesComptes[i] != null)
            //    {
            //        Console.WriteLine(LesComptes[i].ToString());
            //    }
            //}
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        public void AjouteCompte(int _n, string _nom, double _solde, int _dec)
        {
            Compte compteNew = new Compte(_n, _nom, _solde, _dec);
            AjouteCompte(compteNew);
        }

        public void sortArrayStatic()
        {
                LesComptes = LesComptes.OrderByDescending((a => a.Solde)).ToArray();
                foreach (Compte item in LesComptes)
                {
                    Console.WriteLine(item);
                }
        }

        public void CompteSup()
        {
            Compte monCompte=null;
            double max = 0;
            foreach (Compte leCompte in LesComptes)
            {
                if (leCompte!=null && leCompte.Solde>max)
                {
                    monCompte = leCompte;
                    max = leCompte.Solde;
                }
            }
            Console.WriteLine(monCompte.ToString());
        }


    }
}



