using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    class Test1
    {

        static void Main()
        {
            bool test = false;
            int nombre;
            int compteur = 0;
            int compteur2 = 0;
            int choixOrdi;
            //bool t = false;


            do
            {
                try
                {
                    do
                    {

                        Console.WriteLine(" Veuillez saisir un nombre compris entre -9 et 9");
                        nombre = int.Parse(Console.ReadLine());
                        test = true;
                        compteur++;
                    } while (nombre <= -9 || nombre >= 9);

                    Console.WriteLine("Votre numero choisit est : " + nombre + " vous étes trompé " + (compteur - 1) + " fois");
                    Console.WriteLine("votre nombre est compris entre -9 et 9  ");
                    do
                    {

                        Console.WriteLine("Maintenant vous saisissez un nombre inférieur à -9 et supérieur à 9");
                        nombre = int.Parse(Console.ReadLine());
                        test = true;
                        compteur2++;
                    } while (nombre > -9 && nombre < 9);
                    Console.WriteLine("Votre numero choisit est :" + nombre + " vous étes trompé " + (compteur2 - 1) + " fois");

                    Random aleas = new Random();
                    choixOrdi = aleas.Next(-100, 100);
                    Console.WriteLine("le nombre choisit par ordi est" + choixOrdi);


                    if (choixOrdi != nombre)
                    {
                        Console.WriteLine("les nombres sont différent");
                        if (choixOrdi > nombre)
                        {
                            Console.WriteLine("ordi gagnant, il a choisit un nombre superieur que " + nombre);

                        }
                        if (choixOrdi < nombre)
                        {
                            Console.WriteLine("vous avez gagne , votre nombre est sup que l'ordi " + choixOrdi);
                        }

                    }
                    else
                    {
                        Console.WriteLine("egalite");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            } while (!test);
            Console.WriteLine("_!_");

            Console.ReadKey();
        }
    }
}