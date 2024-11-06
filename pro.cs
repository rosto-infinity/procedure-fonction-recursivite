using System;

class Program
{
    static void Main()
    {
        int[] tableau = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Tableau original : " + string.Join(" ", tableau));
        TriBulle(tableau);
        Console.WriteLine("Tableau trié : " + string.Join(" ", tableau));
    }

    static void TriBulle(int[] tableau)
    {
        int n = tableau.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool echangeEffectue = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (tableau[j] > tableau[j + 1])
                {
                    (tableau[j], tableau[j + 1]) = (tableau[j + 1], tableau[j]); // Échange
                    echangeEffectue = true;
                }
            }
            if (!echangeEffectue) break; // Arrêt si déjà trié
        }
    }
}
