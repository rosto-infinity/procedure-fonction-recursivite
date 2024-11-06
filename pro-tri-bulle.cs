// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] tableau = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Tableau original :");
        AfficherTableau(tableau);

        TriBulle(tableau);

        Console.WriteLine("\nTableau trié :");
        AfficherTableau(tableau);
    }

    static void TriBulle(int[] tableau)
    {
        int n = tableau.Length;
        bool echangeEffectue;

        for (int i = 0; i < n - 1; i++)
        {
            echangeEffectue = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tableau[j] > tableau[j + 1])
                {
                    // Échange
                    int temp = tableau[j];
                    tableau[j] = tableau[j + 1];
                    tableau[j + 1] = temp;
                    echangeEffectue = true;
                }
            }

            // Si aucun échange n'a été effectué, le tableau est déjà trié
            if (!echangeEffectue)
                break;
        }
    }

    static void AfficherTableau(int[] tableau)
    {
        foreach (int element in tableau)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

