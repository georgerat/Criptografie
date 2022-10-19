using System;

namespace Cifrul_ROT13
{
    class Program
    {
        static void Main()
        {
            //Cifrul ROT13
            //E(x) = (x + 13) % 26 , D(x) = (x - 13) % 26

            //Citire text

            Console.WriteLine($"Textul clar:");
            string t = Console.ReadLine();
            Console.WriteLine();

            //Criptare text

            string text_criptat = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] >= 'a' && t[i] <= 'z')
                {
                    text_criptat = text_criptat + (char)((t[i] + 13 - 'a') % 26 + 'a');
                }
                else if (t[i] >= 'A' && t[i] <= 'Z')
                {
                    text_criptat = text_criptat + (char)((t[i] + 13 - 'A') % 26 + 'A');
                }
                else
                    text_criptat = text_criptat + t[i];
            }
            Console.WriteLine($"Textul codat:");
            Console.WriteLine(text_criptat);
            Console.WriteLine();

            //Decriptare text

            t = "";
            for (int i = 0; i < text_criptat.Length; i++)
            {
                if (text_criptat[i] >= 'a' && text_criptat[i] <= 'z')
                {
                    t = t + (char)((text_criptat[i] + 26 - 13 - 'a') % 26 + 'a');
                }
                else if (text_criptat[i] >= 'A' && text_criptat[i] <= 'Z')
                {
                    t = t + (char)((text_criptat[i] + 26 - 13 - 'A') % 26 + 'A');
                }
                else
                    t = t + text_criptat[i];
            }
            Console.WriteLine($"Textul decodat:");
            Console.WriteLine(t);
            Console.WriteLine();
        }
    }
}
