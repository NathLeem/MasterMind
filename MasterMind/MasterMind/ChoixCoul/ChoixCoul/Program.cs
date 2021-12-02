using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] propTabl;
            int[] combi;
            int nbrePionRouge = 0;
            int nbrePionBlanc = 0;
            int nbreChance = 12;
            string prop;

            ChoixCoul(out combi);
            Afficher(combi);
            while (nbrePionRouge != 4 || nbreChance != 0)
            {
                Console.WriteLine();
                Console.WriteLine("entrez votre combinaison de 4 chiffres:");
                prop = Console.ReadLine();
                CoulJoueur(prop,out propTabl);
                PionRouge(combi, propTabl, out nbrePionRouge);
                PionBlanc(combi, propTabl, out nbrePionBlanc);
                nbreChance = nbreChance - 1;
            }
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
        static void CoulJoueur(string prop,out int[] propTabl)
        {
            propTabl = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                propTabl[i] = int.Parse(prop[i].ToString());
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
                    propTabl[i] = -1;
                    combi[i] = -2;
                    
                }    
            }
            Console.WriteLine($"Il y a {nbrePionRouge} pions rouge.");
        }
        // l'ordinateur dit s'il y a des pions blanc.
        static void PionBlanc(int[] combi,int[] propTabl,out int nbrePionBlanc)
        {
            nbrePionBlanc = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (propTabl[i] == combi[j])
                    {
                       nbrePionBlanc++;
                       propTabl[i] = -1; 
                    }
                    
                }
            }
            Console.WriteLine($"Il y a {nbrePionBlanc} pions blanc.");
        }
    }
}