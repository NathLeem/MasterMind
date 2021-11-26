using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] propTabl;
            int[] combi;
            int nbrePionRouge;
            string prop;
            ChoixCoul(out combi);
            Afficher(combi);
            CoulJoueur(out propTabl);
            PionRouge(out nbrePionRouge);

            Console.WriteLine();
            Console.WriteLine("entrez votre combinaison de 4 chiffres:");
            prop = Console.ReadLine();

        }

        // la fonction permet à l'ordinateur de choisir une combinaison de quatre chiffres
        static void ChoixCoul(out int[] combi)
        {
            combi = new int[4];
            Random rnd = new Random();
            for(int i = 0; i <= 3; i++)
            {
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }
        // Choix de la combinaison par l'utilisateur
        static void CoulJoueur(int prop,int[] propTabl)
        {
            for (int i = 0; i <= 3; i++)
            {
                propTabl[i] = prop;
            }
        }
        // Affichage de la combinaison
        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(combi[i]);
            }
        }
        // L'ordinateur dit si il y a des pions rouge
        static void PionRouge(int[] combi,int[] propTabl,out int nbrePionRouge)
        {
            nbrePionRouge = 0;
            for (int i = 0; i <= 3; i++)
            {
                if (propTabl[i] == combi[i])
                {
                    nbrePionRouge++;
                    Console.WriteLine($"Il y a {nbrePionRouge} pions rouge.");
                }
            }
        }
    }
}