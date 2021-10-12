using System;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Entrez le nombre des éléments dans le tableau :   ");
            int tialle = Convert.ToInt32(Console.ReadLine());

            int[] t = new int[tialle];
            int i;
            Console.WriteLine();
            for (i = 0; i < tialle; i++)
            {
                Console.Write("Entrez l'élément  " + (i + 1) + " =   ");
                t[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(t);
            Console.Write("\n le tableau est  trié    \n");
            for (i = 0; i < tialle; i++)
            {
                //tialle++;
                Console.WriteLine("l'Elemnet  [{0}] : {1}", (i + 1), t[i]);
            }
            Array.Resize(ref t, t.Length + 1);

            Console.Write("\n\nEntrez la valeur à insérer: ");
            int val = Convert.ToInt32(Console.ReadLine());
            t[i] = val;
            inserer(t);
            Console.ReadKey();
        }


        public static void inserer(int[] t)
        {
            int i;

            for (i = 0; i < t.Length; i++)
            {
                Array.Sort(t);
                Console.WriteLine("l'Elemnet  [{0}] : {1}", (i + 1), t[i]);

            }


            Console.WriteLine();
        }

    }
}