using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Array propTabl;
            int[] combi;
            ChoixCoul(out combi);
            Afficher(combi);
            Console.WriteLine();
            Console.WriteLine("entrez votre combinaison:");

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
        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(combi[i]);
            }
        }
    }
}