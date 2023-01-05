using System;

namespace Cifrul_Vigenere
{
    class Program
    {
        static void Main()
        {
            //Cifrul Vigenere

            //Citire text

            Console.WriteLine("Textul clar:");
            string t = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Cheia (de tip string si aceeasi lungime ca textul clar):");
            string key = Console.ReadLine();
            Console.WriteLine();
            if (t.Length != key.Length)
            {
                Console.WriteLine("Cheia nu are lungimea potrivita.");
                return;
            }

            //Criptare text

            t = t.ToLower();
            key = key.ToLower();
            string text_criptat = "";
            int i, j;
            for (i = 0, j = 0; i < t.Length; i++, j++)
            {
                if (t[i] >= 'a' && t[i] <= 'z')
                    text_criptat = text_criptat + ((char)((char)((char)((t[i] - 'a') + (key[j] - 'a')) % 26) + 'a'));
                else
                    text_criptat = text_criptat + (t[i]);
            }
            Console.WriteLine("Textul codat:");
            Console.WriteLine(text_criptat);
            Console.WriteLine();

            //Decriptare text

            t = "";
            for (i = 0; i < key.Length; i++)
            {
                if ((char)(text_criptat[i] - (char)(key[i] - 'a')) < 'a')
                    t = t + (char)(text_criptat[i] - (char)(key[i] - 'a') + 26);
                else
                    t = t + (char)(text_criptat[i] - (char)(key[i] - 'a'));
            }
            Console.WriteLine($"Textul decodat:");
            Console.WriteLine(t);
            Console.WriteLine();
        }
    }
}
